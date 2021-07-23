using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneWeek2Academy
{
    public class TransferMovement : IMovement
    {
        public double Importo { get; set; }
        public DateTime MovDate { get; set; }

        public string SourceBank { get; set; }
        public string TargetBank { get; set; }

        public override string ToString()
        {
            return $"Cash Transaction of :{Importo}$\nDate :{MovDate}\nFrom :{SourceBank}\nTo :{TargetBank} ";
        }

        public TransferMovement(double importo, DateTime movDate, string sourcebank,string targetbank)
        {
            Importo = importo;
            MovDate = movDate;
            SourceBank = sourcebank;
            TargetBank = targetbank;

        }
    }
}
