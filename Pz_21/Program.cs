namespace Pz_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Антон", "Шмидт", "Геннадьевич", new DateTime(2005, 7, 18), new DateTime(2021, 9, 1), "Программист");
            Student student2 = new Student("Антон", "Шмидт", new DateTime(2005, 7, 18), new DateTime(2021, 9, 1), "Программист");
            Student student3 = new Student("Шмидт", new DateTime(2005, 7, 18), new DateTime(2021, 9, 1), "Программист");
            Student student4 = new Student(new DateTime(2005, 7, 18), new DateTime(2021, 9, 1), "Программист");
            Student student5 = new Student("Антон", "Шмидт", "Геннадьевич", new DateTime(2005, 7, 18), "Программист");
            Student student6 = new Student("Антон", "Шмидт", "Геннадьевич", new DateTime(2005, 7, 18), new DateTime(2021, 9, 1));
            student1.PrintInfo();
            Console.WriteLine("Курс: " + student1.GetCourse());
            student2.PrintInfo();
            Console.WriteLine("Курс: " + student2.GetCourse());
            student3.PrintInfo();
            Console.WriteLine("Курс: " + student3.GetCourse());
            student4.PrintInfo();
            Console.WriteLine("Курс: " + student4.GetCourse());
            student5.PrintInfo();
            Console.WriteLine("Курс: " + student5.GetCourse());
            student6.PrintInfo();
            Console.WriteLine("Курс: " + student6.GetCourse());
        }
    }
}