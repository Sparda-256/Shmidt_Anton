namespace Pz_9_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();//Задание 1
            int[][] masiv = new int[3][];
            for (int i = 0; i < masiv.Length; i++)
            {
                masiv[i] = new int[random.Next(5, 11)];
            }
            Console.WriteLine("Случайно-сгенерированный ступенчатый массив:");//Задание 2
            for (int i = 0; i < masiv.Length; i++)
            {
                for (int j = 0; j < masiv[i].Length; j++)
                {
                    masiv[i][j] = random.Next(100);
                    Console.Write(masiv[i][j] + "\t");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("Последние элементы каждой строки массива:");//Задание 3
            int[] poslednie = new int[masiv.Length];
            for (int i = 0; i < masiv.Length; i++)
            {
                poslednie[i] = masiv[i][masiv[i].Length - 1];
            }
            for (int i = 0; i < poslednie.Length; i++)
            {
                Console.WriteLine(poslednie[i]);
            }
            Console.WriteLine("Максимальные элементы каждой строки массива:");//Задание 4
            int[] max = new int[masiv.Length];
            for (int i = 0; i < masiv.Length; i++)
            {
                for (int j = 0; j < masiv[i].Length; j++)
                {
                    if (masiv[i][j] > max[i])
                    {
                        max[i] = masiv[i][j];
                    }
                }
                Console.WriteLine(max[i]);
            }
            Console.WriteLine("Замена первого и максимального элемента массива:");//Задание 5
            for (int i = 0; i < masiv.Length; i++)
            {
                for (int j = 0; j < masiv[i].Length; j++)
                {
                    if (masiv[i][j] == max[i])
                    {
                        masiv[i][j] = masiv[i][0];
                    }
                }
            }
            for (int i = 0; i < masiv.Length; i++)
            {
                for (int j = 0; j < masiv[i].Length; j++)
                {
                    masiv[i][0] = max[i];
                }
            }
            for (int i = 0; i < masiv.Length; i++)
            {
                for (int j = 0; j < masiv[i].Length; j++)
                {
                    Console.Write(masiv[i][j] + "\t");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("Ревёрс каждой строки массива:");// Задание 6
            for (int i = 0; i < masiv.Length; i++)
            {
                Array.Reverse(masiv[i]);
            }
            for (int i = 0; i < masiv.Length; i++)
            {
                for (int j = 0; j < masiv[i].Length; j++)
                {
                    Console.Write(masiv[i][j] + "\t");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("Среднее значение в каждой строке массива:");//Задание 7
            float[] summa = new float[masiv.Length];
            for (int i = 0; i < masiv.Length; i++)
            {
                for (int j = 0; j < masiv[i].Length; j++)
                {
                    summa[i] += masiv[i][j];
                }
            }
            for (int i = 0; i < summa.Length; i++)
            {
                Console.WriteLine(i+1+")"+ summa[i] / masiv[i].Length);
            }
        }
    }
}