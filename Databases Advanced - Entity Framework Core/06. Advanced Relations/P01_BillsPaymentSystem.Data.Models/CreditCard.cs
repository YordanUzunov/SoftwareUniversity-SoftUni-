namespace P01_BillsPaymentSystem.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    public class CreditCard
    {
        public int CreditCardId { get; set; }

        public decimal Limit { get; set; }

        public decimal MoneyOwed { get; set; } // make private setter after seeding the data in the database through the .Initializer

        [NotMapped]
        public decimal LimitLeft => Limit - MoneyOwed;

        public DateTime ExpirationDate { get; set; }

        public PaymentMethod PaymentMethod { get; set; }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                this.MoneyOwed -= amount;
            }
        }

        public void Withdraw(decimal amount)
        {
            if (LimitLeft - amount >= 0)
            {
                this.MoneyOwed += amount;
            }
        }
    }
}
