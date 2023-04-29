namespace Pz_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte n;
            double x, y, f, t;
            Console.Write("Целое число n:");
            n = Convert.ToByte(Console.ReadLine());
            Console.Clear();
            Console.Write("Действительное число x:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            if (x < 0)
            {
                y = 18 * n / Math.Cos(x);
            }
            else
            {
                y = 4 * Math.Pow(x, 2) + 8 * n;
            }
            if (y > 5)
            {
                f = 30;
            }
            else
            {
                f = n * Math.Pow((3 * x - 5 * y), 0.5);
            }
            t = 100 * x + 20 * n * x * y;
            Console.WriteLine($"n = {n}\nx = {x}\ny = {y}\nf = {f}\nt = {t}");
        }
    }
}