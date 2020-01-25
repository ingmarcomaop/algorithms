using System;

namespace CoreSchool
{
    
    class School
    {
        public string name;
        public string address;
        public int fundationYear;
        public string ceo;

        public void ring()
        {
            Console.Beep(3500, 1000);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            var mySchool = new School();
            mySchool.name = "Marco Ortega";
            mySchool.address = "New Av. Wall Street";
            mySchool.fundationYear = 2012;

            Console.WriteLine("Ringing...");
            //mySchool.ring();
        }
    }
}
