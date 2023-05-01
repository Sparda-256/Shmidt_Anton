namespace Pz_12_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 5 чисел, мы найдём их 2, 3 и 4 степень:");
            int[] masiv = new int[5];
            for (int i = 0; i < masiv.Length; i++)
            {
                masiv[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Результат:");
            for (int i = 0; i < masiv.Length; i++)
            {
                Console.WriteLine(PowerA234(masiv[i]));
            }
        }
        public static (int B, int C, int D) PowerA234(int A)
        {
            int B, C, D;
            B = Convert.ToInt32(Math.Pow(A, 2));
            C = Convert.ToInt32(Math.Pow(A, 3));
            D = Convert.ToInt32(Math.Pow(A, 4));
            return (B, C, D);
        }
    }
}