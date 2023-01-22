namespace Животное
{
    internal class Klinika
    {
        public string typeofanimal = "cat"; //тип животного
        public string name = "Marusya"; //кличка
        public string hozain = "Anton"; //хозяин
        public string problems = "pain"; //жалобы

        internal void information()
        {
            Console.WriteLine($"Тип животного {typeofanimal}\n"
                + $"Кличка {name}\n"
                + $"Хозяин {hozain}\n"
                + $"Жалобы {problems}\n");
        }
    }
}