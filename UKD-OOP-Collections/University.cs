using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UKD_OOP_Collections
{
    class University
    {
        public List<Group> groupList = new();
        public string name;
        public static int nextStudentId = 0;

        public University(string name_)
        {
            name = name_;
        }

        public void AddGroup(string name)
        {
            groupList.Add(new Group(name));
            Console.WriteLine("New group added");
        }

        public void RemoveGroup(string name)
        {
            if(groupList.Find(x => x.name == name) != null)
            {
                groupList.Remove(groupList.Find(x => x.name == name));
                Console.WriteLine("Group removed");
            }
            else
            {
                Console.WriteLine("Group is not found");
            }
        }

        public void AddStudent(string name, string groupName)
        {
            if (groupList.Find(x => x.name == groupName) != null)
            {
                groupList.Find(x => x.name == groupName).studentList.Add(new Student(nextStudentId, name));
                Console.WriteLine("New student added");
                nextStudentId++;
            }
            else
            {
                Console.WriteLine("Group is not found");
            }
        }

        public Student FindStudent(int id)
        {
            Student foundStudent;
            foreach (var item in groupList)
            {
                foundStudent = item.studentList.Find(x => x.id == id);
                if (foundStudent != null)
                {
                    return foundStudent;
                }
                else{
                    continue;
                }
            }
            Console.WriteLine("Student with this id is not found");
            return default;
        }

        public void RemoveStudentById(int id)
        {
            Student toDelete = FindStudent(id);
            if (toDelete != null)
            {
                foreach (var item in groupList)
                {   
                    item.studentList.Remove(toDelete);
                }
                Console.WriteLine("Student removed");
            }
        }

        public void RenameStudentById(int id, string newName)
        {
            Student toChange = FindStudent(id);
            if (toChange != null)
            {
                toChange.name = newName;
                Console.WriteLine("Student's name changed");
            }
        }

        public void ShowEveryoneInUniversity()
        {
            foreach(var group in groupList)
            {
                Console.WriteLine($"Група: {group.name}");
                foreach (var student in group.studentList)
                {
                    Console.WriteLine(student.name);
                    Console.WriteLine($"id = {student.id}");
                }
            }
        }
        public void ShowEveryoneInGroup(string groupName)
        {
            Group group = groupList.Find(x => x.name == groupName);
            if (group != null)
            { 
                Console.WriteLine($"Група: {group.name}");
                foreach (var student in group.studentList)
                {
                    Console.WriteLine(student.name);
                    Console.WriteLine($"id = {student.id}");
                }
            }
            else
            {
                Console.WriteLine("Group is not found");
                return;
            }  
        }
    }
}
