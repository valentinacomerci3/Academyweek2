using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneWeek2Academy
{
    public class Account 
    {
        private List<IMovement> items = new List<IMovement>();
        public int AccountNumber { get; set; }
        public string BankName { get; set; }
        public double Balance { get; set; }
        public DateTime LastTransaction { get; set; }

        

        public Account Add(double a)
        {
            
            Account update = new Account();
            update.Balance = this.Balance + a;
            update.LastTransaction = DateTime.Now;
            return update;


        }
        public static Account operator +(Account a, double b)
        => a.Add(b);

        public Account Subtract(double a)
        {
            Account update = new Account();
            update.AccountNumber = this.AccountNumber;
            update.BankName = this.BankName;
            update.Balance = this.Balance - a;
            update.LastTransaction = DateTime.Now;
            return update;
        }

        public static Account operator -(Account a, double b)
        => a.Subtract(b);

        public override string ToString()
        {
            return $"Here is your account recap:\n{AccountNumber}\n {BankName}\n{Balance}\n{LastTransaction}\n{items} ";
        }

        public void Statement(Account a)
        {
            Console.WriteLine(this.ToString());
        }

        
        public Account(int accountnumber, string bankname, double balance, DateTime lasttransaction)
        {
            AccountNumber = accountnumber;
            BankName = bankname;
            Balance = balance;
            LastTransaction = lasttransaction;
        }

        public Account()
        {
        }
    }
}
