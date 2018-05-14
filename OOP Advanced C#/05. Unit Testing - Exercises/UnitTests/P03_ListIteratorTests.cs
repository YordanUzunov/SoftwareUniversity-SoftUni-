namespace UnitTests
{
    using System;
    using System.Linq;
    using System.Reflection;
    using NUnit.Framework;
    using P03_IteratorTest;

    [TestFixture]
    public class P03_ListIteratorTests
    {
        private ListIterator listIterator;
        private string[] initializingCollection;

        [SetUp]
        public void TestInitialization()
        {
            this.initializingCollection = new string[] { "asd", "qwe", "zxc" };
            this.listIterator = new ListIterator(this.initializingCollection);
        }

        [Test]
        public void InitializationConstructorCannotWorkWithNull()
        {
            Assert.Throws<ArgumentNullException>(() => new ListIterator(null));
        }

        [Test]
        public void MoveReturnsTrueWhenSuccessful()
        {
            Assert.AreEqual(true, this.listIterator.Move());
            Assert.AreEqual(true, this.listIterator.Move());
        }

        [Test]
        public void MoveReturnsFalseWhenThereAreNoMoreElements()
        {
            this.listIterator.Move();
            this.listIterator.Move();

            Assert.AreEqual(false, this.listIterator.Move());
        }

        [Test]
        public void MoveChangesTheInternalIndexToTheNextElementInTheCollection()
        {
            this.listIterator.Move();
            var internalIndexValue = typeof(ListIterator)
                .GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                .First(f => f.Name == "currentIndex")
                .GetValue(this.listIterator);

            Assert.AreEqual(1, internalIndexValue, "Move doesn't influence the internal index");
        }

        [Test]
        public void HasNextReturnsTrueIfThereIsNextElement()
        {
            this.listIterator.Move();

            Assert.IsTrue(this.listIterator.HasNext());
        }

         [Test]
         public void HasNextReturnsFalseIfThereIsNoNextElement()
        {
            this.listIterator.Move();
            this.listIterator.Move();

            Assert.IsFalse(this.listIterator.HasNext());
        }

        [Test]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        public void PrintReturnsCurrentElement(int elementToReturn)
        {
            for (int i = 0; i < elementToReturn; i++)
            {
                this.listIterator.Move();
            }

            Assert.AreEqual(this.initializingCollection[elementToReturn],
                this.listIterator.Print(),
                "Print doesn't return correct element");
        }

        [Test]
        public void CannotPrintWithEmptyIterator()
        {
            this.listIterator = new ListIterator(new string[0]);

            var ex = Assert.Throws<InvalidOperationException>(() => this.listIterator.Print());
            Assert.AreEqual("Invalid Operation!", ex.Message, "Attempting to print over empty iterator throws exeption with an incorrect message");
        }
    }
}
