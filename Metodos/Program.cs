using System;

namespace Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(sumaNumeros());
            Console.WriteLine(sumaNumeros(2, 5));
        }

        public static int sumaNumeros()
        {
            int num1 = 7;
            int num2 = 9;
            int resultado = num1 + num2;
            return resultado;
        }

        public static int sumaNumeros(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
