using System;
using System.Diagnostics;

namespace programa12_Torres_de_Hanoi
{
    class Program
    {
      
        public class Recursividad
        {
           
            public int movimiento;
            public void Hanoi(int n,string origen,string auxiliar,string destino)
            {
                if (n==1)
                {
                    Console.WriteLine("Mover un disco de " +origen+ " a "+destino);

                    movimiento++;
                }
                else
                {
                    Hanoi(n-1,origen,destino,auxiliar);
                    Console.WriteLine("Mover un disco de " +origen+ " a " +destino);
                    movimiento++;
                    Hanoi(n - 1, auxiliar, origen, destino);

                }

              
                
            }
            ~Recursividad()
            {
                Console.WriteLine("Memoria de objeto recursividad liberada");
            }

        }
        
        static void Main(string[] args)
        {
            string destino="destino";
            string auxiliar="auxiliar";
            string origen="origen";
            int n;
            Recursividad r = new Recursividad();
            int opc;
            Stopwatch s = new Stopwatch();
            do
            {
                Console.Clear();
                Console.WriteLine("***TORRES DE HANOI***");
                Console.WriteLine("1.Calcular movimientos");
            Console.WriteLine("2.Salir del programa");

            Console.Write("Ingrese la opcion deseada : ");
            opc = int.Parse(Console.ReadLine());

            
               
                switch (opc)
                {
                    case 1:
                        
                        Console.Write("Cuantos discos desea calcular ? :");
                        n = int.Parse(Console.ReadLine());
                        s.Start();
                        r.Hanoi(n,origen,auxiliar,destino);
                        Console.WriteLine("Numero de movimientos : " + r.movimiento);
                        r.movimiento = 0;

                        Console.ReadKey();
                        break;
                    case 2:
                        s.Stop();
                        Console.WriteLine($"\nTiempo: {s.Elapsed.TotalMilliseconds} ms");

                        Console.WriteLine("\nMemoria Utilizada : " + GC.GetTotalMemory(true) + " " + "bytes");
                        Console.WriteLine("cerrando programa...");
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }


            } while (opc!=2);




        }
    }
}
