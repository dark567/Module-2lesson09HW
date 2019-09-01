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
        public Group Group { get; set; }
        public static List<Student> _modelStudent;

        static Student()
        {
            _modelStudent = new List<Student>();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_name"></param>
        /// <param name="_groupName"></param>
        /// <param name="_age"></param>
        public Student(string _name, Group _groupName, int _age = 0)
        {
            this.Id = Guid.NewGuid();
            this.Name = _name;
            this.Group = _groupName;
            this.Age = _age;
        }

    }
}
