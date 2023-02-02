using System;
using System.Diagnostics;
namespace programa14_Capital_Total
{
    class Program
    {

        class Recursividad
        {
            public float C(float m, float x, float n)
            {
                if (n == 0)
                {
                    return m;
                }
                else
                {
                    return C(m, x, n - 1) + C(m, x, n - 1) * (x / 100);
                }
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
                Console.WriteLine("1.Calcular");
                Console.WriteLine("2.Salir del programa");
                Console.Write("\nIngrese la opcion deseada : ");
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        s.Start();
                        Console.Write("Ingrese monto de la inversion : ");
                        float m= int.Parse(Console.ReadLine());
                        Console.Write("Ingrese interes anual: ");
                        float x = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese cantidad de años de inversion: ");
                        float n = int.Parse(Console.ReadLine());
                        Console.WriteLine("\nEl resultado de la inversion es : {0:C}" ,r.C(m,x,n));
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

            } while (opc != 2);
        }
    }
}
