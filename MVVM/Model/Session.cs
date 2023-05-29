using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Confiho.MVVM.Model
{
    public class Session
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string code { get; set; }
        public int rol_id { get; set; }
    }
}
