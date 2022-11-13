using Proyecto_CRUD_POO_LINQ.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_CRUD_POO_LINQ.Controllers
{
    public class nominaController
    {
        public nominaController()
        {
            _Nomina = new List<Nomina>();
        }

        private List<Nomina> _Nomina;
        public List<Nomina> Nomina { get { return _Nomina; } }


        //Llenamos la lista
        #region LLENAR LISTA
        public void LlenarLista()
        {
            Nomina.Clear();
            Nomina.Add(new Nomina()
            {
                ID = 1,
                Fecha = new DateTime(2022, 06, 09),
                IDEmpleado = 1,
                Sueldo = 2500000,
                Dias = 30,
            });

            Nomina.Add(new Nomina()
            {
                ID = 2,
                Fecha = new DateTime(2022, 10, 09),
                IDEmpleado = 2,
                Sueldo = 2700000,
                Dias = 30,
            });
        }
        #endregion


        //Mostrar Registros de Nomina
        #region GET LIST
        public void getList()
        {
            List<Nomina> lista = new List<Nomina>();
            lista.AddRange(from o in Nomina select o);
            if (lista.Count > 0)
            {
                imprimirController.ImprimirNomina(lista);
            }
            else
            {
                Console.WriteLine("\n[]");
            }
            imprimirController.ImprimirNomina(lista);
        }
        #endregion


        //Mostrar Registro de Nomina Por ID
        #region GET BY ID
        public void getByID(int ID)
        {
            List<Nomina> lista = new List<Nomina>();
            lista.AddRange(from o in Nomina where o.ID == ID orderby o.ID descending select o);
            if (lista.Count > 0)
            {
                imprimirController.ImprimirNomina(lista);
            }
            else
            {
                Console.WriteLine($"\nNo exite el ID # {ID} en nuestra BD");
            }
        }
        #endregion


        //Crear Registro de Nomina
        #region POST PAYROLL
        public void postPayroll(int id, DateTime fecha, int idempleado, decimal sueldo,
            int dias)
        {
            var verificarId = Nomina.Any(i => i.ID == id);
            if (!verificarId)
            {
                Nomina.Add(new Nomina()
                {
                    ID = id,
                    Fecha = fecha,
                    IDEmpleado = idempleado,
                    Sueldo = sueldo,
                    Dias = dias
                });
                Console.WriteLine("\nRegistro de Nomina creado exitosamente!!");
            }
            else
            {
                Console.WriteLine("\nEste ID ya existe");
            }
        }
        #endregion


        //Actualizar Registro de Nomina
        #region UPDATE PAYROLL
        public void updatePayroll(int id, DateTime fecha, int idempleado, decimal sueldo,
            int dias)
        {
            var ReplaceItem = new Nomina
            {
                ID = id,
                Fecha = fecha,
                IDEmpleado = idempleado,
                Sueldo = sueldo,
                Dias = dias
            };
            var element = Nomina.FirstOrDefault(i => i.ID == ReplaceItem.ID);
            if (element != null)
            {
                Nomina.Remove(element);
                Nomina.Add(ReplaceItem);
                Console.WriteLine("\nRegistro de Nomina actualizado con exito!!");
            }
            else
            {
                Console.WriteLine("\nError 505");
            }
        }
        #endregion


        //Eliminar Registro de Nomina
        #region DELETE BY ID
        public void deleteByID(int ID)
        {
            //var EliminarItem = new Productos { Id = id };
            var element = Nomina.FirstOrDefault(i => i.ID == ID);
            if (element != null)
            {
                Nomina.Remove(element);
                Console.WriteLine($"\nRegistro con ID: {ID} fue eliminado exitosamente");
            }
            else
            {
                Console.WriteLine("\nNo hay elemento que coincida con el ID proporcionado");
            }
        }
        #endregion

    }
}
