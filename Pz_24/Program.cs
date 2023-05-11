namespace Pz_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Антон", "Шмидт", "Геннадьевич", new DateTime(2005, 7, 18), new DateTime(2021, 9, 1), Student.speciality_enum.Программист);
            Student student2 = (Student)student1.Clone();
            Student student3 = (Student)student2.Clone();
            student3.Name = "Сергей";
            student2.Name = "Никита";
            student1.PrintInfo();
            student2.PrintInfo();
            student3.PrintInfo();
        }
    }
}