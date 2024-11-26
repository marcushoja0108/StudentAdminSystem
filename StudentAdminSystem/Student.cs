using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdminSystem
{
    internal class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Program { get; set; }
        public int StudentID { get; set; }

        public Student( string name, int age, string program, int studentID)
        {
            Name = name;
            Age = age;
            Program = program;
            StudentID = studentID;
        }
        public void SkrivUtInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Program: {Program}");
            Console.WriteLine($"StudentID: {StudentID}");
            Console.WriteLine("");
        }

    }
}
