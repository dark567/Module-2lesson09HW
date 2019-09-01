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
        /// Add Group
        /// </summary>
        /// <param name="_modelGroup"></param>
        public static void AddGroup(Group _modelGroup)
        {
            Group._modelGroup.Add(_modelGroup);
        }

        /// <summary>
        /// Add Teacher
        /// </summary>
        /// <param name="_modelTeacher"></param>
        public static void AddTeacher(Teacher _modelTeacher)
        {
            Teacher._modelTeacher.Add(_modelTeacher);
        }
        /// <summary>
        /// Add Student
        /// </summary>
        /// <param name="_modelStudent"></param>
        public static void AddStudent(Student _modelStudent, int Index = 0)
        {
            Student._modelStudent.Add(_modelStudent);
           // Group.AddCount(Index); //todolist
        }

        /// <summary>
        /// Remove Student
        /// </summary>
        /// <param name="Index">index list who removing</param>
        public static void RemoveStudent(int Index)
        {
            Student._modelStudent.RemoveAt(Index);
        }
    }
}
