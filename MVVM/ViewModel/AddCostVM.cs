using Confiho.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Confiho.MVVM.ViewModel
{
    public class AddCostVM
    {
        public string Admin { get; set; }
        public Gasto Gasto { get; set; }
        public AddCostVM(string Admin)
        {
            this.Admin = Admin;
        }
    }
}
