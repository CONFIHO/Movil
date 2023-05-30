using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Confiho.MVVM.Model
{
    public class Vinculations
    {
        public int id { get; set; }
        public string admin_nickname { get; set; }
        public UserName user_budget_admin_idTouser { get; set; }
    }
}
