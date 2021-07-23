using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneWeek2Academy
{
    public class CreditCardMovement
    {
        public enum System
        {
            amex,
            visa,
            mastercard,
            others

        }
        public double Importo { get; set; }
        public DateTime MovDate { get; set; }
        
        public System Sis { get; set; }

        public override string ToString()
        {
            return $"Cash Transaction of :{Importo}$\nDate :{MovDate}\nFrom :{Sis}";
        }

        public CreditCardMovement(double importo, DateTime movDate, System sis)
        {
            Importo = importo;
            MovDate = movDate;
            Sis = sis;
        }
    }
}
