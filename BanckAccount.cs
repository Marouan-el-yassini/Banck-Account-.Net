using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountt
{
    public class BanckAccount
    {
        public string Owner { get; set; }
        public Guid id { get; set; }
        public double balence { get; private set; }

        public BanckAccount(string owner)
        {
            Owner = owner;
            id = Guid.NewGuid();
            balence = 0;
        }
        public string Deposit(double amount)
        {
            if(amount > 0 && amount<260000)
            {
                balence += amount;
                return "Deposit done";
            }
            else
            {
                return "Invalid Deposit";
            }
        }
        public string Withdraw(double amount)
        {
            if(amount>balence || amount < 0)
            {
                return "Invalid Whithdraw";

            }
            else
            {
                balence -= amount;
                return "Whithdraw Done";
            }
        }
        

        

    }

}
