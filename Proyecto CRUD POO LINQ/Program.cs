using Proyecto_CRUD_POO_LINQ.Controllers;
using System;

namespace Proyecto_CRUD_POO_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            #region INSTANCIAS
            areasController areaController = new areasController();
            empleadosController empController = new empleadosController();
            nominaController nomController = new nominaController();
            #endregion


            #region MENÚ 
            int ID = 0;
            int opc = 0;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" MENÚ DE OPCIONES \n");
                Console.WriteLine(" 1. Modulo Areas \n 2. Modulo Empleados \n 3. Modulo Nomina \n 4. Salir");
                Console.WriteLine("\nELIJA UNA OPCIÓN POR FAVOR!!");
                opc = Convert.ToInt32(Console.ReadLine());
                switch (opc)
                {
                   #region CASO 1 (GESTOR DE AREAS)
                    case 1:
                        string nombre = string.Empty;
                        int opc1 = 0;
                        do
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(" BIEVENID@ AL ADMINISTRADOR DE AREAS \n");
                            Console.WriteLine(" 1. Listar Areas \n 2. Listar Area Por ID \n 3. Crear Area \n 4. Actualizar Area" +
                                "\n 5. Eliminar Area \n 6. Salir");
                            Console.WriteLine("\nELIJA UNA OPCIÓN POR FAVOR!!");
                            opc1 = Convert.ToInt32(Console.ReadLine());
                            switch (opc1)
                            {
                                case 1:
                                    areaController.LlenarLista();
                                    areaController.getList();
                                    Console.ReadKey();
                                    break;

                                case 2:
                                    Console.WriteLine("Buscar Area por ID: ");
                                    Console.Write("Digite el ID del Area: ");
                                    ID = Convert.ToInt32(Console.ReadLine());
                                    Console.Clear();
                                    areaController.getByID(ID);
                                    Console.ReadKey();
                                    break;

                                case 3:
                                    Console.WriteLine("Presione una tecla para continuar...");
                                    Console.ReadKey(true);
                                    Console.Clear();
                                    Console.WriteLine("Insertar Area: ");
                                    Console.Write("Digite el ID del Area: ");
                                    ID = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Digite el Nombre del Area: ");
                                    nombre = (Console.ReadLine());
                                    areaController.postArea(ID, nombre);
                                    areaController.getList();
                                    Console.ReadKey();
                                    break;

                                case 4:
                                    Console.WriteLine("Presione una tecla para continuar");
                                    Console.Clear();
                                    Console.WriteLine("Modificar Area: ");
                                    Console.Write("Digite el ID del Area: ");
                                    ID = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Digite el Nombre del Area: ");
                                    nombre = (Console.ReadLine());
                                    areaController.updateArea(ID, nombre);
                                    areaController.getList();
                                    Console.ReadKey();
                                    break;

                                case 5:
                                    Console.WriteLine("Eliminar Area: ");
                                    Console.Write("Digite el ID del area: ");
                                    ID = Convert.ToInt32(Console.ReadLine());
                                    areaController.deleteByID(ID);
                                    areaController.getList();
                                    Console.ReadKey();
                                    break;

                                case 6:
                                    string confirmacion1 = "F";
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("¿Seguro que quieres salir?");
                                    confirmacion1 = Convert.ToString(Console.ReadLine());
                                    if (confirmacion1 == "S")
                                    {
                                        opc = 1;
                                    }
                                    else
                                    {
                                        opc1 = 1;
                                    }
                                    break;

                                default:
                                    Console.WriteLine("Opcion incorrecta!!");
                                    break;
                            }
                        } while (opc1 != 6);
                        break;
                    #endregion


                   #region CASO 2 (GESTOR EMPLEADOS)  
                    case 2:
                        string nombres = string.Empty;
                        string apellidos = string.Empty;
                        string direccion = string.Empty;
                        string telefono = string.Empty;
                        DateTime fechaingreso = new DateTime(2000, 01, 01);
                        int idarea = 0;

                        int opc2 = 0;
                        do
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(" BIEVENID@ AL ADMINISTRADOR DE EMPLEADOS \n");
                            Console.WriteLine(" 1. Listar Empleados \n 2. Listar Empleado Por ID \n 3. Crear Empleado \n 4. Actualizar Empleado" +
                                "\n 5. Eliminar Empleado \n 6. Salir");
                            Console.WriteLine("\nELIJA UNA OPCIÓN POR FAVOR!!");
                            opc2 = Convert.ToInt32(Console.ReadLine());
                            switch (opc2)
                            {
                                case 1:
                                    empController.LlenarLista();
                                    empController.getList();
                                    Console.ReadKey();
                                    break;

                                case 2:
                                    Console.WriteLine("Buscar Empleado por ID: ");
                                    Console.Write("Digite el ID del Empleado: ");
                                    ID = Convert.ToInt32(Console.ReadLine());
                                    Console.Clear();
                                    empController.getByID(ID);
                                    Console.ReadKey();
                                    break;

                                case 3:
                                    Console.WriteLine("Presione una tecla para continuar...");
                                    Console.ReadKey(true);
                                    Console.Clear();
                                    Console.WriteLine("Insertar Empleado: ");
                                    Console.Write("Digite el ID del Empleado: ");
                                    ID = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Digite los Nombres del Empleado: ");
                                    nombres = (Console.ReadLine());
                                    Console.Write("Digite los Apellidos del Empleado: ");
                                    apellidos = (Console.ReadLine());
                                    Console.Write("Digite la Direccion del Empleado: ");
                                    direccion = (Console.ReadLine());
                                    Console.Write("Digite el Telefono del Empleado: ");
                                    telefono = (Console.ReadLine());
                                    Console.Write("Digite la Fecha de Ingreso del Empleado: ");
                                    fechaingreso = DateTime.Parse(Console.ReadLine());
                                    Console.Write("Digite el Codigo Area del Empleado: ");
                                    idarea = Convert.ToInt32(Console.ReadLine());
                                    empController.postEmployee(ID, nombres, apellidos, direccion, telefono, fechaingreso, idarea);
                                    empController.getList();
                                    Console.ReadKey();
                                    break;

                                case 4:
                                    Console.WriteLine("Presione una tecla para continuar");
                                    Console.Clear();
                                    Console.WriteLine("Modificar Empleado: ");
                                    Console.Write("Digite el ID del Empleado: ");
                                    ID = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Digite los Nombres del Empleado: ");
                                    nombres = (Console.ReadLine());
                                    Console.Write("Digite los Apellidos del Empleado: ");
                                    apellidos = (Console.ReadLine());
                                    Console.Write("Digite la Direccion del Empleado: ");
                                    direccion = (Console.ReadLine());
                                    Console.Write("Digite el Telefono del Empleado: ");
                                    telefono = (Console.ReadLine());
                                    Console.Write("Digite la Fecha de Ingreso del Empleado: ");
                                    fechaingreso = DateTime.Parse(Console.ReadLine());
                                    Console.Write("Digite el Codigo Area del Empleado: ");
                                    idarea = Convert.ToInt32(Console.ReadLine());
                                    empController.updateEmployee(ID, nombres, apellidos, direccion, telefono, fechaingreso, idarea);
                                    empController.getList();
                                    Console.ReadKey();
                                    break;

                                case 5:
                                    Console.WriteLine("Eliminar empleado: ");
                                    Console.Write("Digite el ID del Empleado: ");
                                    ID = Convert.ToInt32(Console.ReadLine());
                                    empController.deleteByID(ID);
                                    empController.getList();
                                    Console.ReadKey();
                                    break;

                                case 6:
                                    string confirmacion2 = "F";
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("¿Seguro que quieres salir?");
                                    confirmacion2 = Convert.ToString(Console.ReadLine());
                                    if (confirmacion2 == "S")
                                    {
                                        opc = 1;
                                    }
                                    else
                                    {
                                        opc2 = 1;
                                    }
                                    break;

                                default:
                                    Console.WriteLine("Opcion incorrecta!!");
                                    break;
                            }
                        } while (opc2 != 6);
                        break;
                    #endregion


                   #region CASO 3 (GESTOR DE NOMINA)
                    case 3:
                        DateTime fecha = new DateTime(2000, 01, 01);
                        int IDEmpleado = 0;
                        decimal sueldo = 0.0m;
                        int dias_laborados = 0;

                        int opc3 = 0;
                        do
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(" BIEVENID@ AL ADMINISTRADOR DE NOMINA \n");
                            Console.WriteLine(" 1. Listar Registros \n 2. Listar Registro Por ID \n 3. Crear Registro \n 4. Actualizar Registro" +
                                "\n 5. Eliminar Registro \n 6. Salir");
                            Console.WriteLine("\nELIJA UNA OPCIÓN POR FAVOR!!");
                            opc3 = Convert.ToInt32(Console.ReadLine());
                            switch (opc3)
                            {
                                case 1:
                                    nomController.LlenarLista();
                                    nomController.getList();
                                    Console.ReadKey();
                                    break;

                                case 2:
                                    Console.WriteLine("Buscar registro de Nomina por ID: ");
                                    //Console.ReadKey();
                                    Console.Write("Digite el ID del Registro a consultar: ");
                                    ID = Convert.ToInt32(Console.ReadLine());
                                    Console.Clear();
                                    nomController.getByID(ID);
                                    Console.ReadKey();
                                    break;

                                case 3:
                                    Console.WriteLine("Presione una tecla para continuar...");
                                    Console.ReadKey(true);
                                    Console.Clear();
                                    Console.WriteLine("Insertar registro de Nomina: ");
                                    Console.Write("Digite el ID del Registro: ");
                                    ID = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Digite la Fecha del Pago : ");
                                    fecha = DateTime.Parse(Console.ReadLine());
                                    Console.Write("Digite el ID del Empleado: ");
                                    IDEmpleado = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Digite el sueldo del Empleado: ");
                                    sueldo = Convert.ToDecimal(Console.ReadLine());
                                    Console.Write("Digite los dias que trabajo el Empleado: ");
                                    dias_laborados = Convert.ToInt32(Console.ReadLine());

                                    nomController.postPayroll(ID, fecha, IDEmpleado, sueldo, dias_laborados);
                                    nomController.getList();
                                    Console.ReadKey();
                                    break;

                                case 4:
                                    Console.WriteLine("Presione una tecla para continuar");
                                    Console.Clear();
                                    Console.WriteLine("Modificar registro de Nomina: ");
                                    Console.Write("Digite ID del Registro: ");
                                    ID = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Digite la Fecha del Pago : ");
                                    fecha = DateTime.Parse(Console.ReadLine());
                                    Console.Write("Digite el ID del Empleado: ");
                                    IDEmpleado = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Digite el sueldo del Empleado: ");
                                    sueldo = Convert.ToDecimal(Console.ReadLine());
                                    Console.Write("Digite los dias que trabajo el Empleado: ");
                                    dias_laborados = Convert.ToInt32(Console.ReadLine());

                                    nomController.updatePayroll(ID, fecha, IDEmpleado, sueldo, dias_laborados);
                                    nomController.getList();
                                    Console.ReadKey();
                                    break;

                                case 5:
                                    Console.WriteLine("Eliminar registro de nomina: ");
                                    Console.Write("Digite ID del registro: ");
                                    ID = Convert.ToInt32(Console.ReadLine());
                                    nomController.deleteByID(ID);
                                    nomController.getList();
                                    Console.ReadKey();
                                    break;

                                case 6:
                                    string confirmacion3 = "F";
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("¿Seguro que quieres salir?");
                                    confirmacion3 = Convert.ToString(Console.ReadLine());
                                    if (confirmacion3 == "S")
                                    {
                                        opc = 1;
                                    }
                                    else
                                    {
                                        opc3 = 1;
                                    }
                                    break;

                                default:
                                    Console.WriteLine("Opcion incorrecta!!");
                                    break;
                            }
                        } while (opc3 != 6);
                        break;
                    #endregion


                   #region SALIDA DEL MENÚ
                    case 4:
                        char confirmacion = 'F';
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("¿Seguro que quieres salir?");
                        confirmacion = Convert.ToChar(Console.ReadLine());
                        if (confirmacion == 'S')
                        {
                            opc = 4;
                        }
                        else
                        {
                            opc = 1;
                        }
                        break;
                    #endregion


                   #region MENSAJE POR DEFAULT
                    default:
                        Console.WriteLine("Opcion incorrecta!!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                   #endregion
                }
            } while (opc != 4);
            #endregion
        }
    }
}
