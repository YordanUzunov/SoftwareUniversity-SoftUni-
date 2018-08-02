namespace Pub.App.Core.Controllers
{
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using Pub.App.Core.Contracts;
    using Pub.App.Core.DTOs;
    using Pub.Data;
    using Pub.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class EmployeeController : IEmployeeController
    {
        private readonly PubContext context;
        private readonly IMapper mapper;

        public EmployeeController(PubContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public void AddEmployee(EmployeeDto employeeDto)
        {
            var employee = mapper.Map<Employee>(employeeDto);

            this.context.Employees.Add(employee);

            this.context.SaveChanges();
        }

        public void SetAddress(int employeeId, string address)
        {
            var employee = context.Employees.Find(employeeId);

            if (employee == null)
            {
                throw new ArgumentException("Invalid ID!");
            }

            employee.Address = address;

            context.SaveChanges();
        }

        public void SetBirthday(int employeeId, DateTime date)
        {
            var employee = context.Employees.Find(employeeId);

            if (employee == null)
            {
                throw new ArgumentException("Invalid ID!");
            }

            employee.Birthday = date;

            context.SaveChanges();
        }

        public EmployeeDto GetEmployeeInfo(int employeeId)
        {
            var employee = context.Employees
                                  .Where(x => x.Id == employeeId)
                                  .ProjectTo<EmployeeDto>()
                                  .SingleOrDefault();  //returns Collection that's why SingleOrDef.

            if (employee == null)
            {
                throw new ArgumentException("Invalid ID!");
            }

            return employee;
        }

        public EmployeePersonalInfoDto GetEmployeePersonalInfo(int employeeId)
        {
            var employee = context.Employees
                                  .Where(x => x.Id == employeeId)
                                  .ProjectTo<EmployeePersonalInfoDto>()
                                  .SingleOrDefault();  //returns Collection that's why SingleOrDef.

            if (employee == null)
            {
                throw new ArgumentException("Invalid ID!");
            }

            return employee;
        }

        public string[] GetEmployeesOlderThanAge(int age)
        {
            var employees = this.context.Employees
                .Where(e => e.Birthday != null)
                .Select(e => new
                {
                    Employee = Mapper.Map<EmployeeDto>(e),
                    Manager = Mapper.Map<ManagerDto>(e.Manager),
                    Age = Math.Ceiling((DateTime.Now - e.Birthday.Value).TotalDays / 365.2422),
                    e.Salary
                })
                .Where(e => e.Age > age)
                .OrderByDescending(e => e.Salary)
                .Select(e => e.Manager == null
                    ? $"{e.Employee.FirstName} {e.Employee.LastName} - ${e.Employee.Salary:F2} - Manager: [no manager]"
                    : $"{e.Employee.FirstName} {e.Employee.LastName} - ${e.Employee.Salary:F2} - Manager: {e.Manager.LastName}")
                .ToArray();

            return employees;
        }

    }
}
