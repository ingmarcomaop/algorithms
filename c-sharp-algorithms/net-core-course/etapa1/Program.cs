using System;
using System.Collections.Generic;
using CoreSchool;
using CoreSchool.App;
using CoreSchool.Entities;
using CoreSchool.Util;
using static System.Console;

namespace etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new SchoolEngine();
            engine.Initializer();
            Printer.WriteTitle("Welcome to the School");

            //Printer.DrawLine(20);
            //Printer.Beep(10000, total:10);
            printSchoolCourses(engine.School);
            
            //School mySchool = new School();
            //var school = new School("My Success Online Academy", 2012, TypeSchool.Primary,
                                    //country: "Colombia", city: "Medellin");

            //school.Country = "Colombia";
            //school.City = "Medellin";
            //Console.WriteLine(school.Name);

            //school.typeSchool = TypeSchool.Primary;
            //Console.WriteLine(school);

            /*var arrayCourses = new Courses[3];
            arrayCourses[0] = new Courses()
            {
                Name = "101"
            };
            
            var course2 = new Courses()
            {
                Name = "201"
            };

            arrayCourses[1] = course2;

            arrayCourses[2] = new Courses()
            {
                Name = "301"
            };*/

            //Uso de arreglos:    
            /*school.Courses = new Course[]{
                        new Course() {Name = "101"},
                        new Course() {Name = "201"},
                        new Course {Name = "301"}
            };
            */

            

            //newCollection.Clear(); //Borra todos los elementos de una colección generica.

            /*
            Course tmp = new Course{Name = "101 Vacations", workingday = TypeWorkingDay.Night};
            //Las colecciones nos permiten agregar, quitar elemntos, etc.
            //Adicionar otra lista:
            school.Courses.AddRange(newCollection);
            school.Courses.Add(tmp);
            printSchoolCourses(school);
            //WriteLine("Course.Hash = " + tmp.GetHashCode()); //Para eliminar el framework mira el HasCode
            
            Predicate <Course> myAlgorithm = Predicating;
            //school.Courses.RemoveAll(myAlgorithm); //Manera de borrar (mirar metodo predicate)
            //school.Courses.Remove(tmp);
            school.Courses.RemoveAll(delegate (Course cour) //Creacion de delegado (remueve todos los que tengan 301 en el nombre)
                                    {
                                        return cour.Name == "301";
                                    }); //Los que tengan 301 retorna true y los borra

            */

            //Expresiones lambda:
            //school.Courses.RemoveAll((cour) => cour.Name == "501" && cour.workingday == TypeWorkingDay.Day);

            
            
            
            //Console.WriteLine(school);
            //System.Console.WriteLine("=================");
            /*Console.WriteLine(arrayCourses[0].Name + ", " + arrayCourses[0].UniqueId);
            Console.WriteLine($"{arrayCourses[1].Name}, {arrayCourses[1].UniqueId}");
            Console.WriteLine("Press intro...");
            Console.ReadLine();
            Console.WriteLine(arrayCourses[5]);
            //Console.WriteLine(course3);
            */

            //PrintNumbers(arrayCourses);
            //school.Courses = new Course[0];
            //printSchoolCourses(school);

        }

        private static bool Predicating(Course courseobj)
        {
            return courseobj.Name == "301"; //Borra el curso con "301"
        }

        private static void PrintNumbers(Course[] arrayCourses)
        {
            int tmp = 0;
            while (tmp < arrayCourses.Length)
            {
                Console.WriteLine($"Name {arrayCourses[tmp].Name}, Id {arrayCourses[tmp].UniqueId}");
                tmp++;
            }   
        }

        private static void printSchoolCourses(School school)
        {
            //WriteLine("==============");
            //WriteLine("School Courses");
            //WriteLine("==============");

            Printer.WriteTitle("School courses - .Net Core");

            //verifica si school es null y luego verifica school.Courses
            //El ? No va a verificar Courses, salvo a que school sea diferente de null
            if(school?.Courses != null)
            {
                foreach(var course in school.Courses)
                {
                    Console.WriteLine($"Name {course.Name}, Id {course.UniqueId}");   
                } 

            }
            

             
        }


    }
}
