using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Proyecto_CRUD_POO_LINQ.Entities
{
    public class Empleados
    {
        [Key]
        public int ID { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public DateTime Fecha_Ingreso { get; set; }

        [ForeignKey("IDArea")]
        public int IDArea { get; set; }

}
}
