using System;

namespace proyecto1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "Nicole";
            int edad = 0;
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hola Mundo!");
            Console.WriteLine("Cual es tu nombre?");
            nombre = Console.ReadLine();
            

            while(!nombre.Equals("bailar"))
            {   
            Console.WriteLine("Cual es tu edad?");
            int.TryParse(Console.ReadLine(), out edad);
            }

            if(edad >= 21)
            {
                Console.WriteLine("Es mayor de edad");
            }
            else
            {
                Console.WriteLine("Es menor");
            }

            Console.WriteLine("Cual es tu nombre?");
            nombre = Console.ReadLine();

            for(int i=0;i<5;i++)
            {
                Console.WriteLine("chau");
            }

            int j=0;
            while(j<5)
            {
                Console.WriteLine("Chau a todos");
            }

            string color = "magenta";
            string[] colores = new string[]{ "azul", color, "blanco", "negro","amarillo", "magenta"};
            string[] coloresotro = new string[3];
            Console.WriteLine("el tercer color es el:" + colores[2]);
            colores[0] = "verde";

            for(int k=0; k < colores.Length ; k++)
            {
                Console.WriteLine("Color:" + colores[k]);
            }

            foreach (string item in colores)
            {
                Console.WriteLine("Color:" + item);
            }
            
        }
    }
}
