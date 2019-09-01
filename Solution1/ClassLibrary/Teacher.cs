using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Teacher
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Group GroupId { get; set; }

        public static List<Teacher> _modelTeacher;

        static Teacher()
        {
            _modelTeacher = new List<Teacher>();
        }
    }
}
