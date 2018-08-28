using System;

namespace PrimeraAplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            do
            {
                // Escribe cw y tabula para un atajo
                Console.WriteLine("******\nBienvenidos al curso de C#\n");

                Console.WriteLine("1.Vaiable");
                Console.WriteLine("2.Sintaxis Básica");
                Console.WriteLine("3.Casting");
                Console.WriteLine("4.Constante");

                Console.WriteLine();
                Console.Write("Elige un número: ");
                num = int.Parse(Console.ReadLine());

                switch (num)
                {
                    case 1:
                        new Variable();
                        break;
                    case 2:
                        new SintaxisBasica();
                        break;
                    case 3:
                        new Casting();
                        break;
                    case 4:
                        new Constante();
                        break;
                }
            } while (num > 0);
        }
    }
}
