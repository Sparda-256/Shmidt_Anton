namespace Pz_13
{
    internal class Program
    {
        static int Metod(int[] a, byte count)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
                if (Math.Pow(a[i], 1d / 3d) % 1 == 0)
                {
                    count++;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество чисел:");
            int[] massiv = new int[Convert.ToInt32(Console.ReadLine())];
            Console.WriteLine("Введите числа:");
            Console.WriteLine("Количество чисел из которых можно извлечь кубический корень:\n"+Metod(massiv, 0));
        }
    }
}