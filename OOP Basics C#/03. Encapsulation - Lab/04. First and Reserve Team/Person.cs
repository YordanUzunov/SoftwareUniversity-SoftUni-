public class Person
{
    public Person(string firtsName, string lastName, int age, double salary)
    {
        this.FirstName = firtsName;
        this.LastName = lastName;
        this.Age = age;
        this.Salary = salary;
    }

    public int Age { get; }

    public string FirstName { get; }

    public string LastName { get; }

    public double Salary { get; }

}