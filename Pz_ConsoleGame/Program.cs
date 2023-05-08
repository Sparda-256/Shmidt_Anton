using System;

namespace Pz_ConsoleGame
{
    internal class Program
    {
        static int PlayerHp = 30;
        static int Enemys = 10;
        static int EnemyHp = 15;
        static int PlayerHitpower = 5;
        static int EnemyHitpower = 5;
        static int PlayerX = 4;
        static int PlayerY = 12;
        static int shagi = 0;
        static bool game = true;
        static void Main(string[] args)
        {
            Console.WriteLine("Обучение!\n■ - Вы\n♦ - Враг\n♥ - Аптечка\n▲ - Усилитель удара");
            ConsoleKeyInfo keyesc1 = Console.ReadKey(true);
            if (keyesc1.Key == ConsoleKey.Escape)
            {
                Console.Clear();
                Console.Write("Игра завершена");
                Environment.Exit(0);
            }
            Console.Clear();
            GenerateMap();
        }
        public static void GenerateMap() //генерация карты
        {
            string[,] array = new string[9, 25];// Заполнение карты 
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                    array[i, j] = " ";
            }
            Random random = new Random();
            array[4, 12] = "■"; // Добавление Игрока
            int x, y;
            int count = 10; // Добавление Врагов
            for (int i = 0; i < count; i++) 
            {
                x = random.Next(9);
                y = random.Next(25);
                if (array[x,y] == " ")
                    array[x, y] = "♦";
                else
                    count++;
            }
            count = 5; // Добавление Аптечек
            for (int i = 0; i < count; i++)
            {
                x = random.Next(9);
                y = random.Next(25);
                if (array[x, y] == " ")
                    array[x, y] = "♥";
                else
                    count++;
            }
            count = 3; // Добавление Баффов
            for (int i = 0; i < count; i++)
            {
                x = random.Next(9);
                y = random.Next(25);
                if (array[x, y] == " ")
                    array[x, y] = "▲";
                else
                    count++;
            }
            for (int i = 0; i < array.GetLength(0); i++) // Вывод карты на консоль
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i,j]);
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("Ваше здоровье:" + PlayerHp);
            Console.WriteLine("Ваша сила удара:" + PlayerHitpower);
            Console.WriteLine("Осталось противников:" + Enemys);
            while (game)
            {
                Move(array);
                Console.Clear();
                for (int i = 0; i < array.GetLength(0); i++) // Вывод карты на консоль
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i, j]);
                    }
                    Console.WriteLine("\n");
                }
                Console.WriteLine("Ваше здоровье:" + PlayerHp);
                Console.WriteLine("Ваша сила удара:" + PlayerHitpower);
                Console.WriteLine("Осталось противников:" + Enemys);
            }
        }
        public static void Move(string[,] strings)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);

            if (keyInfo.Key == ConsoleKey.UpArrow)
            {
                strings[PlayerX, PlayerY] = " ";
                if (PlayerX !=0)
                {
                    PlayerX--;
                }
                Proverka(strings);
                strings[PlayerX, PlayerY] = "■";
                shagi++;
            }
            else if(keyInfo.Key == ConsoleKey.DownArrow)
            {
                strings[PlayerX, PlayerY] = " ";
                if (PlayerX != strings.GetLength(0)-1)
                {
                    PlayerX++;
                }
                Proverka(strings);
                strings[PlayerX, PlayerY] = "■";
                shagi++;
            }
            else if (keyInfo.Key == ConsoleKey.RightArrow)
            {
                strings[PlayerX, PlayerY] = " ";
                if (PlayerY != strings.GetLength(1) - 1)
                {
                    PlayerY++;
                }
                Proverka(strings);
                strings[PlayerX, PlayerY] = "■";
                shagi++;
            }
            else if (keyInfo.Key == ConsoleKey.LeftArrow)
            {
                strings[PlayerX, PlayerY] = " ";
                if (PlayerY != 0)
                {
                    PlayerY--;
                }
                Proverka(strings);
                strings[PlayerX, PlayerY] = "■";
                shagi++;
            }
            else if (keyInfo.Key == ConsoleKey.Escape)
            {
                FileStream file = new FileStream(@"D:\Игры\Game.txt", FileMode.Append);
                StreamWriter writer = new StreamWriter(file);
                Console.Clear();
                Console.WriteLine("Игра завершена и записана в файл");
                for (int i = 0; i < strings.GetLength(0); i++) // Вывод карты в файл
                {
                    for (int j = 0; j < strings.GetLength(1); j++)
                    {
                        writer.Write(strings[i, j]);
                    }
                    writer.WriteLine("\n");
                }
                writer.WriteLine("Ваше здоровье: " + PlayerHp+ "\nКоличество шагов:" + shagi);
                writer.Close();
                Environment.Exit(0);
            }
        }
        public static void Healing()
        {
            PlayerHp = 30;
        }
        public static void Buff()
        {
            PlayerHitpower *= 2;
        }
        public static void Proverka(string[,] strings1)
        {
            if (strings1[PlayerX, PlayerY] == "▲")
            {
                Buff();
            }
            else if (strings1[PlayerX, PlayerY] == "♥")
            {
                Healing();
            }
            else if (strings1[PlayerX, PlayerY] == "♦")
            {
                Fight();
            }
        }
        public static void Fight()
        {
            while (EnemyHp > 0)
            {
                Console.Clear();
                Console.WriteLine("Здоровье врага: " + EnemyHp);
                Console.WriteLine("Ваше здоровье: " + PlayerHp);
                ConsoleKeyInfo keyesc = Console.ReadKey(true);
                if (keyesc.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    Console.WriteLine("Игра завершена и записана в файл");
                    Environment.Exit(0);
                }
                    Console.Clear();
                Console.WriteLine("Враг нанёс вам: " + EnemyHitpower + " урона");
                PlayerHp -= EnemyHitpower;
                if (PlayerHp <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("Враг вас убил!(\nКоличество шагов:" + shagi);
                    Environment.Exit(0);
                }
                Console.WriteLine("Вы нанесли врагу: " + PlayerHitpower + " урона");
                EnemyHp -= PlayerHitpower;
                Console.ReadKey();
            }
            EnemyHp = 15;
            Enemys--;
            if (Enemys == 0)
            {
                Console.Clear();
                Console.WriteLine("Победа!\nКоличество шагов:" + shagi);
                Environment.Exit(0);
            }
        }
    }
}