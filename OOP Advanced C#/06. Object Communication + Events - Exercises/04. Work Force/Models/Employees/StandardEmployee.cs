namespace P04_WorkForce.Models.Employees
{
    public class StandartEmployee : Employee
    {
        private const int HoursPerWeek = 40;

        public StandartEmployee(string name)
            : base(name, HoursPerWeek)
        {
        }
    }
}
