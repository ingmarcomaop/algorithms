using System;
using System.Collections;


namespace between_two_sets
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] a = {2,6}; int[] b = {24,36};
            //int[] a = {2,4}; int[] b = {16,32,96};

            int result = getTotalX(a, b);

            Console.WriteLine(result);
            
            
            
            
            
            //Console.WriteLine("Hello World!");
        }

        public static bool validation(int[] a, int[] b, int number){

            foreach(int value in a){
                if (number % value != 0){
                    return false;
                }
            }

            foreach(int value in b){
                if(value % number != 0){
                    return false;
                }
            }
            
            return true;

        }

        

        public static int getTotalX(int[] a, int[] b)
        {
            int last_a = a[a.Length - 1];
            int first_b = b[0];

            int numbers = 0;
            
            ArrayList array = new ArrayList();

            
            for(int i = last_a; i < (first_b + 1); i ++){
                array.Add(i);
            }

            foreach(int value in array){
                if (validation(a, b, value)){
                    numbers += 1;
                }
            }
            
            
            return numbers;

        }


    }
}
