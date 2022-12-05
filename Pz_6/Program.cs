namespace Pz_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int end = 4;
            double counter = 1;
            while (counter <= end)
            {
                Console.WriteLine(counter + 3 * Math.Pow(counter, 2) - 2.5 * Math.Pow(counter, 3) + 0.75 * Math.Pow(counter, 4));
                counter += 0.5;
            }
        }
    }
}