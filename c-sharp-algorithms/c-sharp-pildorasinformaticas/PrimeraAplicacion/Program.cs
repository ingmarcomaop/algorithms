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
            //int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce un numero: ");
            //int num2 = int.Parse(Console.ReadLine());

            //Console.WriteLine($"El resultado es: {num1 + num2}");

            //Constantes. Una buena práctica es declararlas en mayúsculas:
            //No puede cmbiar su valor a lo largo del programa.
            const int VALOR = 5;
            Console.WriteLine("La constante es: ", VALOR);

            //Para imprimir la variable {0} (parámetro de index cero porque se puede poner
            //más valores)

            const int VARIABLE = 7;
            //Para ver VALOR {0} y para ver VARIABLE {1}
            Console.WriteLine("La constante es: {0}", VALOR, VARIABLE);
            Console.WriteLine("La constante es: {1}", VALOR, VARIABLE);

            //Cuando el metodo solo tiene una instruccion se puede escribir asi: (lambda function)
            //static void suma(double a, int b) => a + b;

            //Cuando los metodos tienen una unica palabra empiezan con mayuscula

            //La sobre carga de metodos se produce cuando uno tiene metodos con el mismo nombre
            //pero con diferentes tipos de parametro o bien, diferente numero de parametros.

            //Los paametros opcionales de un metodo deben ir siempre al final

            double result1 = Suma(1, 3.5, 3.5);
            Console.WriteLine($"Suma = {result1}");

            //Forma de escribir if else
            //Esta forma es solo si los condicionales tienen una línea
            bool edad1 = true;

            if (edad1)
                Console.WriteLine("Tu edad es: ");
                //Console.WriteLine("Tu edad no es: ");
            else
                Console.WriteLine("Tu edad no es: ");

            //Tambien:
            if (edad1) Console.WriteLine("MAYUSCULA: ");
            else Console.WriteLine("minuscula: ");

            //https://www.youtube.com/watch?v=TuwFgCngEOY&list=PLU8oAlHdN5BmpIQGDSHo5e1r4ZYWQ8m4B&index=16

        }

        public static double Suma(int v1, double v2, double v3 = 0.0) => v1 + v2 + v3;
    }
}
