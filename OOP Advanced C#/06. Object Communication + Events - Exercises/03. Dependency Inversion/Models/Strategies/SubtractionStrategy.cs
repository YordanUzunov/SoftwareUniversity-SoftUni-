namespace P03_DependencyInversion.Models
{
    using P03_DependencyInversion.Interfaces;

    public class SubtractionStrategy : IStrategy
    {
        public int Calculate(int firstOperand, int secondOperand)
        {
            return firstOperand - secondOperand;
        }
    }
}
