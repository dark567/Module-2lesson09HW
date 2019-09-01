using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public static class LogicLayer
    {
        /// <summary>
        /// 
        /// </summary>
        public static Group[] GetGroup
        {
            get
            {
                return Group._modelGroup.ToArray();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public static Teacher[] GetTeacher
        {
            get
            {
                return Teacher._modelTeacher.ToArray();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public static Student[] GetStudents
        {
            get
            {
                return Student._modelStudent.ToArray();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_modelGroup"></param>
        public static void AddGroup(Group _modelGroup)
        {
            Group._modelGroup.Add(_modelGroup);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_modelTeacher"></param>
        public static void AddTeacher(Teacher _modelTeacher)
        {
            Teacher._modelTeacher.Add(_modelTeacher);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_modelStudent"></param>
        public static void AddStudent(Student _modelStudent)
        {
            Student._modelStudent.Add(_modelStudent);
        }
    }
}
