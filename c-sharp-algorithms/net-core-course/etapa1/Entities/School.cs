using System.Collections.Generic;

namespace   CoreSchool.Entities
{
    public class School
    {
        //Ejemplo de encapsulamiento
        string name;
        public string Name{
            get{ return "Copia de " + name; }
            set{ name = value.ToUpper();}
        }

        public int yearFoundation {get; set;}

        public string Country {get; set;}
        public string City {get; set;}
        public TypeSchool typeSchool {get; set;}
        //public Course[] Courses {get; set;}
        public List<Course> Courses { get; set; }

        /*public School(string name, int year)
        {
            this.name = name;
            yearOfFoundation = year;
        }
        */


        //Igualacion por tuplas:
        public School(string name, int year) => (Name, yearFoundation) = (name, year);

        //Poner country="" indica que el parámetro es opcional y deja por defecto cadana vacía (en este caso)
        public School(string name, int year, TypeSchool type, string country="", string city="")
        {
            (Name, yearFoundation) = (name, year);
            Country = country;
            City = city;
        } 

        // override significa sobreescribir y acá se está sobreescribiento el método ToString()
        public override string ToString()
        {
            //Con el signo $ me permite poner variables que tengo especificadas
            //\"{Name}\" dibuja una comilla en la variable
            //{System.Environment.NewLine} pone una nueva línea y es mejor implementarlo así
            //porque \n en linux y en windows cambia
            return $"Name: \"{Name}\", Type: {typeSchool} {System.Environment.NewLine}Country: {Country}, City: {City} {System.Environment.NewLine}";
        }

    }
}