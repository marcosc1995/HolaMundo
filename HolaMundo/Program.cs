using System;


namespace HolaMundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hola mundo");
            int resultado = Suma(20, 35);
            Console.WriteLine(resultado);
            int number = 69;
            string test = "texto de prueba";
            Console.WriteLine("esto es una prueba {0} {1}", number, test);
            Console.Read();
        }
        public static int Suma(int num1, int num2)
        {
                       
            return num1 + num2;
        }
        
    }
}
