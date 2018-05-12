public class Person
{
    public Person(string firtsName, string lastName, int age)
    {
        this.FirstName = firtsName;
        this.LastName = lastName;
        this.Age = age;
    }

    public string FirstName { get; }

    public string LastName { get; }

    public int Age { get; }


    public override string ToString()
    {
        return $"{this.FirstName} {this.LastName} is a {this.Age} years old.";
    }
}