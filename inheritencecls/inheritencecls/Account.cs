using System;
using System.Collections.Generic;
using System.Text;

namespace inheritencecls
{
    class Account
    {
        private int id;
        private double amount;
        private string accType;


        public void setId(int id)
        {
            this.id = id;
        }
        
        public void setAmount(double amount)
        {
            this.amount = amount;
        }


        public void setaccType(string accType)
        {
            this.accType = accType;
        }

        public Account(int id, double amount, string accType)
        {
            this.id = id;
            this.amount = amount;
            this.accType = accType;
        }

        public void display()
        {

            Console.WriteLine("Id:" + id);
            Console.WriteLine("Amount:" + amount);
            Console.WriteLine("accType:" + accType);


        }

    }
}
