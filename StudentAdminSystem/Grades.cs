using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdminSystem
{
    internal class Grades
    {
        public int StudentID;
        public int classID;
        public int Grade { get; set; }

        public Grades(int studentid, int classid, int grade)
        {
            StudentID = studentid;
            classID = classid;
            Grade = grade;
        }


        public void SkrivUtInfo()
        {
            Console.WriteLine("");
            Console.WriteLine($"Student ID: {StudentID}");
            Console.WriteLine($"Class ID: {classID}");
            Console.WriteLine($"Grade {Grade}");
            Console.WriteLine("");

        }
    }
}
