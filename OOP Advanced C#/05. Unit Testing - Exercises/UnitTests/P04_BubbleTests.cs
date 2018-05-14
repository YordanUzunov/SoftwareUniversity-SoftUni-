namespace UnitTests
{
    using NUnit.Framework;
    using P04_BubbleSortTest;

    [TestFixture]
    public class P04_BubbleTests
    {
        [Test]
        [TestCase(3, 5, 9, 4, 2, 1, 7, 8, 6)]
        [TestCase(9, 8, 7, 6, 5, 4, 3, 2, 1)]
        public void BubbleSortValid(params int[] numbersToSort)
        {
            var bubble = new Bubble();
            var sortedNumbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            bubble.Sort(numbersToSort);

            CollectionAssert.AreEqual(sortedNumbers, numbersToSort);
        }
    }
}
