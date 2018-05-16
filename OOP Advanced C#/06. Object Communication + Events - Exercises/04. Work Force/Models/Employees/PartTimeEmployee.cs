namespace P04_WorkForce.Models.Employees
{
    public class PartTimeEmployee : Employee
    {
        private const int HoursPerWeek = 20;

        public PartTimeEmployee(string name)
            : base(name, HoursPerWeek)
        {
        }
    }
}
