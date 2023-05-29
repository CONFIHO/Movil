using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Confiho.MVVM.Model
{
    public class Gasto
    {
        public int id { get; set; }
        public string description { get; set; }
        public string Type { get; set; }
        public double value { get; set; }
        public String file_name { get; set; }
        public Byte[] fileData { get; set; }
        public DateTime expense_date { get; set; }
        public int category_id { get; set; }
        public int budget_id { get; set; }
    }
}
