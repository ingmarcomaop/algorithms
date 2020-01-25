using System;
using System.Collections.Generic;
using CoreSchool.Entities;


namespace CoreSchool.App
{
    public class SchoolEngine
    {
        public School School { get; set; }  

        public SchoolEngine()
        {
            School = new School("My Success Online Academy", 2012, TypeSchool.Primary,
                                    country: "Colombia", city: "Medellin");
        }

        public void Initializer()
        {
            //Uso de lista genercia:
            LoadCourses();
            LoadSignatures();
            LoadStudents();
            
            LoadExams();

            //School.Courses.Add(new Course{Name="102", workingday = TypeWorkingDay.Afternoon});
            //School.Courses.Add(new Course{Name="202", workingday = TypeWorkingDay.Afternoon});




        }

        private void LoadExams()
        {
            throw new NotImplementedException();
        }

        private void LoadSignatures()
        {
            foreach(var course in School.Courses)
            {
                var listSignatures = new List<Signature>(){
                    new Signature{Name="Mathematics"},
                    new Signature{Name="Geografic"},
                    new Signature{Name="History"},
                    new Signature{Name="Biologic"}
                };
                course.Signatures.AddRange(listSignatures);
            }
        }

        private void LoadStudents()
        {
            throw new NotImplementedException();
        }

        private void LoadCourses()
        {
            School.Courses = new List<Course>(){
                new Course() {Name = "101", workingday = TypeWorkingDay.Day},
                new Course() {Name = "201", workingday = TypeWorkingDay.Day},
                new Course {Name = "301", workingday = TypeWorkingDay.Day},
                new Course() {Name = "401", workingday = TypeWorkingDay.Afternoon},
                new Course() {Name = "501", workingday = TypeWorkingDay.Afternoon}
            };
        }
    }
}