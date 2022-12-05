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
            for (byte j = 0; j < 10; j++)
            {
                for (byte k = 0; k < massiv[j].Length; k++)
                {
                    massiv[j][k] = Convert.ToByte(random.Next(100));
                }
            }
            for (byte j = 0; j < massiv.Length; j++)
            {
                for (byte k = 0; k < massiv[j].Length; k++)
                {
                    Console.Write(massiv[j][k] + "\t");
                }
                Console.WriteLine();
            }
            byte[] poslednie = new byte [massiv.Length];//Задание 3
            Console.WriteLine("Последние элементы каждой строки:");
            for (int i = 0; i < massiv.Length; i++)
            {
                poslednie[i] = massiv[i][massiv[i].Length - 1];
                Console.WriteLine(massiv[i][massiv[i].Length - 1]);
            }
            byte[] maxnummer = new byte [10];//Задание 4
            for (byte i = 0; i < massiv.Length; i++)
            {
                for (int j = 0; j < massiv[i].Length; j++)
                {
                    if (maxnummer[i] < massiv[i][j])
                    {
                        maxnummer[i]= massiv[i][j];
                    }
                }
            }
            Console.WriteLine("Максимальный элемент каждой строки:");
            foreach (byte item in maxnummer)
            {
                Console.WriteLine(item);
            }
            for (byte j = 0; j < massiv.Length; j++)//Задание 5
            {
                for (byte k = 0; k < massiv[j].Length; k++)
                {
                    Console.Write(massiv[j][k] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
