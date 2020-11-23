using System;
using System.Collections.Generic;
using System.Text;

namespace abstruct_Bank_Management_System
{
    abstract class SpecialSavings:Account
    {
        private int transactionNo;

        public int TransactionNo
        {
            get { return transactionNo; }
            set { transactionNo = value; }
        }

        private int transCount;

        public int TransCount
        {
            get { return transCount; }
            set { transCount = value; }
        }

        private double initialBalance;

        public double InitialBalance
        {
            get { return initialBalance; }
            set { initialBalance = value; }
        }

        private int depositeCount;

        public int DepositeCount
        {
            get { return depositeCount; }
            set { depositeCount = value; }
        }


        public SpecialSavings()
        {

        }

        public SpecialSavings(string accName, string accNo, double balance, int transactionNo) : base(accName, accNo, balance)
        {
            this.transactionNo = transactionNo;
            DepositeCount++;
            if (depositeCount == 1)
            {
                InitialBalance = balance;

            }
            InitialBalance = balance;
        }

        public override void Withdraw(double amount)
        {
            transCount++;
            if ((transCount <= transactionNo) && (Balance - amount >= (InitialBalance / 5)))
            {
                Balance -= amount;
                Console.WriteLine(" Withdraw successfull for special savings account..");
            }
            else
            {
                if (transCount > transactionNo)
                {
                    Console.WriteLine("Minimum transaction");
                }

                else
                    Console.WriteLine(" Balance is insufficient");
            }

        }

    }
}
    