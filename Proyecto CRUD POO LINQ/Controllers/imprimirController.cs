using Proyecto_CRUD_POO_LINQ.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_CRUD_POO_LINQ.Controllers
{
    public static class imprimirController
    {
        //Metodo para imprimir las Areas
        #region IMPRIMIR AREAS
        public static void ImprimirAreas(List<Areas> Area)
        {
            foreach (var item in Area)
            {
                //Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n*********** INFORMACIÓN DEL AREA **********\n");
                Console.WriteLine(" ID: {0} \n Nombre: {1} ", item.ID,
                    item.Nombre);
                Console.WriteLine("----------------------------------------------------------------------------");
            }
        }
        #endregion


        //Metodo para imprimir los Empleados
        #region IMPRIMIR EMPLEADOS
        public static void ImprimirEmpleados(List<Empleados> Empleado)
        {
            foreach (var item in Empleado)
            {
                //Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\n*********** Sr(a) {item.Nombres} {item.Apellidos} Bienvenid@ ***********\n");
                Console.WriteLine(" ID: {0} \n Nombres: {1} \n Apellidos: {2} " +
                 "\n Direccion: {3} \n Telefono: {4} \n Fecha Ingreso: {5} \n ID Area: {6}", item.ID,
                    item.Nombres, item.Apellidos, item.Direccion, item.Telefono, item.Fecha_Ingreso,
                    item.IDArea);
                Console.WriteLine("---------------------------------------------------------------------------");
            }
        }
        #endregion


        //Metodo para Imprimir los Registros de Nomina
        #region IMPRIMIR NOMINA
        public static void ImprimirNomina(List<Nomina> Nomina)
        {
            foreach (var item in Nomina)
            {
                //Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\n*********** Emplead@ con ID # {item.IDEmpleado} esta es su nomina, Feliz Dia!! ***********\n");
                Console.WriteLine(" ID: {0} \n Fecha: {1} \n IDEmpleado: {2} \n Sueldo: {3} " +
                    "\n Dias Laborados: {4} \n Total Basico: {5} \n Total Devengado: {6}", item.ID,
                    item.Fecha, item.IDEmpleado, item.Sueldo, item.Dias, item.Total_Basico, item.Total_Devengado);
                Console.WriteLine("----------------------------------------------------------------------------");
            }
        }
        #endregion

    }
}
