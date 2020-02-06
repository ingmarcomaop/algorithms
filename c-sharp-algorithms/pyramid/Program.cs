using System;

namespace pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int levels = 6;
            int spaces = levels -1;
            int aux = spaces;
            
            for(int i = 1; i <= levels; i++)
            {
                aux = spaces;

                while(aux != 0)
                {
                    Console.Write(" "); 
                    aux--;  
                }

                for(int j = 0; j < 2*i - 1; j++)
                {
                    Console.Write("#"); 
                }
                
                spaces--;

                Console.WriteLine();

            }

        }
   
    }

}
