using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public static class LogicLayer
    {
        public static Student[] GetStudents
        {
            get
            {
                return Student._modelStudent.ToArray();
            }
        }

        public static void AddStudent(Student _modelStudent)
        {
            Student._modelStudent.Add(_modelStudent);
        }
    }
}
