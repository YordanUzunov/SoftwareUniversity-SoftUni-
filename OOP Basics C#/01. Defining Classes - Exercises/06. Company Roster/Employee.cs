public class Employee
{
    public Employee(string name, decimal salary, string position, string department)
    {
        this.Name = name;
        this.Salary = salary;
        this.Position = position;
        this.Department = department;
    }

    public Employee(string name, decimal salary, string position, string department, string email, int age)
        : this(name, salary, position, department)
    {
        this.Email = email;
        this.Age = age;
    }

    public string Name { get; }

    public decimal Salary { get; }

    public string Department { get; }

    public string Email { get; }

    public int Age { get; }

    public string Position { get; }
}
