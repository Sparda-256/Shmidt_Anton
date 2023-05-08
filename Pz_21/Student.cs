using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pz_21
{
    internal class Student
    {
        private string name;
        private string surname;
        private string patronymic;
        private DateTime dateOfBirth;
        private DateTime yearOfStudy;
        private string speciality;
        public int GetCourse()
        {
            if (yearOfStudy.Year != 1)
            {
                return (DateTime.Now.Year - yearOfStudy.Year);
            }
            else
            {
                Console.WriteLine("Вы не ввели год начала обучения!");
                return 0;
            }
        }
        public void PrintInfo()
        {
            Console.WriteLine("Имя: " + name + " Фамилия: " + surname + " Отчество: " + patronymic + " Дата рождения: " + dateOfBirth + " Год начала обучения: " + yearOfStudy.Year + " Специальность: " + speciality);
        }
        public Student(string _name, string _surname, string _patronymic, DateTime _dateOfBirth, DateTime _yearOfStudy, string _speciality)
        {
            name = _name;
            surname = _surname;
            patronymic = _patronymic;
            dateOfBirth = _dateOfBirth;
            yearOfStudy = _yearOfStudy;
            speciality = _speciality;
            Console.WriteLine("Вы ввели всё что нужно");
        }
        public Student(string _name, string _surname, DateTime _dateOfBirth, DateTime _yearOfStudy, string _speciality)
        {
            name = _name;
            surname = _surname;
            dateOfBirth = _dateOfBirth;
            yearOfStudy = _yearOfStudy;
            speciality = _speciality;
            Console.WriteLine("Вы ввели не всё ФИО");
        }
        public Student(string _surname, DateTime _dateOfBirth, DateTime _yearOfStudy, string _speciality)
        {
            surname = _surname;
            dateOfBirth = _dateOfBirth;
            yearOfStudy = _yearOfStudy;
            speciality = _speciality;
            Console.WriteLine("Вы ввели не всё ФИО");
        }
        public Student(DateTime _dateOfBirth, DateTime _yearOfStudy, string _speciality)
        {
            dateOfBirth = _dateOfBirth;
            yearOfStudy = _yearOfStudy;
            speciality = _speciality;
            Console.WriteLine("Вы не ввели ФИО");
        }
        public Student(string _name, string _surname, string _patronymic, DateTime _dateOfBirth, string _speciality)
        {
            name = _name;
            surname = _surname;
            patronymic = _patronymic;
            dateOfBirth = _dateOfBirth;
            speciality = _speciality;
            Console.WriteLine("Вы ввели не все даты");
        }
        public Student(string _name, string _surname, string _patronymic, DateTime _dateOfBirth, DateTime _yearOfStudy)
        {
            name = _name;
            surname = _surname;
            patronymic = _patronymic;
            dateOfBirth = _dateOfBirth;
            yearOfStudy = _yearOfStudy;
            Console.WriteLine("Вы не ввели специальность");
        }
        public Student()
        {
        }
    }
}
