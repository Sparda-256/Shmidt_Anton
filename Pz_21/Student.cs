using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace Pz_21
{
    internal class Student
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string patronymic { get; set; }
        public string dateOfBirth { get; set; }
        public int yearOfStudy { get; set; }
        public string speciality { get; set; }
        public void GetCourse(int date)
        {
            Console.WriteLine($"Вы учислись: {date}");
        }
        public void PrintInfo(string name, string surname, string patronymic, string dateOfBirth, int yearOfStudy, string speciality)
        {
            Console.WriteLine();
            Console.WriteLine($"Студент:\n{name}\n{surname}\n{patronymic}\n{dateOfBirth}\n{yearOfStudy}\n{speciality}");
        }
    }
}
