namespace Pz_17_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                Console.Write("Введите строку: ");
                string input = Console.ReadLine();

                fixed (char* pInput = input)
                {
                    int count = 0;
                    for (char* pChar = pInput; *pChar != '\0'; pChar++)
                    {
                        if (*pChar == ' ')
                        {
                            count++;
                        }
                    }
                    Console.WriteLine($"Количество пробелов в строке: {count}");
                }
            }
        }
    }
}