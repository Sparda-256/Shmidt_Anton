namespace Pz_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stroka = "";
            int a = 1;
            int b = 0;
            while (a != 0)
            {
                stroka = Console.ReadLine();
                a = Convert.ToInt32(stroka.IndexOf("_"));
                b += 1;
            }
            Console.WriteLine("Вывод:");
            for (int i = 0; i < b; i++)
            {
                Console.WriteLine(stroka);
            }
        }
    }
}