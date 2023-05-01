namespace Pz_11_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] textArray = text.Split('.', '?', '!');
            for (int i = 0; i < textArray.Length; i++)
            {
                textArray[i] = textArray[i].Trim();
            }
            string[][] sort = new string[textArray.Length][];
            for (int i = 0; i < textArray.Length; i++)
            {
                sort[i] = textArray[i].Split();
            }
            for (int i = 0; i < sort.Length - 1; i++)
            {
                for (int j = i + 1; j < sort.Length; j++)
                {
                    if (sort[i].Length < sort[j].Length)
                    {
                        string[] temp = sort[i];
                        sort[i] = sort[j];
                        sort[j] = temp;
                    }
                }
            }
            for (int i = 0; i < sort.Length; i++)
            {
                for (int j = 0; j < sort[i].Length; j++)
                {
                    Console.Write(sort[i][j] + " ");
                }
                Console.WriteLine("\n");
            }
        }
    }
}