using System;

namespace PrimeraAplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 19;

            //Interpolacion de strings. Es más eficiente que la concatenación de strings conn +            
            Console.WriteLine($"Tienes una edad de {age} años");

            int age1, age2, age3, age4=100;

            var edadPersona = 27; //Asigna en tiempo de ejecucion el tipo
                                // que corresponda a la variable. En este caso,
                                //edadPersona en tiempo de ejecucion sera entero.
                                
                                //Una variable var siempre debe ir inicializada.

            //no puedes hacer:
            //edadPersona = 24.5; //porque edad persona es de tipo entero

            //Conversion explicita:
            //casting
            double temperatura = 34.9;
            int temperaturaMadrid;
            temperaturaMadrid = (int) temperatura;
            //revisar tabla de conversion implicita para saber cuando hacer casting o 
            //conversion explicita

            //Converion explicita:
            int habitantesCiudad = 10000000;
            long habitantesCiudad2018 = habitantesCiudad;


            //Cambiar de string a entero o float, etc:
            Console.WriteLine("Introduce un numero: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce un numero: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"El resultado es: {num1 + num2}");

            //CONTINUAR EN EL VIDEO 8 DE C# DE PILDORAS INFORMATICAS










        }
    }
}
