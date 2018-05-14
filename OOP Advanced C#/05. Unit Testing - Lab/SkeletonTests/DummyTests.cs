using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace SkeletonTests
{
    public class DummyTests
    {
        private const int initialHealth = 10;  // to avoid MAGIC numbers;

        [Test]
        public void DummyLosesHealthAfterAttack()
        {

            var dummy = new Dummy(initialHealth, 20);

            dummy.TakeAttack(5);
            Assert.That(dummy.Health, Is.EqualTo(5));
            //Assert.AreEqual(5, dummy.Health);   //SAME
        }
    }
}
