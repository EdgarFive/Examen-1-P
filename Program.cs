//Inicio del programa =====================================================================

using System.Net.Http.Headers;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
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
                //EJERCICIO 2 ===========================================================
                try
                {
                    Console.Clear();
                    Console.WriteLine("Debe ingresar dos numeros enteros para poder ejecutar la operación.\nIngrese el pimer número:");
                    int enum1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo número:");
                    int enum2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("ingrese el operador matematico con el que desea trabajar:\"+ , - , * ,/\"");
                    string eopera = Console.ReadLine();
                    double eresul = 0;
                    if (eopera == "+")
                    {
                        eresul = enum1 + enum2;
                    } else if (eopera == "-")
                    {
                        eresul = enum1 - enum2;
                    } else if (eopera == "*")
                    {
                        eresul = enum1 * enum2;
                    } else if (eopera == "/")
                    {
                        eresul = enum1 / enum2;
                    } else
                    {
                        Console.WriteLine("El caracter ingresado no es valido, lo siento.");
                        Console.ReadKey();
                    }                            
                    Console.WriteLine("El resultado de la operación es: " + eresul);
                    Console.ReadKey();
                }
                catch (Exception error)
                {
                    Console.WriteLine("Ah ocurrido un error en el ingreso de datos: " + error);
                    Console.ReadKey();
                }
                break;
            case 3:
                try
                {
                    Console.Clear();
                    Console.WriteLine("Ingrese un número para saber su tabla de multiplicar:");
                    int eemulti = int.Parse(Console.ReadLine());
                    int eemultiresul = 0;
                    for (int jj = 1; jj <= 10; jj++)
                    {
                        eemultiresul = eemulti * jj;
                        Console.WriteLine(eemulti + " * " + jj + " = " + eemultiresul);
                    }
                    Console.ReadKey();
                }
                catch (Exception error)
                {
                    Console.WriteLine("Ah ocurrido un error en el ingreso de datos: " + error);
                    Console.ReadKey();
                }        
                break;
            case 4:
                try
                {
                    Console.Clear();
                    Random eram = new Random();
                    int eramd = eram.Next(1,100);
                    int eenumro = 0;
                    for (int jj = 0; jj != -1;)
                    {
                        try
                        {
                            Console.Clear() ;
                            Console.WriteLine("Ingrese un número entero entre el 1 y el 100:");
                            eenumro = int.Parse(Console.ReadLine());
                            if (eenumro > 100 || eenumro < 1)
                            {
                                Console.WriteLine("El número ingresado no es valido, vuelva a intentarlo.");
                                Console.ReadKey();
                               
                            }else if (eenumro < eramd)
                            {
                                Console.WriteLine("El número secreto es mayor, vuelva a intentarlo.");
                                Console.ReadKey();
                            }else if (eenumro == eramd)
                            {
                                Console.WriteLine("¡LO HAS CONSEGUIDO!, el número ingresado es el correcto:" + eramd);
                                jj = -1;
                                Console.ReadKey();
                            }
                            else if (eenumro > eramd)
                            {
                                Console.WriteLine("El número secreto es menor, vuelva a intentarlo.");
                                Console.ReadKey();
                            }
                        }
                        catch (Exception error)
                        {
                            Console.WriteLine("Ah ocurrido un error en el ingreso de datos: " + error);
                            Console.ReadKey();
                        }
                    }
                }
                catch (Exception error)
                {
                    Console.WriteLine("Ah ocurrido un error en el ingreso de datos: " + error);
                    Console.ReadKey();
                }
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
