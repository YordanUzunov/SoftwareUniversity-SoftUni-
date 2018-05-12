public class Person
{
    public Person(string firtsName, string lastName, int age, double salary)
    {
        this.FirstName = firtsName;
        this.LastName = lastName;
        this.Age = age;
        this.Salary = salary;
    }

    public string FirstName { get; }

    public string LastName { get; }

    public int Age { get; }

    public double Salary { get; private set; }

    public void IncreaseSalary(double percent)
    {
        if (this.Age > 30)
        {
            this.Salary += this.Salary * percent / 100;
        }
        else
        {
            this.Salary += this.Salary * percent / 200;
        }
    }

    public override string ToString()
    {
        return $"{this.FirstName} {this.LastName} get {this.Salary:F2} leva";
    }
}