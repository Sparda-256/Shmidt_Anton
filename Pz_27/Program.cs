namespace Pz_27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NOTE[] BLOCKNOTE = new NOTE[8];
            Console.WriteLine("Введите данные 8 людей (В формате: Имя, Телефон, Дата Рождения(День, Месяц, Год):");
            Console.WriteLine("Человек 1:");
            BLOCKNOTE[0] = new NOTE() { name = Console.ReadLine(), tele = Console.ReadLine(), bday = new int[] { Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()) } };
            Console.Clear();
            Console.WriteLine("Человек 2:");
            BLOCKNOTE[1] = new NOTE() { name = Console.ReadLine(), tele = Console.ReadLine(), bday = new int[] { Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()) } };
            Console.Clear();
            Console.WriteLine("Человек 3:");
            BLOCKNOTE[2] = new NOTE() { name = Console.ReadLine(), tele = Console.ReadLine(), bday = new int[] { Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()) } };
            Console.Clear();
            Console.WriteLine("Человек 4:");
            BLOCKNOTE[3] = new NOTE() { name = Console.ReadLine(), tele = Console.ReadLine(), bday = new int[] { Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()) } };
            Console.Clear();
            Console.WriteLine("Человек 5:");
            BLOCKNOTE[4] = new NOTE() { name = Console.ReadLine(), tele = Console.ReadLine(), bday = new int[] { Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()) } };
            Console.Clear();
            Console.WriteLine("Человек 6:");
            BLOCKNOTE[5] = new NOTE() { name = Console.ReadLine(), tele = Console.ReadLine(), bday = new int[] { Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()) } };
            Console.Clear();
            Console.WriteLine("Человек 7:");
            BLOCKNOTE[6] = new NOTE() { name = Console.ReadLine(), tele = Console.ReadLine(), bday = new int[] { Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()) } };
            Console.Clear();
            Console.WriteLine("Человек 8:");
            BLOCKNOTE[7] = new NOTE() { name = Console.ReadLine(), tele = Console.ReadLine(), bday = new int[] { Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()) } };
            Console.Clear();
            Console.WriteLine("Теперь введите число от 1 до 12:");
            int input = 0;
            try
            {
                input = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.Clear();
                Console.WriteLine("Некорректный формат!");
                Environment.Exit(0);
            }
            Console.Clear();
            int count = 0;
            Console.WriteLine("Вот все люди месяц рождения которых = введённому числу:");
            for (int i = 0; i < BLOCKNOTE.Length; i++)
            {
                if (BLOCKNOTE[i].bday[1] == input)
                {
                    count++;
                    BLOCKNOTE[i].PrintNote();
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Таких людей нет!");
            }
        }
    }
}