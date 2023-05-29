using Confiho.MVVM.Model;
using Confiho.Services;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Confiho.MVVM.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class MainVM
    {
        public ObservableCollection<Presupuesto> presupuestos { get; set; }

        public MainVM() {
            presupuestos = PresupuestoService.getInstance().presupuestos;
        }  
    }
}
