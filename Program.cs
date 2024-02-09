//Programa de salarios

//Declara las variables

using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;


//int paso = 0; //Variable para poder verificar si el usuario introdujo los datos de forma correcta.
int paso_general = 0;

string opcion = " "; //Variable para elegir una de las opciones del menú

//Crea los arreglos para almacenar los datos de los empleados
// [NOMBRES]
string[] nombre_OP = new string[255];
string[] nombre_TEC = new string[255];
string[] nombre_PRO = new string[255];

//  [NÚMERO DE CÉDULA]
string[] Ced_OP = new string[255];
string[] Ced_TEC = new string[255];
string[] Ced_PRO = new string[255];

// [SALARIOS]
float[] Sal_OP = new float[255];
float[] Sal_TEC = new float[255];
float[] Sal_PRO = new float[255];

//Escribe en pantalla el título del menú
/*
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("+------------------------[Aumentos de Salarios]---------------------------+");
Console.WriteLine("|                                                                         |       ,-.       _,---._ __  / \\");
Console.WriteLine("|                                                                         |       /  )    .-'       `./ /   \\");
Console.WriteLine("|      [Tipos de empleados]                                               |      (  (   ,'            `/    /|");
Console.WriteLine("|                                                                         |       \\  `-\"             \\'\\   / |");
Console.WriteLine("|      (1) - Operario                                                     |        `.              ,  \\ \\ /  |");
Console.WriteLine("|      (2) - Técnico                                                      |         /`.          ,'-`----Y   |");
Console.WriteLine("|      (3) - Profesional                                                  |        (            ;        |   '");
Console.WriteLine("|                                                                         |        |  ,-.    ,-'         |  /");
Console.WriteLine("+-------------------------------------------------------------------------+        |  | (   |            | /");
Console.WriteLine("                                                                                   )  |  \\  `.___________|/");
Console.WriteLine("                                                                                   `--'   `--'");
*/

//Muestra el meno principal
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("+--------------------------------[PROGRAMA DE MANEJO DE SALARIOS]--------------------------------+                 .__....._             _.....__,");
Console.WriteLine("|                                                                                                |                   .\": o :':         ;': o :\".");
Console.WriteLine("|                 (OPCIONES)                                                                     |                   `. `-' .'.       .'. `-' .'");
Console.WriteLine("|                                                                                                |                     `---'             `---'");
Console.WriteLine("|                 (1) - Agregar Empleado(a)                                                      |");
Console.WriteLine("|                                                                                                |           _...----...      ...   ...      ...----..._");
Console.WriteLine("|                 (2) - Mostrar Datos                                                            |        .-'__..-\"\"'----    `.  `\"`  .'    ----'\"\"-..__`-.");
Console.WriteLine("|                                                                                                |       '.-'   _.--\"\"\"'       `-._.-'       '\"\"\"--._   `-.`");
Console.WriteLine("|                 (3) - Salir del Programa                                                       |       '  .-\"'                  :                  `\"-.  `");
Console.WriteLine("|                                                                                                |         '   `.              _.'\"'._              .'   `");
Console.WriteLine("|                                                                                                |               `.       ,.-'\"       \"'-.,       .'");
Console.WriteLine("+------------------------------------------------------------------------------------------------+                 `.                           .'");
Console.WriteLine("                                                                                                                     `-._                   _.-'");
Console.WriteLine(" ");

//Le solicita los datos al usuario
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Ingrese uno de los números correspondiente a alguna de las 3 opciones que se le presentan en pantalla:");

while (paso_general == 0)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    opcion = Console.ReadLine();
    bool opcion_NUM = Regex.IsMatch(opcion, @"^\d+$");

    if (opcion_NUM == true)
    {
        if (opcion == "1" || opcion == "2")
        {
            paso_general = 1;
        }
        else if (opcion == "3")
        {
            paso_general = 1;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("!!!Valor fuera de los parámetros!!!");
            paso_general = 0;

        }
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("!!!Valor inválido!!!");
        paso_general = 0;
    }
}

