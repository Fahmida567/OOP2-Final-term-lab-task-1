using System;
using System.Collections.Generic;
using System.Text;

namespace abstruct_Bank_Management_System
{
     class Fixed:Account
    {
        private int tenureYear;

        public int TenureYear
        {
            get { return tenureYear; }
            set { tenureYear = value; }
        }

        private int createYear;

        public int CreateYear
        {
            get { return CreateYear; }
            set { CreateYear = value; }
        }

        public Fixed()
        {

        }

        public Fixed(string accName, string accNo, double balance, int createYear, int tenureYear) : base(accName, accNo, balance)
        {

            this.createYear = createYear;
            this.tenureYear = tenureYear;

        }

        public override void Withdraw(double ammount)
        {
            string currentYear = DateTime.Now.Year.ToString();
            int cyear = Int32.Parse(currentYear);
            if ((cyear - createYear) >= tenureYear && Balance - ammount >= 0)
            {
                Balance -= ammount;
                Console.WriteLine("Withdraw successfull for fixed account");
            }

            else
            {
                if ((cyear - createYear) < tenureYear)
                    Console.WriteLine("Cannot withdraw amount right now");
                else
                    Console.WriteLine(" balance is insufficient");
            }
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Account Opening Year: " + createYear);
            Console.WriteLine("Account Tenure Year: " + tenureYear);
        }

    }
}

