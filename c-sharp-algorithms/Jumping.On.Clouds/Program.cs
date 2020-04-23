using System;
using System.Collections;

namespace Jumping.On.Clouds
{
    class Program
    {
        public static int TimesToConcatArray(int[] c, int k)
        {
            int timesToDuplicate = 0;
            int numToDuplicateArray = c.Length;
            int tmp = numToDuplicateArray;

            while(tmp % k != 0) 
            { 
                tmp += numToDuplicateArray;
                timesToDuplicate += 1;
            }            
            
            return timesToDuplicate;
        }

        public static int[] ConcatArray(int[] c, int numToDuplicateArray)
        {
            ArrayList duplicatedArray = new ArrayList(c);

            while(numToDuplicateArray != 0)
            {
                duplicatedArray.AddRange(c);
                numToDuplicateArray -= 1;
            }

            duplicatedArray.Add(c[0]);
            int[] outArray = (int[])duplicatedArray.ToArray(typeof(int));

            return outArray;
        }

        static int jumpingOnClouds(int[] c, int k) {

            int e = 100;
            int timesToConcatArray = TimesToConcatArray(c, k);
            int[] inputArray = ConcatArray(c, timesToConcatArray);
            int n = inputArray.Length;
            
            for(int i = k; i < n; i+=k)
            {
                if(inputArray[i] == 1) { e -= 3; }
                else{ e -= 1; }  
            }

            return e;
        }


        static void Main(string[] args)
        {
            //int[] c = {0,0,1,0}; int k = 2;
            //int[] c = {1, 1, 1, 0, 1, 1, 0, 0, 0, 0}; int k = 3;
            //int[] c = {0, 0, 1, 0, 0, 1, 1, 0}; int k = 2;
            int[] c = {0, 0, 1, 0, 0, 1, 1, 0}; int k = 3;
            
            //int timesToConcatArray = TimesToConcatArray(c, k);
            //int[] inputArray = ConcatArray(c, timesToConcatArray);
            int energy = jumpingOnClouds(c, k);
            Console.WriteLine("The final energy level is: " + energy); 
        }
    }
}
