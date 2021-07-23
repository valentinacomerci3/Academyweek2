using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneWeek2Academy
{
    public class CashMovement : IMovement
    {
        public double Importo { get; set; }
        public DateTime MovDate { get; set; }

        public string Executor { get; set; }

        public override string ToString()
        {
            return $"Cash Transaction of :{Importo}$\nDate:{MovDate}\nFrom:{Executor}";
        }

        public CashMovement(double importo, DateTime movDate, string executor)
        {
            Importo = importo;
            MovDate = movDate;
            Executor = executor;
        }
    }
}
