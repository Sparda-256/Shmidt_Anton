using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Pz_23
{
    internal class GetAddress : Student
    {
        public DateOnly ReleaseDate { get; set; }
        public GetAddress(){}
        public GetAddress(string name, string surname, string patronymic, DateTime dateOfBirth, DateTime yearOfStudy, speciality_enum speciality, DateOnly ReleaseDate) : base(name, surname, patronymic, dateOfBirth, yearOfStudy, speciality)
        {
            this.ReleaseDate = ReleaseDate;
        }
        public GetAddress(string name, string surname, DateTime dateOfBirth, DateTime yearOfStudy, speciality_enum speciality, DateOnly ReleaseDate) : base(name, surname, dateOfBirth, yearOfStudy, speciality)
        {
            this.ReleaseDate = ReleaseDate;
        }
        public GetAddress(string surname, DateTime dateOfBirth, DateTime yearOfStudy, speciality_enum speciality, DateOnly ReleaseDate) : base(surname, dateOfBirth, yearOfStudy, speciality)
        {
            this.ReleaseDate = ReleaseDate;
        }
        public GetAddress(DateTime dateOfBirth, DateTime yearOfStudy, speciality_enum speciality, DateOnly ReleaseDate) : base(dateOfBirth, yearOfStudy, speciality)
        {
            this.ReleaseDate = ReleaseDate;
        }
        public GetAddress(string name, string surname, string patronymic, DateTime dateOfBirth, speciality_enum speciality, DateOnly ReleaseDate) : base(name, surname, patronymic, dateOfBirth, speciality)
        {
            this.ReleaseDate = ReleaseDate;
        }
        public GetAddress(string name, string surname, string patronymic, DateTime dateOfBirth, DateTime yearOfStudy, DateOnly ReleaseDate) : base(name, surname, patronymic, dateOfBirth, yearOfStudy)
        {
            this.ReleaseDate = ReleaseDate;
        }
        public override void PrintInfo()
        {
            Console.WriteLine("Имя: " + Name + " Фамилия: " + Surname + " Отчество: " + Patronymic + " Дата рождения: " + DateOfBirth + " Год начала обучения: " + YearOfStudy.Year + " Специальность: " + Speciality + " Дата выпуска: " + ReleaseDate);
        }
    }
}