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

            AddListForExample();

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
                            Console.WriteLine($"[{index++}] \t {spw.Id} \t {spw.Name} \t {spw.Age}");
                        }

                        ShowMenuInConsole();

                        break;
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
            Console.WriteLine("\t [4] Enter New Group");
            Console.WriteLine("\t [5] Enter New Teacher");
            Console.WriteLine("\t [6] Enter New Student");
            Console.WriteLine("\t [7] Delete Student");
            Console.WriteLine("\t [8] Exit the program");
        }

        /// <summary>
        /// Add List For Example
        /// </summary>
        static void AddListForExample()
        {
            LogicLayer.AddTeacher(new Teacher("Anders Hejlsberg", TypeTeacher.Docent));
            LogicLayer.AddStudent(new Student("Jone White", new Group("Group C#"), 25));
            LogicLayer.AddGroup(new Group("Group C#", new Teacher("Anders Hejlsberg", TypeTeacher.Docent)));

            LogicLayer.AddTeacher(new Teacher("James Arthur Gosling", TypeTeacher.Docent));
            LogicLayer.AddStudent(new Student("Smith Red", new Group("Group Java"), 30));
            LogicLayer.AddGroup(new Group("Group Java", new Teacher("James Arthur Gosling", TypeTeacher.Accictent)));

            LogicLayer.AddTeacher(new Teacher("Tim Berners-Lee", TypeTeacher.Docent));
            LogicLayer.AddStudent(new Student("Dan Black", new Group("Group HTML"), 41));
            LogicLayer.AddGroup(new Group("Group HTML", new Teacher("Tim Berners-Lee", TypeTeacher.Lector)));

        }
    }
}
