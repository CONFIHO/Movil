using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Confiho.MVVM.Model
{
    public class Budget
    {
        public int id { get; set; }
        public DateTime start_date { get; set; }
        public DateTime end_date { get; set; }
        public double value { get; set; }
        public double current_consumption { get; set; }
        public int budget_id { get; set; }
        public List<Gasto> expense { get; set; }
    }
}
