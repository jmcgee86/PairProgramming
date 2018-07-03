using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairProgramming
{
    class Program
    {
        public class BankAccount
        {
            public int AccountNumber { get; set; }
            public string AccountOwner { get; set; }
            public double AccountTotal { get; set; }
            public string AccountType { get; set; }
            public BankAccount(int accountNumber, string accountOwner, double accountTotal, string accountType)
            {
                AccountNumber = accountNumber;
                AccountOwner = accountOwner;
                AccountTotal = accountTotal;
                AccountType = accountType;
            }

           
            public void BankAccountTransaction(double transactionAmount)
            {
                var totalTransaction = AccountTotal + transactionAmount;
                AccountTotal = totalTransaction;
            }

        }

        public class SavingsAccount : BankAccount
        {
            public double SavingsInterest { get; set; }

            public void SavingsInterestTransaction(double savingsInterest)
            {
                var interestTransaction = AccountTotal + (AccountTotal + savingsInterest);
                AccountTotal = interestTransaction;
                Object [] transactionData = new Object[]{interestTransaction, AccountTotal}
                enqueue(transactionData);
            }
        }

        public class CheckingAccount : BankAccount
        {


            public double CheckingServiceFee { get; set; }

            public CheckingAccount()
            {

            }

            public void checkingServiceFeeTransaction(double checkingServiceFee)
            {
                var serviceFeeTransaction = AccountTotal - checkingServiceFee;
                AccountTotal = serviceFeeTransaction;
                Object [] transactionData = new Object[]{serviceFeeTransaction, AccountTotal}
                enqueue(transactionData);
            }
        }

        public class Transactions : BankAccount
        {
            public double TransactionAmount { get; set; }
            public DateTime TransactionDateTime { get; set; }
            public double TransactionAccountNumber { get; set; }


            class TransactionQueue
            {
               List<Array> _queue = new List<Array>();

                void enqueue(Array transactionData)
                {
                    _queue.Add(transactionData);
                }

                Array dequeue()
                {
                    var firstTransaction = _queue[0];
                    _queue.RemoveAt(0);
                    System.Console.WriteLine(firstTransaction);
                    return firstTransaction;
                }
            }
        }

        static void Main(string[] args)
        {
            var bankAccount1 = new CheckingAccount();
        
                bankAccount1.AccountNumber = 123456,
                bankAccount1.AccountOwner = "Josh",
                bankAccount1.AccountTotal = 1000.00,
                bankAccount1.AccountType = "Checking"
                bankAccount1.CheckingServiceFee = 2.00;
            

            bankAccount1.checkingServiceFeeTransaction(bankAccount1.CheckingServiceFee);
            dequeue();
        }
    }
}
