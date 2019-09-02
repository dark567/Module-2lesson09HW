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
        /// Add Group Students Count
        /// </summary>
        /// <param name="Index"></param>
        public static void AddGroupStudentsCount(int Index)
        {
            if (Group._modelGroup[Index].Teacher.TeacherType == TypeTeacher.Docent && Group._modelGroup[Index].CountStudents >= 20)
            {
                OverloadCountStudents(Index);
            }
            if (Group._modelGroup[Index].Teacher.TeacherType == TypeTeacher.Lector && Group._modelGroup[Index].CountStudents >= 15)
            {
                OverloadCountStudents(Index);
            }
            if (Group._modelGroup[Index].Teacher.TeacherType == TypeTeacher.Accictent && Group._modelGroup[Index].CountStudents >= 5)
            {
                OverloadCountStudents(Index);
            }
            else
            {
                Group._modelGroup[Index].CountStudents = Group._modelGroup[Index].CountStudents + 1;
            }
        }

        /// <summary>
        /// DRY
        /// </summary>
        /// <param name="Index"></param>
        public static void OverloadCountStudents(int Index)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Overload \"{Group._modelGroup[Index].Teacher.TeacherType}\" Count > 5");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;

            LogicLayer.AddGroup(new Group(Group._modelGroup[Index].Name + "_" + Index + 1, Group._modelGroup[Index].Teacher));
            Group._modelGroup[Index + 1].CountStudents = Group._modelGroup[Index + 1].CountStudents + 1;
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
        public static void AddStudent(Student _modelStudent/*, int Index = 0*/)
        {
            Student._modelStudent.Add(_modelStudent);
           // Group._modelGroup[Index].CountStudents++; //todolist
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
