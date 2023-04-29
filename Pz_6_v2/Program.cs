namespace Pz_6_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float v, g, t;
            t = 0;
            g = 9.8f;
            v = 0;
            while (v < 1000)
            {
                v = g * t;
                Console.WriteLine(v);
                t += 0.5f;
            }
        }
    }
}