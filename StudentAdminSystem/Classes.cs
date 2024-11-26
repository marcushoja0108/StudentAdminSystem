using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdminSystem
{
    internal class Classes
    {
        public int classID { get; set; }
        public string className { get; set; }
        public int studentPoints { get; set; }

        public Classes(int classid, string classname, int studentpoints)
        {
            classID = classid;
            className = classname;
            studentPoints = studentpoints;
        }

        public void SkrivUtInfo()
        {
            Console.WriteLine("");
            Console.WriteLine($"Class ID: {classID}");
            Console.WriteLine($"class Name: {className}");
            Console.WriteLine($"Student points: {studentPoints}");
            Console.WriteLine("");
        }
    }
}
