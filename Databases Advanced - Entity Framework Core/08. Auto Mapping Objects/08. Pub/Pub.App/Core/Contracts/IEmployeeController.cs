namespace Pub.App.Core.Contracts
{
    using Pub.App.Core.DTOs;
    using System;

    public interface IEmployeeController
    {
        void AddEmployee(EmployeeDto employeeDto);

        void SetBirthday(int employeeId, DateTime date);

        void SetAddress(int employeeId, string address);

        EmployeeDto GetEmployeeInfo(int employeeId);

        EmployeePersonalInfoDto GetEmployeePersonalInfo(int employeeId);

        string[] GetEmployeesOlderThanAge(int age);
    }
}
