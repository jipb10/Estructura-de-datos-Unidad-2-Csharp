using System;
using System.Diagnostics;

namespace programa8_Ejemplo_recursividad
{
    class Program
    {
        class Recursividad
        {
            public void Arbol(int max, int numero = 0)
            {

                int n = numero;
                Console.Write(new string(' ', max - numero));
                for (int i = 0; i < n; i++)
                    Console.Write(n + " ");
                Console.WriteLine();

                if (numero == max) return;

                Arbol(max, n + 1);
            }
            ~Recursividad()
            {
                Console.WriteLine("Memoria de objeto recursividad liberada");
            }
        }
        static void Main(string[] args)
        {
            Recursividad r = new Recursividad();
            Stopwatch s = new Stopwatch();
            int opc;
            int num;
           do
           {
                Console.Clear();
            Console.WriteLine("***EJEMPLO RECURSIVIDAD***");
            Console.WriteLine("1.Calcular");
            Console.WriteLine("2.Salir del programa");
            Console.Write("\nIngrese una opcion : ");
            opc = int.Parse(Console.ReadLine());
           
                switch (opc)
                {
                    case 1:
                        s.Start();
                        Console.Write("\nCuantos numeros desea ver ? : ");
                        num = int.Parse(Console.ReadLine());
                        r.Arbol(num);
                        Console.ReadKey();
                        break;
                    case 2:
                        s.Stop();
                        Console.WriteLine("\nCERRANDO PROGRAMA...");
                        Console.WriteLine($"\nTiempo: {s.Elapsed.TotalMilliseconds} ms");
                        Console.WriteLine("\nMemoria Utilizada : " + GC.GetTotalMemory(true) + " " + "bytes");

                        break;
                    default:
                        Console.WriteLine("\nIngrese una opcion valida");
                        Console.ReadKey();
                        break;
                }

            } while (opc!=2);
            
        }
    }
}
