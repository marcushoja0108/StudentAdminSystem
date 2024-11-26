using StudentAdminSystem;
bool app = true;

Student student1 = new Student("Matilda", 19, "Basic Programming", 3996);
Student student2 = new Student("Thomas", 21, "Arts and Crafts", 2112);
Student[] students = new Student[2];
students[0] = student1;
students[1] = student2;

Classes class1 = new Classes(14, "Basic Programming", 60);
Classes class2 = new Classes(9, "Arts and Crafts", 20);
Classes class3 = new Classes(16, "Bad Maths", 15);


List<Classes> LessonsList = new List<Classes>();
LessonsList.Add(class1);
LessonsList.Add(class2);
LessonsList.Add(class3);

Grades grade1 = new Grades(student1.StudentID, class1.classID, 5);
Grades grade2 = new Grades(student2.StudentID, class2.classID, 4);
Grades[] grades = new Grades[2];
grades[0] = grade1;
grades[1] = grade2;


Console.WriteLine("Commands:");
Console.WriteLine("   StudentInfo");
Console.WriteLine("   LessonInfo");
Console.WriteLine("   Grades");
Console.WriteLine("");

while (app == true)
{

    var userCommand = Console.ReadLine().ToLower();

    switch (userCommand)
    {
        case "studentinfo":
            foreach (var student in students)
            {
                Console.WriteLine($"   StudentID : {student.StudentID}");
            }
            Console.WriteLine("");
            Console.WriteLine("Type the studentID of the student you want to view.");
            Console.WriteLine("");
            int userInput = Convert.ToInt32(Console.ReadLine());
            foreach (var student in students)
            {
                if (userInput == student.StudentID)
                {
                    student.SkrivUtInfo();
                }    
            }
            break;
        case "lessoninfo":
            foreach (var lesson in LessonsList)
            {
                lesson.SkrivUtInfo();
            }
            
            break;
        case "grades":
            Console.WriteLine("   Students");
            foreach (var student in students)
            {
                Console.WriteLine(student.StudentID);
            }
            Console.WriteLine("   Lessons");
            foreach (var lesson in LessonsList)
            {
                Console.WriteLine(lesson.classID);
            }
            Console.WriteLine("Type the ID of either a student or lesson to see their grades.");
            var userinput = Convert.ToInt32(Console.ReadLine());

            foreach (var grade in grades)
            {
                if (userinput == grade.StudentID || userinput == grade.classID)
                {
                    grade.SkrivUtInfo();
                }
            }
            break;
    }
}
