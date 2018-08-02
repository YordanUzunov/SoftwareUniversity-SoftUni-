namespace Pub.App.Core.Commands
{
    using Pub.App.Core.Contracts;

    public class SetAddressCommand : ICommand
    {
        private readonly IEmployeeController employeeController;

        public SetAddressCommand(IEmployeeController employeeController)
        {
            this.employeeController = employeeController;
        }

        public string Execute(string[] args)
        {
            int id = int.Parse(args[0]);
            string address = args[1];

            this.employeeController.SetAddress(id, address);

            return "Address was set successfully!";
        }
    }
}
