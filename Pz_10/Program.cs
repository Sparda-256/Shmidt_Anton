namespace Pz_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stroka = "";
            int a = 1;
            int count = 0;
            Console.WriteLine("Пока строка не начинается с '_' вы можете бесконечно их вводить\nМы выведем последнюю строку столько раз сколько всего вы ввели строк:");
            while (a != 0)
            {
                stroka = Console.ReadLine();
                a = Convert.ToInt32(stroka.IndexOf("_"));
                count += 1;
            }
            Console.WriteLine("Вывод:");
            for (int i = 0; i < count; i++)
                Console.WriteLine(stroka);
        }
    }
}