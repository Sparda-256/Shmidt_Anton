namespace Pz_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[System.IO.File.ReadAllLines(@"C:\\input.txt").Length];
            for (int i = 0; i < System.IO.File.ReadAllLines(@"C:\\input.txt").Length; i++)
            {
                array[i] = Convert.ToInt32(System.IO.File.ReadAllLines(@"C:\Games\input.txt")[i]);
            }
            int c;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j+1])
                    {
                        c = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = c;
                    }
                }
            }
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            FileStream file = new FileStream(@"C:\\output.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(file);

            for (int i = 0; i < array.Length; i++)
            {
                writer.WriteLine(array[i]);
            }
            writer.Close();
        }
    }
}