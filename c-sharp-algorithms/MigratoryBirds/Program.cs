using System;
using System.Collections.Generic;
using System.Linq;

namespace MigratoryBirds
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //int[] arr = {};
            //int[] arr = {};

            List<int> arr1 = new List<int>()
            { 1,1,2,2,3 };

            List<int> arr2 = new List<int>()
            { 1, 4, 4, 4, 5, 3 };

            List<int> arr3 = new List<int>()
            { 1, 2, 3, 4, 5, 4, 3, 2, 1, 3, 4 };
            
            int number = MigratoryBirdsAlgorithm(arr3);
            
            Console.WriteLine(number);
        }

        public static int MigratoryBirdsAlgorithm(List<int> arr)
        {
            int number = 0;
            int[] num_arr = {0,0,0,0,0};
            int max_number = 0;

            for(int i = 0; i < arr.Count(); i++)
            {
                if (arr[i] == 1)
                {
                    num_arr[0] += 1;
                } else if (arr[i] == 2)
                {
                    num_arr[1] += 1;
                } else if (arr[i] == 3)
                {
                    num_arr[2] += 1;
                } else if (arr[i] == 4)
                {
                    num_arr[3] += 1;
                } else
                {
                    num_arr[4] += 1;
                }                                
            }

            max_number = num_arr.Max();

            for(int i = 0; i < num_arr.Length; i++)
            {
                if (max_number == num_arr[i])
                {
                    number = i + 1;
                    break;
                }else{continue;}
            }   

            return number;

        }

    }

}
    