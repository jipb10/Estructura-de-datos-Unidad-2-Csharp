using System;
using System.Diagnostics;

namespace programa13_Multiplicacion_de_2_numeros
{
    class Program
    {
        class Recursividad
        {
            public int Axb(int a,int b)
            {
                if (b == 1)
                {

                    return a;
                }
                else
                {
                    return a + Axb(a, b - 1);


                }
                
            }

            ~Recursividad()
            {
                Console.WriteLine("Memoria de objeto recursividad liberada");
            }
        }
        static void Main(string[] args)
        {
            Recursividad r = new Recursividad();
            int opc;
            Stopwatch s = new Stopwatch();
            do
            {
                Console.Clear();
                Console.WriteLine("***MULTIPLICACION DE 2 NUMEROS***");
                Console.WriteLine("1.Calcular");
                Console.WriteLine("2.Salir del programa");
                Console.Write("\nIngrese la opcion deseada : ");
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        s.Start();
                        Console.Write("Ingrese numero 1 : ");
                        int num1 = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese numero 2 : ");
                        int num2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("\nEl resultado es : " + r.Axb(num1,num2));
                        Console.ReadKey();
                        break;

                    case 2:
                        s.Stop();

                        Console.WriteLine("\nCerrando programa...");
                        Console.WriteLine($"\nTiempo: {s.Elapsed.TotalMilliseconds} ms");
                        Console.WriteLine("\nMemoria Utilizada : " + GC.GetTotalMemory(true) + " " + "bytes");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("\nIngrese una opcion correcta");
                        Console.ReadKey();

                        break;
                }

            } while (opc!=2);
        }
    }
}
