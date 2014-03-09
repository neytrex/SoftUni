//A bank account has a holder name (first name, middle name and last name), available amount of money
//(balance), bank name, IBAN, 3 credit card numbers associated with the account. Declare the variables
//needed to keep the information for a single bank account using the appropriate data types and 
//descriptive names.

namespace BankAccountData
{
    using System;
    using System.Text;

    public class Account
    {
        public Account(string firsName, string middleName, string lastName, decimal balance, string bankName, string iban, ulong[] creditCartNumbers)
            : this()
        {
            this.FirsName = firsName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Balance = balance;
            this.BankName = bankName;
            this.Iban = iban;
            this.CreditCartNumbers = creditCartNumbers;
        }

        public Account()
        {
            this.CreditCartNumbers = new ulong[3];
        }

        public string FirsName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public decimal Balance { get; set; }

        public string BankName { get; set; }

        public string Iban { get; set; }

        public ulong[] CreditCartNumbers { get; set; }


        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine(string.Format("First Name: {0}", this.FirsName));
            output.AppendLine(string.Format("Middle Name: {0}", this.MiddleName));
            output.AppendLine(string.Format("Last Name: {0}", this.LastName));
            output.AppendLine(string.Format("Balance: {0}", this.Balance));
            output.AppendLine(string.Format("Bank Name: {0}", this.BankName));
            output.AppendLine(string.Format("IBAN: {0}", this.Iban));
            for (int i = 0; i < this.CreditCartNumbers.Length; i++)
            {
                output.AppendLine(string.Format("Credit Cart {0}: {1}",i, this.CreditCartNumbers[i]));
            }

            return output.ToString().TrimEnd();
        }
    }


    class BankAccountData
    {
        static void Main()
        {
            Account bank = new Account("Elthon", "MidlleName", "John", 1110M, "No reklam", "12345hg12r3", new ulong[]{123456, 12345, 234567});

            Console.WriteLine(bank);
        }
    }
}
