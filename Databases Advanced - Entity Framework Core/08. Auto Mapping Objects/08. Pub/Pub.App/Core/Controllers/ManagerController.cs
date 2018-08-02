using AutoMapper.QueryableExtensions;
using Pub.App.Core.Contracts;
using Pub.App.Core.DTOs;
using Pub.Data;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Pub.App.Core.Controllers
{
    public class ManagerController : IManagerController
    {
        private readonly PubContext context;

        public ManagerController(PubContext context)
        {
            this.context = context;
        }

        public ManagerDto GetManagerInfo(int employeeId)
        {
            var employee = context.Employees
                                  .Where(x => x.Id == employeeId)
                                  .ProjectTo<ManagerDto>()
                                  .SingleOrDefault();

            if (employee == null)
            {
                throw new ArgumentException("Invalid ID!");
            }

            return employee;
        }

        public void SetManager(int employeeId, int managerId)
        {
            var employee = this.context.Employees.Find(employeeId);

            var manager = this.context.Employees.Find(managerId);

            if (employee == null || manager == null)
            {
                throw new ArgumentException("Invalid ID!");
            }

            employee.Manager = manager;

            context.SaveChanges();


        }
    }
}
