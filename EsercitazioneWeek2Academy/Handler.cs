using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneWeek2Academy
{
    class Handler
    {
        //crea nuovo account
        public Account brandnew = new Account();

        public bool SchermoMenu()
        {
            Console.WriteLine("1 - New Account\n2 - New transaction\n3 - Print Recap\n\t4 - Exit");
            int pick = Choice(4);
            switch (pick)
            {
                case 1:
                    NewAccount();
                    break;
                case 2:
                    NewTransaction();
                    break;
                case 3:
                    PrintRecap();
                    break;
                case 4:
                    return false;
                default:
                    Console.WriteLine("Errore");
                    return false;
            }
            return true;
        }

        private void PrintRecap()
        {
           brandnew.Statement(brandnew);
        }

        private void NewTransaction()
        {
            throw new NotImplementedException();
        }

        private void NewAccount()
        {
            var x = new Account()
            {
                AccountNumber = 12173624,
                Balance = 127821,
                BankName = "Chase",
                LastTransaction = new DateTime(12 / 12 / 12)

            };


        }

        private int Choice(int pick)
        {

            while (pick < 1 || pick > 4)
            {
                Console.WriteLine("Immetti un valore corretto\n");
                Int32.TryParse(Console.ReadLine(), out pick);
            }
            return pick;
        }
    }
}
