namespace Pz_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 10 цифр, мы найдём самую большую из них и выведем все цифры в порядке возрастания:");
            char[] chars = new char[10];
            char maxNum = chars[0];
            for (byte i = 0; i < chars.Length; i++)
            {
                chars[i] = Convert.ToChar(Console.ReadLine());
                if (maxNum < chars[i])
                {
                    maxNum = chars[i];
                }
            }
            Console.WriteLine("Самая большая цифра:");
            Console.WriteLine(maxNum);
            Console.WriteLine("Все цифры в порядке возрастания:");
            Array.Sort(chars);
            for (byte j = 0; j < chars.Length; j++)
            {
                Console.WriteLine(chars[j]);
            }
        }
    }
}