//  Verifica las opción del menú que seleccionó el usuario
switch (opcion)
{
    case "1":
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("+-----------------------[AGREGAR EMPLEADO(a)]------------------------------------------+");
        Console.WriteLine("|                                                                                      |");
        Console.WriteLine("|         ,_     _                                                                     |");
        Console.WriteLine("|         |\\_,-~/                            [Tipos de empleados]                     |");
        Console.WriteLine("|         / _  _ |    ,--.                                                             |");
        Console.WriteLine("|        (  @  @ )   / ,-'                    (1) - Operario                           |");
        Console.WriteLine("|         \\  _T_/-._( (                                                               |");
        Console.WriteLine("|         /         `. \\                     (2) - Técnico                            |");
        Console.WriteLine("|        |         _  \\ |                                                             |");
        Console.WriteLine("|         \\ \\ ,  /      |                   (3) - Profesional                        |");
        Console.WriteLine("|          || |-_\\__   /                                                              |");
        Console.WriteLine("|         ((_/`(____,-'                                                                |");
        Console.WriteLine("+--------------------------------------------------------------------------------------+");

        //Declara las variables
        int OP_1 = 0;
        string EmployType = ""; // 1 = Operario 2 = Tecnico 3 = Profesional
        string nombre = "";
        string numcedula = "";
        float n = 0; //Variable de los aumentos
        string askyou; //Variable para preguntarle al usuario si desea ingresar más datos

        //Le solicita el tipo de empleado al usuario
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Ingrese el número correspondiente al tipo de empleado que desea seleccionar: ");
        while (OP_1 == 0)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            EmployType = Console.ReadLine();
            bool Employ_NUM = Regex.IsMatch(EmployType, @"^\d+$");
            if (Employ_NUM == true)
            {
                if (EmployType == "1" || EmployType == "2")
                {
                    OP_1 = 1;
                }
                else if (EmployType == "3")
                {
                    OP_1 = 1;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("!!!Valor fuera de los parámetros!!!");
                    OP_1 = 0;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("!!!Valor no válido!!!");
                OP_1 = 0;
            }
        }
        /*
        //Calcula el aumento del salario
        switch (EmployType)
        {
            case "1":
                n = 0.15f;
                break;
            case "2":
                n = 0.10f;
                break;
            case "3":
                n = 0.05f;
                break;
        }
        */

        //Solicita el nombre del empleado
        Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine("Inserte aquí el nombre del empleado(a): ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        nombre = Console.ReadLine();

        //Solicita la cédula del empleado
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Ingrese el número de cédula del empleado");
        while (OP_1 == 1)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            numcedula = Console.ReadLine();
            bool ced_num = Regex.IsMatch(numcedula, @"^\d+$");
            if (ced_num == true)
            {
                if (numcedula.Length > 0 && numcedula.Length < 10)
                {
                    OP_1 = 2;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("!!!Valor fuera de los parámetros!!!");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("!!!Valor no válido!!!");
            }
        }

        //Almacena los datos ingresados en los arreglos correspondientes y agrega los aumentos salariales
        switch (EmployType)
        {
            case "1":
                n = 0.15f;
                
                for ( int i = 0; i < nombre_OP.Length; i++)
                {
                    if (nombre_OP[i] != "0")
                    {
                        nombre_OP[i] = nombre;
                    }
                    else if (nombre_OP[i] == nombre)
                    {
                        i = nombre_OP.Length + 1;
                    }

                }

                for (int i = 0; i < Ced_OP.Length; i++)
                {
                    if (Ced_OP[i] != "0")
                    {
                        Ced_OP[i] = numcedula;
                    }
                    else if (Ced_OP[i] == numcedula)
                    {
                        i = Ced_OP.Length + 1;
                    }
                }
                    break;

            case "2":
                n = 0.10f;

                for (int i = 0; i < nombre_TEC.Length; i++)
                {
                    if (nombre_TEC[i] != "0")
                    {
                        nombre_TEC[i] = nombre;
                    }
                    else if (nombre_TEC[i] == nombre)
                    {
                        i = nombre_TEC.Length + 1;
                    }
                }

                for (int i = 0; i < Ced_TEC.Length; i++)
                {
                    if (Ced_TEC[i] != "0")
                    {
                        Ced_TEC[i] = numcedula;
                    }
                    else if (Ced_TEC[i] == numcedula)
                    {
                        i = Ced_TEC.Length + 1;
                    }
                }
                    break;

            case "3":
                n = 0.05f;

                for (int i = 0; i < nombre_TEC.Length; i++)
                {
                    if (nombre_PRO[i] != "0")
                    {
                        nombre_PRO[i] = nombre;
                    }
                    else
                    {
                        i = nombre_PRO.Length + 1;
                    }
                }

                for (int i = 0; i < Ced_PRO.Length; i++)
                {
                    if (Ced_TEC[i] != "0")
                    {
                        Ced_PRO[i] = numcedula;
                    }
                    else if (Ced_PRO[i] == numcedula)
                    {
                        i = Ced_PRO.Length + 1;
                    }
                }
                    break;
        }

        //Declara las variables del salario
        float salario_bruto = 0;
        float ordinary_salary = 354692;
        float deducciones = 0;
        float salario_neto = 0;

        //Calcula el salario bruto
        salario_bruto = (ordinary_salary + n);

        //Calcula las deducciones de ley
        deducciones = (0.9f / salario_bruto);

        //Calcula el salario neto
        salario_neto = (salario_bruto - deducciones);

        //Le pregunta al usuario si desea agregar un nuevo empleado
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("¿Desea agregar otro(a) empleado(a)?: S/N");
        while (OP_1 == 2)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            askyou = Console.ReadLine();
            bool askALF = Regex.IsMatch(askyou, @"^[a-zA-Z]+$");
            switch (askALF)
            {
                case true:
                    //string askyou2 = askyou.ToUpper();

                    if (askyou.ToUpper() == "S")
                    {
                        string reinicio = Process.GetCurrentProcess().MainModule.FileName;
                        Process.Start(reinicio);
                        Environment.Exit(0); //Termina la ejecución del programa
                    }
                    else if (askyou.ToUpper() == "N")
                    {
                        Console.Clear();
                        opcion = "2";
                        //Presenta los datos en pantalla
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.WriteLine("         [Datos del empleado]         ");
                        Console.WriteLine("Cédula: " + numcedula);
                        Console.WriteLine("Nombre del empleado: " + nombre);
                        Console.WriteLine("Tipo de empleado: " + EmployType);
                        Console.WriteLine("Salario Ordinario: " + ordinary_salary);
                        Console.WriteLine("Aumento: " + n);
                        Console.WriteLine("Salario Bruto: " + salario_bruto);
                        Console.WriteLine("Deducción CCSS: " + deducciones);
                        Console.WriteLine("Salario Neto: " + salario_neto);
                        
                        //
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("!!!Valor no válido!!!");
                    }

                    break;

                case false:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("!!!Valor no válido!!!");
                    break;
            }
        }

        break;

    case "2":
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("+---------------------[MOSTRAR DATOS]---------------------+");

        //Presenta los datos
        break;

    case "3":
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("SE HA SALIDO DEL PROGRAMA");
        Environment.Exit(0);
        break;
}

