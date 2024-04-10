using System;

namespace UKD_OOP_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // Створення університету
            University myUni = new("UKD");
            // Створення груп
            myUni.AddGroup("group1");
            myUni.AddGroup("group2");
            myUni.AddGroup("group3");
            Console.WriteLine(myUni.groupList.Count);
            // Видалення груп
            Console.WriteLine();
            myUni.RemoveGroup("group5"); // group in not found
            myUni.RemoveGroup("group3");
            Console.WriteLine(myUni.groupList.Count);
            // Створення студентів
            Console.WriteLine();
            myUni.AddStudent("student0", "group5"); // group in not found
            myUni.AddStudent("student0", "group1");
            myUni.AddStudent("student1", "group1");
            myUni.AddStudent("student2", "group2");
            myUni.AddStudent("student3", "group2");
            myUni.AddStudent("student4", "group2");
            // Видалення студентів
            Console.WriteLine();
            myUni.RemoveStudentById(7); // id is not found
            myUni.RemoveStudentById(3);
            myUni.FindStudent(3);
            // Перейменування студентів
            Console.WriteLine();
            myUni.RenameStudentById(7, "Vasil"); // id is not found
            myUni.RenameStudentById(2, "Vasil");
            // Показати студентів в групі
            Console.WriteLine();
            myUni.ShowEveryoneInGroup("group5"); // group is not found
            myUni.ShowEveryoneInGroup("group2");
            // Показати студентів в університеті
            Console.WriteLine();
            myUni.ShowEveryoneInUniversity();

        }
    }
}
