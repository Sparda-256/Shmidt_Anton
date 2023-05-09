namespace Pz_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Антон", "Шмидт", "Геннадьевич", new DateTime(2005, 7, 18), new DateTime(2021, 9, 1), Student.speciality_enum.Программист);
            Student student2 = new Student("Антон", "Шмидт", "Геннадьевич", new DateTime(2005, 7, 18), new DateTime(2021, 9, 1), Student.speciality_enum.Дизайнер);
            Student student3 = new Student("Антон", "Шмидт", "Геннадьевич", new DateTime(2005, 7, 18), new DateTime(2021, 9, 1), Student.speciality_enum.Дизайнер);
            Student student4 = new Student("Антон", "Шмидт", "Геннадьевич", new DateTime(2005, 7, 18), new DateTime(2021, 9, 1), Student.speciality_enum.Банкир);
            Student.print_count();
        }
    }
}