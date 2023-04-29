using System.Xml;

namespace Pz_7_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] masiv = new int [20];
            Random random = new Random();
            int max = 0;
            for (int i = 0; i < masiv.Length; i++)
            {
                masiv[i] = random.Next(-15, 15);
                Console.WriteLine(masiv[i]);
            }
            for (int i = 0; i < masiv.Length; i++)
            {
                if (masiv[i]>max)
                {
                    max = masiv[i];
                }
            }
            int count = 0;
            for (int i = 0; i < masiv.Length; i++)
            {
                if (masiv[i] < 0)
                {
                    if (Math.Abs(masiv[i]) > max)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("Максимальный элемент: " + max);
            Console.WriteLine("Количество элементов по модулю больших, чем максимальный: " + count);
        }
    }
}