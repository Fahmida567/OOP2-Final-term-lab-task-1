using System;
using System.Collections.Generic;
using System.Text;

namespace abstruct_Bank_Management_System
{
     class Savings:Account
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


    
        public Savings()
    
        {

    
        }

    
        public Savings(string accName, string accNo, double balance, int transactionNo) : base(accName, accNo, balance)
   
        {
      
            this.transactionNo = transactionNo;
  
        }

   
        public override void Withdraw(double amount)
    
        {
        transCount++;
        if (transCount <= transactionNo && Balance - amount >= 500)
        {
            Balance -= amount;
            Console.WriteLine(" Withdraw Successfull for savings account");
        }
        else
        {
            if (transCount > transactionNo)
            {
                Console.WriteLine("Minimum  transaction ");
            }

            else
                Console.WriteLine("Insufficient Balance");
        }

    }

}
}
