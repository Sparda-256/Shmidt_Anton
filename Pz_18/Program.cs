namespace Pz_18
{
    internal class Program
    {
        enum Marks {плохо = 0, неудовлетворительно = 2, удовлетворительно = 3, хорошо = 4, отлично = 5}
        enum Seasons {Зима,зима, Весна, весна, Лето, лето, Осень, осень}
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер задания(1-2):");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input == 1)
                ocenki();
            else if (input == 2)
                Prazdniki();
        }
        public static void ocenki()
        {
            Console.WriteLine("Введите отметку:");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case (int)Marks.плохо:
                    Console.WriteLine("Характеристика отметки: " + Marks.плохо);
                    break;
                case (int)Marks.неудовлетворительно:
                    Console.WriteLine("Характеристика отметки: " + Marks.неудовлетворительно);
                    break;
                case (int)Marks.удовлетворительно:
                    Console.WriteLine("Характеристика отметки: " + Marks.удовлетворительно);
                    break;
                case (int)Marks.хорошо:
                    Console.WriteLine("Характеристика отметки: " + Marks.хорошо);
                    break;
                case (int)Marks.отлично:
                    Console.WriteLine("Характеристика отметки: " + Marks.отлично);
                    break;
            }
        }
        public static void Prazdniki()
        {
            Console.WriteLine("Введите время года и мы напишем вам основные государственные праздники:");
            string input = Console.ReadLine();
            Seasons season;
            if (Enum.TryParse(input, out season))
            {
                switch (season)
                {
                    case Seasons.Зима:
                        Console.WriteLine("01.01 Новый год\n07.01 Рождество Христово\n23.02 День защитника Отечества\n08.03 Международный женский день");
                        break;
                    case Seasons.зима:
                        Console.WriteLine("01.01 Новый год\n07.01 Рождество Христово\n23.02 День защитника Отечества\n08.03 Международный женский день");
                        break;
                    case Seasons.Весна:
                        Console.WriteLine("01.05 Праздник Весны и Труда\n09.05 День Победы\n12.06 День России");
                        break;
                    case Seasons.весна:
                        Console.WriteLine("01.05 Праздник Весны и Труда\n09.05 День Победы\n12.06 День России");
                        break;
                    case Seasons.Лето:
                        Console.WriteLine("01.06 Международный день защиты детей\n11.06 День пивовара\n12.06 День России\n10.07 День рыбака\n19.07 День пирожков с малиновым вареньем");
                        break;
                    case Seasons.лето:
                        Console.WriteLine("01.06 Международный день защиты детей\n11.06 День пивовара\n12.06 День России\n10.07 День рыбака\n19.07 День пирожков с малиновым вареньем");
                        break;
                    case Seasons.Осень:
                        Console.WriteLine("01.09 День знаний\n12.10 День работников сельского хозяйства и перерабатывающей промышленности\n07.11 День Октябрьской революции");
                        break;
                    case Seasons.осень:
                        Console.WriteLine("01.09 День знаний\n12.10 День работников сельского хозяйства и перерабатывающей промышленности\n07.11 День Октябрьской революции");
                        break;
                }
            }
            else
                Console.WriteLine("Некорректный ввод");
        }
    }
}