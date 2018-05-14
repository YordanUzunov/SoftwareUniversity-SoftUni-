namespace P02_ExtendedDatabase.Models
{
    using Interfaces;

    public class Person : IPerson
    {
        public Person (long id, string username)
        {
            this.Id = id;
            this.Username = username;
        }

        public string Username { get; private set; }

        public long Id { get; private set; }
    }
}
