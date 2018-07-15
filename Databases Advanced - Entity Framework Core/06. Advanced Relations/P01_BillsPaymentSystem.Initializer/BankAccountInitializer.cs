namespace P01_BillsPaymentSystem.Initializer
{
    using P01_BillsPaymentSystem.Data.Models;

    public class BankAccountInitializer
    {
        public static BankAccount[] GetBankAccounts()
        {
            BankAccount[] bankAccounts = new BankAccount[]
            {
                new BankAccount() {BankName = "Bank1", SwiftCode = "BRB", Balance = 2131.00m },
                new BankAccount() {BankName = "Bank2", SwiftCode = "ASD", Balance = 1000.20m },
                new BankAccount() {BankName = "Bank3", SwiftCode = "DGD", Balance = 2222.00m },
                new BankAccount() {BankName = "Bank4", SwiftCode = "PLS", Balance = 3333.50m },
                new BankAccount() {BankName = "Bank5", SwiftCode = "MMR", Balance = 2555.00m },
                new BankAccount() {BankName = "Bank6", SwiftCode = "BBB", Balance = 2421.70m },
                new BankAccount() {BankName = "Bank7", SwiftCode = "AAA", Balance = 2551.00m },
                new BankAccount() {BankName = "Bank8", SwiftCode = "GGG", Balance = 2751.54m },
                new BankAccount() {BankName = "Bank9", SwiftCode = "OOO", Balance = 1588.55m },
                new BankAccount() {BankName = "Bank10", SwiftCode = "VVV", Balance = 3231.00m },
                new BankAccount() {BankName = "Bank11", SwiftCode = "ZZZ", Balance = 3221.02m },
                new BankAccount() {BankName = "Bank12", SwiftCode = "SOS", Balance = 3251.00m },
                new BankAccount() {BankName = "Bank13", SwiftCode = "KKK", Balance = 5551.27m },
                new BankAccount() {BankName = "Bank14", SwiftCode = "RIP", Balance = 6236.00m },
                new BankAccount() {BankName = "Bank15", SwiftCode = "BRB", Balance = 7754.00m },

            };

            return bankAccounts;
        }

    }
}
