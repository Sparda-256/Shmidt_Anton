namespace Pz_8_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            float[,] nums = new float[3,5];
            float min = 0.0f;
            float summ = 0.0f;
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    nums[i, j] = random.Next(-20, 21);
                }
            }
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    if (nums[i, j] < min)
                    {
                        min = nums[i, j];
                    }
                }
            }
            foreach (float item in nums)
            {
                if (item > 0)
                {
                    summ += item;
                }
            }
            Console.WriteLine("Произведение минимального элемента матрицы вещественных чисел" +
                "на сумму её положительных элементов: " + min * summ);
        }
    }
}