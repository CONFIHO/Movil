using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Confiho.MVVM.Model
{
    public class Presupuesto
    {
        public string Admin { get; set; }

        public double Current { get; set; }

        public double Total { get; set; }
        
        public List<Gasto> Gastos { get; set; }

        public double Percentaje {
            get
            {
                return Current * 100 / Total;
            }
        }
    }
}
