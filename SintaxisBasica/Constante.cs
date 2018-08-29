using System;

namespace PrimeraAplicacion
{
    class Constante
    {
        public Constante()
        {
            const double PI=3.1416;

            Console.Write("Introduce la medida del radio: ");
            double radio = double.Parse(Console.ReadLine());
            double area = radio * radio * PI;
            double areaL = Math.Pow(radio, 2) * Math.PI;
            Console.WriteLine("El área del circulo es: {0}, {1}", area, areaL);
        }
    }
}
