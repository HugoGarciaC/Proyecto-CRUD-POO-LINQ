using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Proyecto_CRUD_POO_LINQ.Entities
{
    public class Nomina
    {
        public int ID { get; set; }
        public DateTime Fecha { get; set; }

        [ForeignKey("IDEmpleado")]
        public int IDEmpleado { get; set; }
        public decimal Sueldo { get; set; }
        public int Dias { get; set; }
        public decimal Total_Basico { get { return (Sueldo * Dias / 30) + 60000;} set { ; } } 
        public decimal Total_Devengado { get {return Total_Basico + 117000;} set { ; } }
    }
}
