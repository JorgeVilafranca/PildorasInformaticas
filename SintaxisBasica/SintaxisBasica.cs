using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeraAplicacion
{
    class SintaxisBasica
    {
        public SintaxisBasica()
        {
            int edad = 35;
            // Operaciones aritmeticas
            Console.WriteLine(5 * 3);
            //Console.WriteLine("Tienes una edad de " + edad + " años");
            Console.WriteLine($"Tienes una edad de {++edad} años");

            int edad1;
            int edad2;
            int edad3;
            int edad4;
            // Solo se puede asignar de este modo si se han definido las variables anteriormente
            edad1 = edad2 = edad3 = edad4 = 27;
            Console.WriteLine("edad2: " + edad2);
            Console.WriteLine("edad4: " + edad4);
        }
    }
}
