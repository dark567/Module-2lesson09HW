using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Group
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Teacher Teacher { get; set; }

        private int countStudents = 0;

        /// <summary>
        /// System.NullReferenceException: 'Ссылка на объект не указывает на экземпляр объекта.'
        /// бодался бодался не знаю как сделать
        /// </summary>
        public int CountStudents
        {

            get
            {
                return countStudents;
            }
            set
            {
                countStudents++;

                //if (value <= 20 && Teacher.TeacherType == TypeTeacher.Docent)
                //{
                //    countStudents++;
                //}
                //else if (Teacher.TeacherType == TypeTeacher.Lector && value <= 15)
                //{
                //    countStudents++;
                //}
                //else
                //{
                //    Console.WriteLine("Overload");
                //    countStudents++;
                //}
            }
        }


        public static List<Group> _modelGroup;

        static Group()
        {
            _modelGroup = new List<Group>();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_name"></param>
        public Group(string _name, Teacher _teacher = null, int CountStudents = 0)
        {
            this.Id = Guid.NewGuid();
            this.Name = _name;
            this.Teacher = _teacher;
            this.CountStudents ++;
        }

        /// <summary>
        /// todo list
        /// </summary>
        /// <param name="Index"></param>
        //public static void AddCount(int Index=0)
        //{
        //    _modelGroup[0].CountStudents++;
        //}

    }
}
