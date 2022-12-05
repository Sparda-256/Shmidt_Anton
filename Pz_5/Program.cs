using System;

namespace Pz_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер задания (1-5): ");
            int task = Convert.ToInt32(Console.ReadLine());

            switch (task)
            {
                case 1:
                    for (int i = 0; i < 16; i++)
                    {
                        Console.WriteLine(i);
                    }
                    break;
                case 2:
                    for (char bukva = 'о'; bukva != 'я'; bukva++)
                    {
                        Console.Write(bukva);
                    }
                    Console.WriteLine('я');
                    break;
                case 3:
                    for (int m = 0; m < 10; ++m)
                    {
                        for (int n = 0; n < 5; ++n)
                        {
                            Console.Write('#');
                        }
                        Console.Write('\n');
                    }
                    break;
                case 4:
                    for (int i = 0; i <= 100; ++i)
                    {
                        if (i % 16 == 0)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    break;
                case 5:
                    for (int i = 0, j = 30; j - i >= 8; ++i, --j)
                    {
                        Console.WriteLine($"i = {i},\tj = {j}");
                    }
                    break;
                default:
                    Console.WriteLine("Неверное значение! Пробуйте снова");
                    break;
            }
        }
    }
}