namespace Pz_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = System.IO.File.ReadAllLines(@"C:\Games\bf.txt").Length;
            string[] ewq = System.IO.File.ReadAllLines(@"C:\Games\bf.txt");
            for (int i = 0; i < count; i++)
            {
                if (ewq[i][0] == ewq[i][ewq[i].Length - 1])
                {
                    Console.WriteLine(ewq[i]);
                }
            }
        }
    }
}