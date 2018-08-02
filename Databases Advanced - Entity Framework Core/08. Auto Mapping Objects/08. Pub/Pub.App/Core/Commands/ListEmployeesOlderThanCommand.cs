namespace Pub.App.Core.Commands
{
    using System.Text;
    using Pub.App.Core.Contracts;    

    public class ListEmployeesOlderThanCommand : ICommand
    {
        private readonly IEmployeeController employeeController;

        public ListEmployeesOlderThanCommand(IEmployeeController employeeController)
        {
            this.employeeController = employeeController;
        }

        public string Execute(string[] args)
        {
            var sb = new StringBuilder();

            int age = int.Parse(args[0]);

            var employeesListOlderThanAge = this.employeeController.GetEmployeesOlderThanAge(age);

            foreach (var emp in employeesListOlderThanAge)
            {
                sb.AppendLine(emp);
            }

            return sb.ToString().TrimEnd();

        }
    }
}
