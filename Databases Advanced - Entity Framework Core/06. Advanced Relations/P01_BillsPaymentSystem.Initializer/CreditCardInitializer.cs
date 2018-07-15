namespace P01_BillsPaymentSystem.Initializer
{
    using P01_BillsPaymentSystem.Data.Models;
    using System;

    public class CreditCardInitializer
    {
        public static CreditCard[] GetCreditCards()
        {
            CreditCard[] creditCards = new CreditCard[]
            {
                new CreditCard() { Limit = 5000, MoneyOwed = 0, ExpirationDate = DateTime.Now.AddMonths(-10)},
                new CreditCard() { Limit = 6000, MoneyOwed = 0, ExpirationDate = DateTime.Now.AddMonths(-11)},
                new CreditCard() { Limit = 4000, MoneyOwed = 0, ExpirationDate = DateTime.Now.AddMonths(-12)},
                new CreditCard() { Limit = 3000, MoneyOwed = 0, ExpirationDate = DateTime.Now.AddMonths(-14)},
                new CreditCard() { Limit = 11000, MoneyOwed = 0, ExpirationDate = DateTime.Now.AddMonths(-15)},
                new CreditCard() { Limit = 22000, MoneyOwed = 0, ExpirationDate = DateTime.Now.AddMonths(-16)},
                new CreditCard() { Limit = 33000, MoneyOwed = 0, ExpirationDate = DateTime.Now.AddMonths(-17)},
                new CreditCard() { Limit = 5000, MoneyOwed = 0, ExpirationDate = DateTime.Now.AddMonths(-18)},
                new CreditCard() { Limit = 10000, MoneyOwed = 0, ExpirationDate = DateTime.Now.AddMonths(-19)},
                new CreditCard() { Limit = 15000, MoneyOwed = 0, ExpirationDate = DateTime.Now.AddMonths(-20)},
                new CreditCard() { Limit = 25000, MoneyOwed = 0, ExpirationDate = DateTime.Now.AddMonths(-21)},
                new CreditCard() { Limit = 35000, MoneyOwed = 0, ExpirationDate = DateTime.Now.AddMonths(-20)},
                new CreditCard() { Limit = 55000, MoneyOwed = 0, ExpirationDate = DateTime.Now.AddMonths(-22)},
                new CreditCard() { Limit = 45000, MoneyOwed = 0, ExpirationDate = DateTime.Now.AddMonths(-23)},
                new CreditCard() { Limit = 25000, MoneyOwed = 0, ExpirationDate = DateTime.Now.AddMonths(-24)},

            };

            return creditCards;
        }
    }
}
