using Confiho.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Confiho.MVVM.ViewModel
{
    public class PresupuestoVM
    {
        public ObservableCollection<Presupuesto> presupuestos { get; set; }

        public PresupuestoVM() {
            presupuestos = new ObservableCollection<Presupuesto>
            {
                new Presupuesto
                {
                    Admin = "Papa",
                    Current = 10000,
                    Total = 20000,
                    Gastos = new List<Gasto>
                    {
                        new Gasto
                        {
                            Description = "Camisa Adidas",
                            Value = 2000,
                            Type = "Ropa"
                        },
                        new Gasto
                        {
                            Description = "Camisa Adidas",
                            Value = 2000,
                            Type = "Ropa"
                        },
                        new Gasto
                        {
                            Description = "Camisa Adidas",
                            Value = 2000,
                            Type = "Ropa"
                        },
                        new Gasto
                        {
                            Description = "Camisa Adidas",
                            Value = 2000,
                            Type = "Ropa"
                        },
                        new Gasto
                        {
                            Description = "Camisa Adidas",
                            Value = 2000,
                            Type = "Ropa"
                        },
                    }
                },
                new Presupuesto
                {
                    Admin = "Mama",
                    Current = 12000,
                    Total = 15000,
                    Gastos = new List<Gasto>
                    {
                        new Gasto
                        {
                            Description = "Camisa Adidas",
                            Value = 2000,
                            Type = "Ropa"
                        },
                        new Gasto
                        {
                            Description = "Camisa Adidas",
                            Value = 2000,
                            Type = "Ropa"
                        },
                        new Gasto
                        {
                            Description = "Camisa Adidas",
                            Value = 2000,
                            Type = "Ropa"
                        },
                        new Gasto
                        {
                            Description = "Camisa Adidas",
                            Value = 2000,
                            Type = "Ropa"
                        },
                        new Gasto
                        {
                            Description = "Camisa Adidas",
                            Value = 2000,
                            Type = "Ropa"
                        },
                    }
                },
                new Presupuesto
                {
                    Admin = "Tio",
                    Current = 8000,
                    Total = 30000,
                    Gastos = new List<Gasto>
                    {
                        new Gasto
                        {
                            Description = "Camisa Adidas",
                            Value = 2000,
                            Type = "Ropa"
                        },
                        new Gasto
                        {
                            Description = "Camisa Adidas",
                            Value = 2000,
                            Type = "Ropa"
                        },
                        new Gasto
                        {
                            Description = "Camisa Adidas",
                            Value = 2000,
                            Type = "Ropa"
                        },
                        new Gasto
                        {
                            Description = "Camisa Adidas",
                            Value = 2000,
                            Type = "Ropa"
                        },
                        new Gasto
                        {
                            Description = "Camisa Adidas",
                            Value = 2000,
                            Type = "Ropa"
                        },
                    }
                }
            };
        }  
    }
}
