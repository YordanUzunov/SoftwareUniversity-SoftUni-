namespace UnitTests
{
    using System;
    using NUnit.Framework;
    using P09_DateTimeTesting;

    [TestFixture]
    public class P09_DateTimeTests
    {
        private IDatetime now;

        [SetUp]
        public void TestInit()
        {
            this.now = new MyDatetime();
        }

        [Test]
        public void NowShouldReturnCurrentDate()
        {
            var expectedValue = DateTime.Now.Date;

            Assert.AreEqual(expectedValue, this.now.Now().Date);
        }

        [Test]
        public void AddingADayToTheLastOneOfAMonthShouldResultInTheFirstDayOfTheNextMonth()
        {
            var testDate = new DateTime(2000, 10, 31);
            var expectedDate = new DateTime(2000, 11, 1);

            testDate = testDate.AddDays(1);

            Assert.AreEqual(expectedDate, testDate);
        }
    }
}
