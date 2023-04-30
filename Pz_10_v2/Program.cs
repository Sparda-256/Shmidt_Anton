namespace Pz_10_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите путь к файлу:");
            bool proverka = false;
            string Userinput = Console.ReadLine();
            while (proverka != true)
            {
                if (Userinput[0] != 'C' && Userinput[0] != 'D' || Userinput[1] != ':' || Userinput[2] != '/')
                {
                    Console.WriteLine("Вы ввели некорректный путь, попробуйте снова:");
                    Userinput = Console.ReadLine();
                }
                else
                {
                    proverka = true;
                }
            }
            Console.WriteLine("Каталоги:");
            Userinput = Userinput.Remove(0, 3);
            string[] textArray = Userinput.Split('/');
            for (int i = 0; i < textArray.Length - 1; i++)
            {
                Console.WriteLine(textArray[i]);
            }
        }
    }
}