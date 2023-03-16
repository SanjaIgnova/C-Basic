using SEDC.Homework_4.Homework.Task3.NewFolder;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

Student[] students = new Student[5];

students[0] = new Student() { Name = "Sanja", Academy = "Web Developer", Group = "G5"};
students[1] = new Student() { Name = "Irena", Academy = "Web Developer", Group = "G%5" };
students[2] = new Student() { Name = "Kristijan", Academy = "Web Dizajn", Group = "G1" };
students[3] = new Student() { Name = "Viktor", Academy = "Data Base", Group = "G3" };
students[4] = new Student() { Name = "Marija", Academy = "Data Base", Group = "G7" };


while (true)
{

    Console.WriteLine("Plase enter a student name?");
    string studentInput = Console.ReadLine();
    bool studentName = false;


    foreach (Student student1 in students)
    {
        if (student1.Name == studentInput)
        {
            Console.WriteLine($"Student: {student1.Name} Academy: {student1.Academy} Gropu: {student1.Group} ");
            studentName = true;
            break;
        }
    }
        if (!studentName)
        {
            Console.WriteLine("There is not student with that name!");
            break;
        }
    break;
 }
 

