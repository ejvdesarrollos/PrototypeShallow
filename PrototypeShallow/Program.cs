using System;

namespace PrototypeShallow
{
    class Program
    {
        static void Main(string[] args)
        {
            ParaClonar oC1 = new ParaClonar();
            oC1.Nombre = "ejemplo A";
            oC1.Valor = 10;

            //Observar que por más que oC2 apunte a oC1, en realidad
            //estoy clonando, es unca copia
            ParaClonar oC2 = oC1.Clone() as ParaClonar;
            oC2.Nombre = "ejemplo B";

            //El nombre va a cambiar, pero que hice un Clon, el número al no sobreescribirlo, toma el valor del primero
            Console.WriteLine("Texto 1: " + oC1.Nombre + " Valor 1: " + oC1.Valor);
            Console.WriteLine("Texto 2: " + oC2.Nombre + " Valor 2: " + oC2.Valor);
        }
    }
}
