﻿namespace P03_DependencyInversion
{
    using P03_DependencyInversion.Interfaces;
    using P03_DependencyInversion.Models;

    public class PrimitiveCalculator
    {
        private IStrategy strategy;

        public PrimitiveCalculator()
        {
            this.strategy = new AdditionStrategy();
        }

        public void ChangeStrategy(char @operator)
        {
            switch (@operator)
            {
                case '+': this.strategy = new AdditionStrategy(); break;
                case '-': this.strategy = new SubtractionStrategy(); break;
                case '*': this.strategy = new MultiplyStrategy(); break;
                case '/': this.strategy = new DivideStrategy(); break;
            }
        }

        public int PerformCalculation(int firstOperand, int secondOperand)
        {
            return this.strategy.Calculate(firstOperand, secondOperand);
        }
    }
}
