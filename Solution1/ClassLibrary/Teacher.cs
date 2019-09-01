using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public enum TypeTeacher
    {
        Docent,
        Lector,
        Accictent
    }

    public class Teacher
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public TypeTeacher TeacherType;


        public static List<Teacher> _modelTeacher;

        static Teacher()
        {
            _modelTeacher = new List<Teacher>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_name"></param>
        /// <param name="_type"></param>
        /// <param name="_groupName"></param>
        public Teacher(string _name, TypeTeacher _type)
        {
            this.Id = Guid.NewGuid();
            this.Name = _name;
            this.TeacherType = _type;
        }

    }
}
