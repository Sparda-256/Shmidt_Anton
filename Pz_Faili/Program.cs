using System.IO;
namespace Pz_Faili
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream file = new FileStream(@"C:\\text.txt", FileMode.Append);
            StreamWriter writer = new StreamWriter(file);
            Console.WriteLine("Введите данные:");
            string stroka = Console.ReadLine();
            writer.Write(stroka);
            while (stroka != "")
            {
                Console.WriteLine("Введите данные, ещё раз:");
                stroka = Console.ReadLine();
                writer.Write(stroka);
            }
            writer.Close();
            FileStream file1 = new FileStream(@"C:\\text.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file1);
            Console.WriteLine(reader.ReadToEnd());
            reader.Close();
        }
    }
}