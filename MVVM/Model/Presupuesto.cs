using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Confiho.MVVM.Model
{
    public class Presupuesto
    {
        public int id { get; set; }
        public int consumer_id { get; set; }
        public int admin_id { get; set; }
        public string consumer_nickname { get; set; }
        public string admin_nickname { get; set; }
        public DateTime create_at { get; set; }
        public string status { get; set; }
        public Budget budget_history { get; set; }
        public double Percentaje {
            get
            {
                return budget_history.current_consumption * 100 / budget_history.value;
            }
        }

        public List<CostType> percentages { get; set; }
    }
}
