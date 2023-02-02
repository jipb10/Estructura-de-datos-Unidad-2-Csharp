using System;
using System.Diagnostics;

namespace programa10_secuencia_fibonacci
{
    class Program
    {

        

        class Fibonacci
        {
            public int Fibonacci1(int numero)
            {
                if (numero == 0) 
                    
                {
                    return 0;
                }
                else if (numero==1)
                {
                    return 1;
                }
                else
                {
                    return Fibonacci1(numero - 1) + Fibonacci1(numero - 2);
                }
                
               

                
            }

            ~Fibonacci()
            {
                Console.WriteLine("\nMemoria destruida clase fibonacci");
            }
        }
        static void Main(string[] args)
        {
            Fibonacci fib = new Fibonacci();
            Stopwatch s = new Stopwatch();
            int opc;
            do
            {
            Console.WriteLine("***SECUENCIA FIBONACCI***");
            Console.WriteLine("1.Calcular numero de la serie");
            Console.WriteLine("2.Salir del programa");
            Console.Write("Ingrese la opcion deseada : ");
            
                 opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:



                        Console.Write("Que numero desea calcular? : ");
                        int num = int.Parse(Console.ReadLine());
                        s.Start();

                        Console.WriteLine("Su numero de la secuencia de fibonacci es : {0}", fib.Fibonacci1(num));
                        Console.ReadKey();
                        Console.Clear();
                        break;



                    case 2:
                        s.Stop();

                        Console.WriteLine($"\nTiempo: {s.Elapsed.TotalMilliseconds} ms");

                        Console.WriteLine("\nMemoria Utilizada : " + GC.GetTotalMemory(true) + " " + "bytes");

                        Console.WriteLine("\nCerrando programa...");
                        Console.ReadKey();
                        break;
                }

            } while (opc!= 2);
        }
    }
}
