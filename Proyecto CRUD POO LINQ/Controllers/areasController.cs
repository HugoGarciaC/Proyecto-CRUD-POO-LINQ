using Proyecto_CRUD_POO_LINQ.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_CRUD_POO_LINQ.Controllers
{
    public class areasController
    {
        public areasController()
        {
            _Areas = new List<Areas>();
        }

        private List<Areas> _Areas;
        public List<Areas> Areas { get { return _Areas; } }


        //Llenamos la lista
        #region LLENAR LISTA
        public void LlenarLista()
        {
            Areas.Clear();
            Areas.Add(new Areas()
            {
                ID = 1,
                Nombre = "Tecnología",
            });

            Areas.Add(new Areas()
            {
                ID = 2,
                Nombre = "Facturación",
            });
        }
        #endregion


        //Listamos todas las Areas
        #region GET LIST
        public void getList()
        {
            List<Areas> lista = new List<Areas>();
            lista.AddRange(from o in Areas select o);
            if (lista.Count > 0)
            {
                imprimirController.ImprimirAreas(lista);
            }
            else
            {
                Console.WriteLine("\n[]");
            }
        }
        #endregion


        //Listar Area Por ID
        #region GET BY ID
        public void getByID(int ID)
        {
            List<Areas> lista = new List<Areas>();
            lista.AddRange(from o in Areas where o.ID == ID orderby o.ID descending select o);
            if (lista.Count > 0)
            {
                imprimirController.ImprimirAreas(lista);
            }
            else
            {
                Console.WriteLine($"\nNo exite el ID # {ID} en nuestra BD");
            }
        }
        #endregion


        //Crear Area
        #region POST AREA
        public void postArea(int id, string nombre)
        {
            var verificarId = Areas.Any(i => i.ID == id);
            if (!verificarId)
            {
                Areas.Add(new Areas()
                {
                    ID = id,
                    Nombre = nombre,
                });
                Console.WriteLine("\nArea creada exitosamente!!");
            }
            else
            {
                Console.WriteLine("\nEste ID ya existe");
            }
        }
        #endregion


        //Actualizar Area
        #region UPDATE AREA
        public void updateArea(int id, string nombre)
        {
            var ReplaceItem = new Areas
            {
                ID = id,
                Nombre = nombre,
            };
            var element = Areas.FirstOrDefault(i => i.ID == ReplaceItem.ID);
            if (element != null)
            {
                Areas.Remove(element);
                Areas.Add(ReplaceItem);
                Console.WriteLine("\nArea actualizada con exito!!");
            }
            else
            {
                Console.WriteLine("\nError 505");
            }
        }
        #endregion


        //Eliminar Area
        #region DELETE BY ID
        public void deleteByID(int ID)
        {
            //var EliminarItem = new Productos { Id = id };
            var element = Areas.FirstOrDefault(i => i.ID == ID);
            if (element != null)
            {
                Areas.Remove(element);
                Console.WriteLine($"\nRegistro con ID: {ID} fue eliminado exitosamente");
            }
            else
            {
                Console.WriteLine("\nNo hay elemento coincidente con el ID proporcionado");
            }
        }
        #endregion

    }
}
