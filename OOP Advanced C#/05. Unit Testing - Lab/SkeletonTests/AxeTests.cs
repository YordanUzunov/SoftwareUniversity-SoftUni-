using System;
using NUnit.Framework;

namespace SkeletonTests
{
    public class AxeTests
    {
        [Test]
        public void AxeLosesDurabilityAfterAttack()
        {
            var axe = new Axe(5, 10);   //Arrange
            var dummy = new Dummy(20, 20);  //Arrange
            axe.Attack(dummy);  //Act
            Assert.That(axe.DurabilityPoints, Is.EqualTo(9));  //Assert
        }

        [Test]
        public void BrokenAxeCannotAttack()
        {
            var axe = new Axe(5, 0);   
            var dummy = new Dummy(20, 20);  
            Assert.That(() => axe.Attack(dummy), 
                Throws.InvalidOperationException
                .With.Message.EqualTo("Axe is broken."));  

        }
    }
}
