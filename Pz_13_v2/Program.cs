namespace Pz_13_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите периметр комнаты в метрах:");
            int per = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите высоту стен в метрах:");
            int steni = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Необходимо рулонов обоев по 1мх10м:");
            Console.WriteLine(oboi(per, steni));
        }
        public static int oboi(int perimetr, int visota)
        {
            int rulonov = (perimetr*visota*4)/10;
            return rulonov;
        }
    }
}