using static System.Console;

namespace CoreSchool.Util
{
    //La clase static no permite crear nuevas instancias. La clase por si misma va a funcionar como un objeto.
    //Por ejemplo Console no permite instancias porque es static.
    public static class Printer
    {
        public static void DrawLine(int tam)
        {
            //var line = "".PadLeft(tam, '='); //Me pone un string de tam veces el caracter =
            //WriteLine(line);
            WriteLine("".PadLeft(tam, '='));
        }

        public static void WriteTitle(string title){
            
            var tam = title.Length + 4;
            
            DrawLine(tam);
            WriteLine($"| {title} |");
            DrawLine(tam);
        }

        public static void Beep(int hz = 2000, int time = 500, int total = 1)
        {
            while(total-- > 0)
            {
                System.Console.Beep(hz, time);
            }
        }
        
    }
}