namespace Pz_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetAddress getAddress1 = new GetAddress("Антон", "Шмидт", "Геннадьевич", new DateTime(2005, 7, 18), new DateTime(2021, 9, 1), Student.speciality_enum.Банкир, new DateOnly(2024, 6, 30));
            getAddress1.PrintInfo();
            GetAddress getAddress2 = new GetAddress("Антон", "Шмидт", new DateTime(2005, 7, 18), new DateTime(2021, 9, 1), Student.speciality_enum.Банкир, new DateOnly(2024, 6, 30));
            getAddress2.PrintInfo();
            GetAddress getAddress3 = new GetAddress("Шмидт", new DateTime(2005, 7, 18), new DateTime(2021, 9, 1), Student.speciality_enum.Банкир, new DateOnly(2024, 6, 30));
            getAddress3.PrintInfo();
            GetAddress getAddress4 = new GetAddress("Антон", "Шмидт", "Геннадьевич", new DateTime(2005, 7, 18), Student.speciality_enum.Банкир, new DateOnly(2024, 6, 30));
            getAddress4.PrintInfo();
            GetAddress getAddress5 = new GetAddress("Антон", "Шмидт", "Геннадьевич", new DateTime(2005, 7, 18), new DateTime(2021, 9, 1), new DateOnly(2024, 6, 30));
            getAddress5.PrintInfo();
        }
    }
}