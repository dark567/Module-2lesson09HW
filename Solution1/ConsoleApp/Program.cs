using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool MQuit = false;

            int ChoiceNomMenu = 0;

            //first filling
            AddNEWListForExample();

            //show menu
            ShowMenuInConsole();

            while (!MQuit)
            {
                if (!Int32.TryParse(Console.ReadLine(), out ChoiceNomMenu) || !(ChoiceNomMenu >= 1 && ChoiceNomMenu <= 8))
                {
                    Console.WriteLine("\t Invalid input. Try again:");
                    Console.WriteLine("\t Please make your choice...");
                    ShowMenuInConsole();
                    continue;
                }

                switch (ChoiceNomMenu)
                {
                    case 1: //Show ALL Groups

                        int index = 0;
                        foreach (Group spw in LogicLayer.GetGroup)
                        {
                            Console.WriteLine($"[{index++}] \t {spw.Id} \t {spw.Name} \t {spw.Teacher.Name} \t {spw.CountStudents}");
                        }

                        ShowMenuInConsole();

                        break;
                    case 2: //Show ALL Teachers

                        index = 0;
                        foreach (Teacher spw in LogicLayer.GetTeacher)
                        {
                            Console.WriteLine($"[{index++}] \t {spw.Id} \t {spw.Name} \t {spw.TeacherType}");
                        }

                        ShowMenuInConsole();

                        break;
                    case 3: //Show ALL Students

                        index = 0;
                        foreach (Student spw in LogicLayer.GetStudents)
                        {
                            Console.WriteLine($"[{index++}] \t {spw.Id} \t {spw.Name} \t {spw.Age}\t {spw.Group.Name}");
                        }

                        ShowMenuInConsole();

                        break;
                    case 4: //Add new Student

                        addNewStudent();
                        ShowMenuInConsole();

                        break;
                    case 5: //Del Student

                        DelStudent();
                        ShowMenuInConsole();

                        break;
                    /*case 6-7 todolist*/
                    case 8:

                        Console.WriteLine("\t Quitting...");
                        MQuit = true;
                        break;
                    default:
                        Console.WriteLine("Please make your choice...");
                        break;
                }
            }
        }

        /// <summary>
        /// Show Menu In Console
        /// </summary>
        static void ShowMenuInConsole()
        {
            Console.WriteLine("\n Please choose one of the options:");
            Console.WriteLine("\t [1] Show ALL Groups");
            Console.WriteLine("\t [2] Show ALL Teacher");
            Console.WriteLine("\t [3] Show ALL Student");
            //Console.WriteLine("\t [4] Enter New Group"); //todo
            //Console.WriteLine("\t [5] Enter New Teacher"); //todo
            Console.WriteLine("\t [4] Add New Student");
            Console.WriteLine("\t [5] Delete Student");
            Console.WriteLine("\t [8] Exit the program");
        }

        /// <summary>
        /// Add New Student
        /// </summary>
        private static void addNewStudent()
        {
            try
            {
                int Age;
                string Name;
                Group Group;

                //Name
                Console.Write("\t Write Name Student:");
                Name = Console.ReadLine();

                //Age
                bool pr = false;
                do
                {
                    Console.Write("\t Write Age:");
                    pr = int.TryParse(Console.ReadLine(), out Age);
                    if (Age <= 0) pr = false;

                } while (!pr);

                //Group
                int index = 0;
                foreach (Group spw in LogicLayer.GetGroup)
                {
                    Console.WriteLine($"[{index++}] \t {spw.Id} \t {spw.Name} \t {spw.Teacher.Name} \t {spw.CountStudents}");
                }

                int NomerGroup;
                do
                {
                    Console.Write("\t Write Group №:");
                } while (!Int32.TryParse(Console.ReadLine(), out NomerGroup));

                LogicLayer.AddStudent(new Student(Name, Group._modelGroup[NomerGroup], Age));

                Console.WriteLine("\tSuccessfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("\tError. Something went wrong!)", e.Message);
            }

        }

        /// <summary>
        /// Delete Student
        /// </summary>
        public static void DelStudent()
        {
            int index = 0;
            foreach (Student spw in LogicLayer.GetStudents)
            {
                Console.WriteLine($"[{index++}] \t {spw.Id} \t {spw.Name}");
            }

            int StudentWhoRemoved;
            do
            {
                Console.Write("\t Write № who Delete:");
            } while (!Int32.TryParse(Console.ReadLine(), out StudentWhoRemoved));

            try
            {
                LogicLayer.RemoveStudent(StudentWhoRemoved);

                Console.WriteLine("\tSuccessfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("\tError. Something went wrong!)", e.Message);
            }
        }


        /// <summary>
        /// Add FIRST List For Example
        /// </summary>
        static void AddNEWListForExample()
        {
            LogicLayer.AddTeacher(new Teacher("Anders Hejlsberg", TypeTeacher.Docent));
            LogicLayer.AddStudent(new Student("Jone White", new Group("Group C#"), 25));
            LogicLayer.AddGroup(new Group("Group C#", new Teacher("Anders Hejlsberg", TypeTeacher.Docent)));

            LogicLayer.AddTeacher(new Teacher("James Arthur Gosling", TypeTeacher.Accictent));
            LogicLayer.AddStudent(new Student("Smith Red", new Group("Group Java"), 30));
            LogicLayer.AddGroup(new Group("Group Java", new Teacher("James Arthur Gosling", TypeTeacher.Accictent)));

            LogicLayer.AddTeacher(new Teacher("Tim Berners-Lee", TypeTeacher.Lector));
            LogicLayer.AddStudent(new Student("Dan Black", new Group("Group HTML"), 41));
            LogicLayer.AddGroup(new Group("Group HTML", new Teacher("Tim Berners-Lee", TypeTeacher.Lector)));

        }
    }
}
