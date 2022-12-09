namespace Pz_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            byte[][] massiv = new byte[10][];
            for (byte i = 0; i < massiv.Length; i++)
            {
                massiv[i] = new byte[random.Next(3, 30)];
            }
            for (byte j = 0; j < massiv.Length; j++)
            {
                for (byte k = 0; k < massiv[j].Length; k++)
                {
                    massiv[j][k] = Convert.ToByte(random.Next(100));
                }
            }
            Console.WriteLine("Случайно-сгенерированный ступенчатый массив:");
            for (byte o = 0; o < massiv.Length; o++)
            {
                for (byte k = 0; k < massiv[o].Length; k++)
                {
                    Console.Write(massiv[o][k] + "\t");
                }
                Console.WriteLine();
            }
            byte[] poslednie = new byte[massiv.Length];//Задание 3
            Console.WriteLine("Последние элементы каждой строки массива:");
            for (int i = 0; i < massiv.Length; i++)
            {
                poslednie[i] = massiv[i][massiv[i].Length - 1];
                Console.WriteLine(massiv[i][massiv[i].Length - 1]);
            }
            byte[] maxnummer = new byte[10];//Задание 4
            for (byte i = 0; i < massiv.Length; i++)
            {
                for (int j = 0; j < massiv[i].Length; j++)
                {
                    if (maxnummer[i] < massiv[i][j])
                    {
                        maxnummer[i] = massiv[i][j];
                    }
                }
            }
            Console.WriteLine("Максимальный элемент каждой строки массива:");
            foreach (byte item in maxnummer)
            {
                Console.WriteLine(item);
            }
            byte[] maxnummer2 = maxnummer;//Задание 5
            for (int j = 0; j < massiv.Length; j++)
            {
                for (int k = 0; k < massiv[j].Length; k++)
                {
                    if (massiv[j][k] == maxnummer[j])
                    {
                        massiv[j][k] = massiv[j][0];
                    }
                }
            }
            for (byte j = 0; j < massiv.Length; j++)
            {
                massiv[j][0] = maxnummer2[j];
            }
            Console.WriteLine("Замена первого и максимального элемента массива:");
            for (byte o = 0; o < massiv.Length; o++)
            {
                for (byte k = 0; k < massiv[o].Length; k++)
                {
                    Console.Write(massiv[o][k] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Ревёрс каждой строки массива:");//Задание 6
            for (int o = 0; o < massiv.Length; o++)
            {
                for (int k = massiv[o].Length - 1; k >= 0; k--)
                {
                    Console.Write(massiv[o][k] + "\t");
                }
                Console.WriteLine();
            }
            double[] sredneeznachenie = new double[10];//Задание 7
            double[] summa = new double[10];
            for (byte i = 0; i < massiv.Length; i++)
            {
                for (byte k = 0; k < massiv[i].Length; k++)
                summa[i] += Convert.ToDouble(massiv[i][k]);
            }
            for (byte i = 0; i < massiv.Length; i++)
                sredneeznachenie[i] = Convert.ToDouble(summa[i] / massiv[i].Length);
            Console.WriteLine("Среднее значение в каждой строке массива:");
            for (byte i = 0; i < massiv.Length; i++)
                Console.WriteLine(Convert.ToDouble(sredneeznachenie[i]));
        }
    }
}
