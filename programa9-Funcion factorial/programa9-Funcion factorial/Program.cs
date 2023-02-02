using System;
using System.Diagnostics;

namespace programa9_Funcion_factorial
{
    class Program
    {
        class Recursividad
        {
            public int Factorial(int numero)
            {
                if (numero == 0)
                    return 1;
                return numero * Factorial(numero - 1);


            }
            ~Recursividad()
            {
                Console.WriteLine("Memoria de objeto recursividad liberada");
            }

        }
        static void Main(string[] args)
        {
            int opc;
            Stopwatch s = new Stopwatch();
            Recursividad r = new Recursividad();

            do 
            {
                Console.Clear();
                Console.WriteLine("***RECURSION FACTORIAL***");
                Console.WriteLine("1.Calcular funcion");
                Console.WriteLine("2.Salir del programa");
                Console.Write("\nIngrese la opcion deseada : ");
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        s.Start();
                        Console.Write("\nQue numero desea calcular ? : ");
                        int num = int.Parse(Console.ReadLine());
                        Console.WriteLine("\nSu factorial es : {0}", r.Factorial(num));
                        Console.ReadKey();
                        break;
                    case 2:
                        s.Stop();
                        Console.WriteLine("\nCerrando programa...");
                        Console.WriteLine($"\nTiempo: {s.Elapsed.TotalMilliseconds} ms");
                        Console.WriteLine("\nMemoria Utilizada : " + GC.GetTotalMemory(true) + " " + "bytes");
                        break;
                    default:
                        Console.WriteLine("Ingrese una opcion valida");
                        Console.ReadKey();
                        break;

                }



            } while (opc!=2);
        }
    }
}
