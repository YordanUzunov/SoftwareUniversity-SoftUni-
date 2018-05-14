namespace UnitTests
{
    using NUnit.Framework;
    using System.Linq;
    using P02_ExtendedDatabase.Models;

    [TestFixture]
    public class P02_PersonTests
    {
        [Test]
        public void ConstructorInitializationWorks()
        {
            var person = new Person(123, "Test");

            Assert.AreNotEqual(null, person);
            Assert.AreEqual(123, person.Id);
            Assert.AreEqual("Test", person.Username);
        }

        [Test]
        public void AllPropertiesHaveNonPublicSetters()
        {
            var personType = typeof(Person);
            var propertiesWithPublicSetters = personType
                .GetProperties()
                .Where(p => p.SetMethod.IsPublic)
                .ToArray();

            Assert.AreEqual(0, propertiesWithPublicSetters.Length);
        }
    }
}
