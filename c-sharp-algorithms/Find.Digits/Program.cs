using System;
using System.Collections;

namespace Find.Digits
{
    class Program
    {
        
        static int findDigits(int n) {

            string arrayDigitsFromNumber;
            int numberTotalDivisors;
            arrayDigitsFromNumber = digitsFromNumber(n);
            numberTotalDivisors = totalDivisor(arrayDigitsFromNumber, n);
            
            return numberTotalDivisors;
        }

        public static string digitsFromNumber(int n)
        {
            ArrayList arrayDigits = new ArrayList();
            string stringN = n.ToString();

            return stringN;
        }

        private static int totalDivisor(string arrayDigitsFromNumber, int n)
        {
            int number;
            int totalDivisors = 0;
            
            for(int i = 0; i < arrayDigitsFromNumber.Length; i++)
            {
                number = arrayDigitsFromNumber[i] - '0'; //Convetion char to int
                
                if(number == 0) {continue;}
                else{
                    if(n %  number == 0)
                    {
                        totalDivisors++;
                    }else{continue;}
                }  
            }
            
            return totalDivisors;
        }

        static void Main(string[] args)
        {
            int n = 12;
            int totalDivisors =  findDigits(n);
            Console.WriteLine(totalDivisors);
        }
    }
}
