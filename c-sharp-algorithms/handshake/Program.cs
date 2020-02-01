using System;

namespace handshake
{
    class Program
    {

        public static int handshake(int totalPeople){
          
            return (totalPeople * (totalPeople - 1))/2;
            
        }

        

        static void Main(string[] args)
        {
            int n = 883;
            int totalHandshake = handshake(n);
            Console.WriteLine(totalHandshake);
        }
    }
}
