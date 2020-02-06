using System;
using System.Collections;

namespace CircularArrayRotation
{
    class Program
    {
        
        
        static int[] circularArrayRotation(int[] a, int k, int[] queries) {

            int point = k % a.Length;
            //Console.WriteLine($"point = {point}");
            int[] array = new int[a.Length];
            int[] arrayResult = new int[queries.Length];

            int indexArray = 0;
            for(int i = a.Length - point; i < a.Length; i++)
            {
                array[indexArray] = a[i];
                indexArray++;
            }

            for(int i = 0 ; i < a.Length - point; i++)
            {
                array[indexArray] = a[i];
                indexArray++;
            }

            indexArray = 0;
            foreach (var item in queries)
            {
                arrayResult[indexArray] = array[item]; 
                indexArray++;  
            }
            return arrayResult; 
        }
        
        
        static void Main(string[] args)
        {
            int[] a = {1,2,3,5,7,9,11};
            int k = 5;
            int[] queries = {0, 1, 2};

            int[] array = circularArrayRotation(a, k, queries);

            foreach (var item in array)
            {
                Console.WriteLine(item);  
            }
        }
    }
}
