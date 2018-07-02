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
            }
        }

        public class CheckingAccount : BankAccount
        {
            public double CheckingServiceFee { get; set; }

            public void checkingServiceFeeTransaction(double checkingServiceFee)
            {
                var serviceFeeTransaction = AccountTotal - checkingServiceFee;
                AccountTotal = serviceFeeTransaction;
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
                    return firstTransaction;
                }
            }
        }

        static void Main(string[] args)
        {
            var bankAccount1 = new BankAccount
            {
                AccountNumber = 123456,
                AccountOwner = "Josh",
                AccountTotal = 1000.00,
                AccountType = "Checking"
            };

        }
    }
}
