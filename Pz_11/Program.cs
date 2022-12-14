namespace Pz_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] textArray = text.Split();
            Console.WriteLine("Количество слов в тексте:");
            Console.WriteLine(textArray.Length);
            string a = "";
            Console.WriteLine("Все слова текста в порядке убывания:");
            for (int j = 0; j < textArray.Length; j++)
            {
                for (int i = 0; i < textArray.Length - 1; i++)
                {
                    if (textArray[i].Length < textArray[i + 1].Length)
                    {
                        a = textArray[i];
                        textArray[i] = textArray[i + 1];
                        textArray[i + 1] = a;
                    }
                }
            }
            foreach (string item in textArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}