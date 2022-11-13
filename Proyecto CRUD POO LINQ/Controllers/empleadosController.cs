using Proyecto_CRUD_POO_LINQ.Entities;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_CRUD_POO_LINQ.Controllers
{
    public class empleadosController
    {
        public empleadosController()
        {
            _Empleados = new List<Empleados>();
        }

        private List<Empleados> _Empleados;
        public List<Empleados> Empleados { get { return _Empleados; } }


        //Llenamos la lista
        #region LLENAR LISTA
        public void LlenarLista()
        {
            Empleados.Clear();
            Empleados.Add(new Empleados()
            {
                ID = 1,
                Nombres = "Mariana",
                Apellidos = "Pajon",
                Direccion = "Cra 56",
                Telefono = "2346789",
                Fecha_Ingreso = new DateTime(2019, 06, 09),
                IDArea = 2
            });

            Empleados.Add(new Empleados()
            {
                ID = 2,
                Nombres = "Rigoberto",
                Apellidos = "Uran",
                Direccion = "Cra 45",
                Telefono = "7896789",
                Fecha_Ingreso = new DateTime(2016, 12, 09),
                IDArea = 1
            });
        }
        #endregion


        //Listar los Empleados
        #region GET LIST
        public void getList()
        {
            List<Empleados> lista = new List<Empleados>();
            lista.AddRange(from o in Empleados select o);
            if (lista.Count > 0)
            {
                imprimirController.ImprimirEmpleados(lista);
            }
            else
            {
                Console.WriteLine("\n[]");
            }
        }
        #endregion


        //Listar Empleado Por ID
        #region GET BY ID
        public void getByID(int ID)
        {
            List<Empleados> lista = new List<Empleados>();
            lista.AddRange(from o in Empleados where o.ID == ID orderby o.ID descending select o);
            if (lista.Count > 0)
            {
                imprimirController.ImprimirEmpleados(lista);
            }
            else
            {
                Console.WriteLine($"\nNo exite el ID # {ID} en nuestra BD");
            }
        }
        #endregion


        //Crear Empleado
        #region POST EMPLOYEE
        public void postEmployee(int id, string nombres, string apellidos, string direccion,
           string telefono, DateTime fechaingreso, int idarea)
        {
            var verificarId = Empleados.Any(i => i.ID == id);
            if (!verificarId)
            {
                Empleados.Add(new Empleados()
                {
                    ID = id,
                    Nombres = nombres,
                    Apellidos = apellidos,
                    Direccion = direccion,
                    Telefono = telefono,
                    Fecha_Ingreso = fechaingreso,
                    IDArea = idarea
                });
                Console.WriteLine("\nEmpleado creado exitosamente!!");
            }
            else
            {
                Console.WriteLine("\nEste ID ya existe");
            }
        }
        #endregion


        //Actualizar Empleado
        #region UPDATE EMPLOYEE
        public void updateEmployee(int id, string nombres, string apellidos, string direccion,
            string telefono, DateTime fechaingreso, int idarea)
        {
            var ReplaceItem = new Empleados
            {
                ID = id,
                Nombres = nombres,
                Apellidos = apellidos,
                Direccion = direccion,
                Telefono = telefono,
                Fecha_Ingreso = fechaingreso,
                IDArea = idarea
            };
            var element = Empleados.FirstOrDefault(i => i.ID == ReplaceItem.ID);
            if (element != null)
            {
                Empleados.Remove(element);
                Empleados.Add(ReplaceItem);
                Console.WriteLine("\nEmpleado actualizado con exito!!");
            }
            else
            {
                Console.WriteLine("\nError 505");
            }
        }
        #endregion


        //Eliminar Empleado
        #region DELETE BY ID
        public void deleteByID(int ID)
        {
            //var EliminarItem = new Productos { Id = id };
            var element = Empleados.FirstOrDefault(i => i.ID == ID);
            if (element != null)
            {
                Empleados.Remove(element);
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