//Le solicita los datos al usuario
/*
do
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Introduzca el número correspondiente al tipo de empleado(a): "); Console.ForegroundColor = ConsoleColor.Yellow; EmployType = int.Parse(Console.ReadLine());
    if (EmployType > 0 && EmployType < 4)
    {
        switch (EmployType)
        {
            case 1:
                n = 0.15;
                Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("El aumento del salario es del 15%");
                operarios += 1;
                paso = 1;
                break;

            case 2:
                n = 0.10;
                Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("El aumento del salario es del 10%");
                tecnicos += 1;
                paso = 1;
                break;

            case 3:
                n = 0.05;
                Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("El aumento del salario es del 5%");
                profesionales += 1;
                paso = 1;
                break;
        }
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("No hay ningún tipo de empleado para ese número. Inténtelo de nuevo");
    }

} while (paso == 0);
*/

//Console.Clear();



//Console.Clear();
/*
//Solicita la cédula del empleado
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Ingrese el número de cédula del empleado(a)");

do
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    numcedula = Console.ReadLine();
    if (numcedula.Length > 0 && numcedula.Length < 10)
    {
        paso = 2;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Esa no es una cédula válida. Debe ser de 9 carácteres.");
        paso = 1;
    }

} while (paso == 1);

//Declara las variables del salario
double salario_bruto = 0;
double ordinary_salary = 354692;
double deducciones = 0;
double salario_neto = 0;

//Calcula el salario bruto
salario_bruto = (ordinary_salary + n);

//Calcula las deducciones de ley
deducciones = (0.9 / salario_bruto);

//Calcula el salario neto
salario_neto = (salario_bruto - deducciones);

//Presenta los datos en pantalla
Console.Clear();
Console.ForegroundColor = ConsoleColor.Green;

Console.WriteLine("         [Datos del empleado]         ");
Console.WriteLine("Cédula: " + numcedula);
Console.WriteLine("Nombre del empleado: " + nombre);
Console.WriteLine("Tipo de empleado: " + EmployType);
Console.WriteLine("Salario Ordinario: " + ordinary_salary);
Console.WriteLine("Aumento: " + n);
Console.WriteLine("Salario Bruto: " + salario_bruto);
Console.WriteLine("Deducción CCSS: " + deducciones);
Console.WriteLine("Salario Neto: " + salario_neto);
*/