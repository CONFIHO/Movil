using Confiho.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Confiho.Services
{
    public class PresupuestoService
    {
        public ObservableCollection<Presupuesto> presupuestos { get; set; }

        private static PresupuestoService _instance = null;

        public static PresupuestoService getInstance()
        {
            if (_instance == null)
            {
                _instance = new PresupuestoService();
                return _instance;
            }
            else
            {
                return _instance;
            }
        }

        private PresupuestoService() { }
    }
}
