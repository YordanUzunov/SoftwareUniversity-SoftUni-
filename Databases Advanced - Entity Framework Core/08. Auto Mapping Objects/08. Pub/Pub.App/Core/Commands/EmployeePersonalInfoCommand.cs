namespace Pub.App.Core.Commands
{
    using Pub.App.Core.Contracts;
    using System;

    public class EmployeePersonalInfoCommand : ICommand
    {
        private readonly IEmployeeController employeeController;

        public EmployeePersonalInfoCommand(IEmployeeController employeeController)
        {
            this.employeeController = employeeController;
        }

        public string Execute(string[] args)
        {
            int id = int.Parse(args[0]);

            var empDto = this.employeeController.GetEmployeePersonalInfo(id);

            return $"ID: {empDto.Id} - {empDto.FirstName} {empDto.LastName} - ${empDto.Salary:f2}" + Environment.NewLine 
                +  $"Birthday: {empDto.Birthday.Value.ToString("dd-MM-yyyy")}" + Environment.NewLine
                +  $"Address: {empDto.Address}";
        }
    }
}
