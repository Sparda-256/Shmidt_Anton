using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pz_22
{
    internal class Student
    {
        string name;
        public string Name
        {
            get {return name;}
            set
            {
                if (value != null)
                    name = value;
            }
        }
        string surname;
        public string Surname
        {
            get { return surname; }
            set
            {
                if (value != null)
                    surname = value;
            }
        }
        string patronymic;
        public string Patronymic
        {
            get { return patronymic; }
            set
            {
                if (value != null)
                    patronymic = value;
            }
        }
        DateTime dateOfBirth;
        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set
            {
                    dateOfBirth = value;
            }
        }
        DateTime yearOfStudy;
        public DateTime YearOfStudy
        {
            get { return yearOfStudy; }
            set
            {
                if (DateTime.Now.Year - value.Year <= 4)
                    yearOfStudy = value;
            }
        }
        internal enum speciality_enum{Программист, Дизайнер, Банкир}
        speciality_enum speciality;
        static int[] count = new int[Enum.GetNames(typeof(speciality_enum)).Length];
        public speciality_enum Speciality
        {
            get { return speciality; }
            set
            {
                if (speciality == value){}
                else if (value == speciality_enum.Программист)
                {
                    if (speciality == speciality_enum.Дизайнер)
                        count[1]--;
                    else if (speciality == speciality_enum.Банкир)
                        count[2]--;
                    speciality = value;
                    count[0]++;
                }
                else if (value == speciality_enum.Дизайнер)
                {
                    if (speciality == speciality_enum.Программист)
                        count[0]--;
                    else if (speciality == speciality_enum.Банкир)
                        count[2]--;
                    speciality = value;
                    count[1]++;
                }
                else if (value == speciality_enum.Банкир)
                {
                    if (speciality == speciality_enum.Программист)
                        count[0]--;
                    else if (speciality == speciality_enum.Дизайнер)
                        count[1]--;
                    speciality = value;
                    count[2]++;
                }
            }
        }
        public int[] Count
        {
            get
            {
                return count;
            }
        }
        public static void print_count()
        {
            Console.WriteLine("Программистов: " + count[0] + "\nДизайнеров: " + count[1] +  "\nБанкиров: " + count[2]);
        }
        public int GetCourse()
        {
            if (yearOfStudy.Year != 1)
            {
                if (DateTime.Now.Year - yearOfStudy.Year > 4)
                {
                    Console.WriteLine("Курс некорректен");
                    return 0;
                }
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
        public Student(string _name, string _surname, string _patronymic, DateTime _dateOfBirth, DateTime _yearOfStudy, speciality_enum _speciality)
        {
            name = _name;
            surname = _surname;
            patronymic = _patronymic;
            dateOfBirth = _dateOfBirth;
            yearOfStudy = _yearOfStudy;
            speciality = _speciality;
            if (_speciality == speciality_enum.Программист)
                count[0]++;
            if (_speciality == speciality_enum.Дизайнер)
                count[1]++;
            if (_speciality == speciality_enum.Банкир)
                count[2]++;
            Console.WriteLine("Вы ввели всё что нужно");
        }
        public Student(string _name, string _surname, DateTime _dateOfBirth, DateTime _yearOfStudy, speciality_enum _speciality)
        {
            name = _name;
            surname = _surname;
            dateOfBirth = _dateOfBirth;
            yearOfStudy = _yearOfStudy;
            speciality = _speciality;
            if (_speciality == speciality_enum.Программист)
                count[0]++;
            if (_speciality == speciality_enum.Дизайнер)
                count[1]++;
            if (_speciality == speciality_enum.Банкир)
                count[2]++;
            Console.WriteLine("Вы ввели не всё ФИО");
        }
        public Student(string _surname, DateTime _dateOfBirth, DateTime _yearOfStudy, speciality_enum _speciality)
        {
            surname = _surname;
            dateOfBirth = _dateOfBirth;
            yearOfStudy = _yearOfStudy;
            speciality = _speciality;
            if (_speciality == speciality_enum.Программист)
                count[0]++;
            if (_speciality == speciality_enum.Дизайнер)
                count[1]++;
            if (_speciality == speciality_enum.Банкир)
                count[2]++;
            Console.WriteLine("Вы ввели не всё ФИО");
        }
        public Student(DateTime _dateOfBirth, DateTime _yearOfStudy, speciality_enum _speciality)
        {
            dateOfBirth = _dateOfBirth;
            yearOfStudy = _yearOfStudy;
            speciality = _speciality;
            if (_speciality == speciality_enum.Программист)
                count[0]++;
            if (_speciality == speciality_enum.Дизайнер)
                count[1]++;
            if (_speciality == speciality_enum.Банкир)
                count[2]++;
            Console.WriteLine("Вы не ввели ФИО");
        }
        public Student(string _name, string _surname, string _patronymic, DateTime _dateOfBirth, speciality_enum _speciality)
        {
            name = _name;
            surname = _surname;
            patronymic = _patronymic;
            dateOfBirth = _dateOfBirth;
            speciality = _speciality;
            if (_speciality == speciality_enum.Программист)
                count[0]++;
            if (_speciality == speciality_enum.Дизайнер)
                count[1]++;
            if (_speciality == speciality_enum.Банкир)
                count[2]++;
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
            count[0]++;
        }
    }
}