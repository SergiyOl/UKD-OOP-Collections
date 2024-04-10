using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UKD_OOP_Collections
{
    class Group
    {
        public List<Student> studentList = new();
        public string name;

        public Group(string name_)
        {
            name = name_;
        }
    }
}
