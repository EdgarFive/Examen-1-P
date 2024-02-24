//Inicio del programa =====================================================================

using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

    for (int ii = 0; ii != -1;)
        {
    try
    {
        Console.Clear();
        Console.WriteLine("Bienbenido al trabajo del Primer parcial de PROGRAMACIÓN.\nIngrese el número del ejercicio que desea ingresar:\n1. Primer ejercicio.\n2. Segundo Ejercicio.\n3. Tercer Ejercicio.\n4. Cuarto Ejercicio.\n-1. Cerrar el programa.");
        int emenu1 = int.Parse(Console.ReadLine());
        switch (emenu1)
        {
            case 1:
                //EJERCICIO 1 ==========================================================================
                for (int jj = 0; jj != -1;)
                {
                    try
                    {
                        Console.Clear();
                        Console.WriteLine("Ingrese un numero entero positivo:");
                        int enum1 = int.Parse(Console.ReadLine());
                        if (enum1 > 0)
                        {
                            for (int kk = 0; kk != -1;)
                            {
                                try
                                {
                                    Console.Clear();
                                    Console.WriteLine("Ingrese el número de la acción que desea ejecutar:\n1. Calcular el factorial del número.\n2. Calcular la raíz cuadrada del número.\n3. Salir de ejercicio.");
                                    int emenu2 = int.Parse(Console.ReadLine());
                                    switch (emenu2)
                                    {
                                        case 1:
                                            Console.Clear();
                                            int eresulfac = enum1;
                                            for (int i = enum1 - 1; i > 0; i--)
                                            {
                                                eresulfac = eresulfac * i;
                                            }
                                            Console.WriteLine("El factorial del número ingresado es: " + eresulfac);
                                            Console.ReadKey();
                                            break;
                                        case 2:
                                            Console.Clear();
                                            double eraiz = Math.Sqrt(enum1);
                                            Console.WriteLine("La raíz cuadrada del número ingresado es: " + eraiz);
                                            Console.ReadKey();
                                            break;
                                        case 3:
                                            kk = -1;
                                            jj = -1;
                                            break;
                                        default:
                                            Console.WriteLine("El número ingresado no es valido. intentelo de nuevo.");
                                            Console.ReadKey();
                                            break;
                                    }
                                }
                                catch (Exception error)
                                {
                                    Console.WriteLine("Ah ocurrido un error en el ingreso de datos: " + error);
                                    Console.ReadKey();
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("El valor ingresado no es positivo, vuelva a intentarlo.");
                            Console.ReadKey();
                        }
                    } catch (Exception error)
                    {
                        Console.WriteLine("Ah ocurrido un error en el ingreso de datos: " + error);
                        Console.ReadKey();
                    }
                }
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            default:
                if (emenu1 == -1)
                {
                    ii = -1;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("El dígito ingresado no es valido, vuelva a ingresarlo.");
                    Console.ReadKey();
                }
                break;
        }
    }
    catch (Exception error)
    {
        Console.WriteLine("Ah ocurrido un error en el ingreso de datos: " + error);
        Console.ReadKey();
    }
} 

/*
try
{

} catch (Exception error)
{
    Console.WriteLine("Ah ocurrido un error en el ingreso de datos: " + error);
    Console.ReadKey();
}
*/
