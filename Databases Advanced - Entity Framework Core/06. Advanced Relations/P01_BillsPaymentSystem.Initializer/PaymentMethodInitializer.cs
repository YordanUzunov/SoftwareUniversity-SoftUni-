namespace P01_BillsPaymentSystem.Initializer
{
    using P01_BillsPaymentSystem.Data.Models;

    public class PaymentMethodInitializer
    {
        public static PaymentMethod[] GetPaymentMethods()
        {
            PaymentMethod[] paymentMethods = new PaymentMethod[]
            {
                new PaymentMethod() {UserId = 1, BankAccountId = 1, Type = PaymentMethodType.BankAccount},
                new PaymentMethod() {UserId = 1, BankAccountId = 1, Type = PaymentMethodType.CreditCard},
                new PaymentMethod() {UserId = 2, BankAccountId = 2, Type = PaymentMethodType.BankAccount},
                new PaymentMethod() {UserId = 3, BankAccountId = 2, Type = PaymentMethodType.BankAccount},
                new PaymentMethod() {UserId = 3, BankAccountId = 3, Type = PaymentMethodType.CreditCard},
                new PaymentMethod() {UserId = 4, BankAccountId = 4, Type = PaymentMethodType.BankAccount},
                new PaymentMethod() {UserId = 5, BankAccountId = 3, Type = PaymentMethodType.CreditCard},
                new PaymentMethod() {UserId = 4, BankAccountId = 4, Type = PaymentMethodType.CreditCard},
                new PaymentMethod() {UserId = 6, BankAccountId = 6, Type = PaymentMethodType.BankAccount},
                new PaymentMethod() {UserId = 7, BankAccountId = 7, Type = PaymentMethodType.CreditCard},
                new PaymentMethod() {UserId = 8, BankAccountId = 9, Type = PaymentMethodType.BankAccount},
                new PaymentMethod() {UserId = 10, BankAccountId = 11, Type = PaymentMethodType.BankAccount},
                new PaymentMethod() {UserId = 11, BankAccountId = 12, Type = PaymentMethodType.CreditCard},
                new PaymentMethod() {UserId = 12, BankAccountId = 14, Type = PaymentMethodType.BankAccount},
                new PaymentMethod() {UserId = 13, BankAccountId = 13, Type = PaymentMethodType.CreditCard},

                };

                return paymentMethods;
        }
    }
}


