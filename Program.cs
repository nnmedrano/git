using System;

namespace proyecto1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "Nicole";
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hola Mundo!");
            Console.WriteLine(nombre);
            Console.WriteLine("hola "+ nombre);
            Console.WriteLine("cantidad de parametros: "+ args.Length);
            int n = args.Length;
           /*switch (n)
            {
                caso 0:
                    Console.WriteLine("no tiene parametros");
                    break;
                case 1:
                    Console.WriteLine("tiene un parametro");
                    break;
                default:
                    Console.WriteLine("tiene "+ n + " parametros");
                    break;
            }*/
        }
    }
}
