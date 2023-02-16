using System;
using System.Diagnostics;

namespace programa15_Multiplicacion_vector
{
    class Program
    {
        class Recursividad
        {
            public int[] vector;
            public void GenerarArreglo(int n)
            {
                vector = new int[n];
                Random aleatorio = new Random();
                

                for (int i = 0; i < n; i++)
                {
                    vector[i] = aleatorio.Next(1, 10);
                }
            }

            public void MostrarArreglo(int n)
            {
                Console.WriteLine("Este es su arreglo : ");

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(vector[i]);
                }
            }

            public int Multiplicacion(int n)
            {
                
                if (n==1)
                {
                    return vector[0];
                }

                else
                {
                    return vector[n-1] * Multiplicacion(n-1);
                    
                }
            }
            ~Recursividad()
            {
                Console.WriteLine("\nMemoria de objeto recursividad liberada");
            }
        }
        static void Main(string[] args)
        {
            char opc;
            int n=0;
            
            Recursividad r = new Recursividad();
            Stopwatch s = new Stopwatch();
            do
            {
                Console.Clear();
                Console.WriteLine("a) Generar Vector aleatoriamente");
                Console.WriteLine("b) Multiplicar vector");
                Console.WriteLine("c) Desplegar vector y multiplicacion");
                Console.WriteLine("d) Salir del programa");

                Console.Write("\nIngrese la opcion deseada : ");
                opc = char.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 'a':
                        s.Start();
                        Console.Write("Ingrese cuantos numeros tendra el vector : ");
                        n = int.Parse(Console.ReadLine());
                        r.GenerarArreglo(n);
                        Console.WriteLine("Vector generado !");
                        Console.ReadKey();
                        break;
                    case 'b':
                        r.Multiplicacion(n);
                        
                        Console.WriteLine("Vector multiplicado !");
                        Console.ReadKey();
                        break;
                    case 'c':
                        
                        r.MostrarArreglo(n);
                        Console.WriteLine("\nLa multiplicacion de los elementos del vector es : " + r.Multiplicacion(n));
                        Console.ReadKey();
                        break;
                    case 'd':
                        s.Stop();
                        Console.WriteLine("Cerrando programa...");
                        Console.WriteLine($"\nTiempo: {s.Elapsed.TotalMilliseconds} ms");
                        Console.WriteLine("\nMemoria Utilizada : " + GC.GetTotalMemory(true) + " " + "bytes");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("\nIngrese una opcion valida");
                        Console.ReadKey();
                        break;

                }

            } while (opc!='d');
        }
    }
}
