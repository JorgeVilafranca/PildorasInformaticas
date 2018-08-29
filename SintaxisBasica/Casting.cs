using System;

namespace PrimeraAplicacion
{
    class Casting
    {
        public Casting()
        {
            double temperatura = 34.5;
            int tempZaragoza;
            // Conversion explicita
            // Casting
            tempZaragoza = (int)temperatura;
            Console.WriteLine("Temperatura: " + tempZaragoza);
            // Conversion implicita
            int habitantes = 10000000;
            long habitantes2018 = habitantes;
            float pesoMaterial = 5.78F;
            double pesoMaterialPrec = pesoMaterial;
            Console.WriteLine("Habitantes: " + habitantes2018);
            Console.WriteLine("Peso: " + pesoMaterialPrec);
        }
    }
}
