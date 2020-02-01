using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


namespace MinimunHeightTriangle
{
    
    class Program
    {
    
        public static int lowestTriangle(int bases, int area)
        {
            /*double h = 0.0;
            double float_h = 0.0;
            int integerr = 0;
            double decimall = 0;
            
            for(double i = (double) area; i <= 1000000; i++)
            {
                float_h = 2.0 * (i/bases);
                //Console.WriteLine("float_h = " + float_h);
                integerr = (int) float_h;
                decimall = (10 * float_h - 10 * integerr)/10;
                //Console.WriteLine("decimall = " + decimall);

                if(decimall == 0.0)
                {
                    h = float_h;
                    break;
                }
                else    
                    continue;      
            }

            return (int) h;
            */

            return (int)  Math.Ceiling((2.0 * area)/bases);
        }

        static void Main(string[] args)
        {
            int h = lowestTriangle(755, 737983);
            Console.WriteLine("Height = " + h);

        }
    }
}
