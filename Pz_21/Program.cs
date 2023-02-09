
namespace Pz_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime Date = Convert.ToDateTime("09/02/2023");
            Student student = new Student();
            Console.Write("Имя: "); string A = student.name = Console.ReadLine();
            Console.Write("Фамилия: "); string B = student.surname = Console.ReadLine();
            Console.Write("Отчество: "); string C = student.patronymic = Console.ReadLine();
            Console.Write("Дата рождения: "); string D = student.dateOfBirth = Console.ReadLine();
            Console.Write("Год начала обучения: "); int E = student.yearOfStudy = Convert.ToInt32(Console.ReadLine());
            Console.Write("Специальность: "); string F = student.speciality = Console.ReadLine();
            
            student.PrintInfo(A, B, C, D, E, F);

            DateTime hirthday = new DateTime(2020, 10, 10);
            DateTime hirthday2 = new DateTime(E);
            Console.WriteLine(hirthday2.Year(hirthday));
            student.GetCourse() ;
        }
    }
}