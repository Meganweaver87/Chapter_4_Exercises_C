using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {

            List<Student> studentList = new List<Student>();

            Student Megan = new Student("Megan", 222, 1, 4.0);
            studentList.Add(Megan);
            //Debug.Print("Student class");

            Student Rocky = new Student("Rocky", 223, 12, 4.2);
            studentList.Add(Rocky);


            Student Mandy = new Student("Mandy", 224, 24, 4.0);
            studentList.Add(Mandy);


            Course WebDev = new Course("LC101", new Instructor("Dusti", "Weaver", "WebDev", 15), DateTime.Now, studentList);
            //Debug.Print(studentList);

            Student M = studentList[0];
            //Console.WriteLine(M);

            M.AddGrade(1, 3.8);
            Debug.Print(M.ToString());
           

        }

        

        

    }

}
