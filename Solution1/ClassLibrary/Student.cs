using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary
{
    public class Student
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; } 
        public Group GroupName { get; set; }
        public static List<Student> _modelStudent;

        static Student()
        {
            _modelStudent = new List<Student>();
        }

        public Student(string _name, Group _groupName, int _age = 0)
        {
            this.Id = Guid.NewGuid();
            this.Name = _name;
            this.GroupName = _groupName;
            this.Age = _age;
        }

    }
}
