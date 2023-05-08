using System.Text.RegularExpressions;
namespace Pz_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер задания(1-2):");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input == 1)
            {
                Console.Clear();
                string text = "1 RU161109-472905 PACK19697671 1 Ольга Каверзина +7 (918) 335-43-52 Наличные Плюс 009:00 - 13:00 Краснодар, красина, Дом 3/3, Кв. 76/2 RU161110-466130 PACK19651968 1 Софья назаретян +7 (918) 398-07-81 Наличные Плюс 0\r\n09:00 - 13:00 Краснодар, Базовская, Дом д.61\r\n3 RU161111-260536 PACK19698066 3 Виктор Кипуров +7 (918) 441-97-56 Наличные Плюс 0\r\n09:00 - 13:00 Краснодар, Речная,Чехова , Дом 4, Кв. 52\r\n4 RU161111-522664 PACK19697905 2 Ирина Концевик +7 (918) 045-77-00 Наличные Плюс 0\r\n09:00 - 13:00 Краснодар, ул им Братьев Дроздовых, Дом 41, Кв. 19\r\n5 RU161111-252357 PACK19697840 1 Ирина Концевик +7 (918) 045-77-00 Наличные Плюс 0\r\n09:00 - 13:00 Краснодар, ул им Братьев Дроздовых, Дом 41, Кв. 19\r\n6 RU161104-298585 PACK19514804 3 Роман Иванов +7 (938) 435-93-29 Наличные Плюс 0 09:00 - 13:00\r\nКраснодар, фурманова, Дом 62 9.11";
                Regex regex = new Regex(@"\d\s(\w*?\s\w*?)\s\+7");
                Match match = regex.Match(text);
                string[] strings = new string[6];
                int count = 0;
                while (match.Success)
                {
                    strings[count] = match.Groups[1].ToString();
                    Console.WriteLine(strings[count]);
                    match = match.NextMatch();
                    count++;
                }
            }
            else if (input == 2)
            {
                Console.Clear();
                FileStream file = new FileStream(@"D:\\Games\connects.log", FileMode.Open ,FileAccess.Read);
                StreamReader sr = new StreamReader(file);
                string text2 = sr.ReadToEnd();
                string pattern1 = @"(\d*?\.\d*?\.\d*?\.\d*?)\s-\s-\s\[";
                Regex regex1 = new Regex(pattern1);
                Match match1 = regex1.Match(text2);
                Console.WriteLine("a)");
                while (match1.Success)
                {
                    Console.WriteLine(match1.Groups[1].Value);
                    match1 = match1.NextMatch();
                }
                string pattern2 = @"\[(.*?)\s\+";
                Regex regex2 = new Regex(pattern2);
                Match match2 = regex2.Match(text2);
                Console.WriteLine("b)");
                while (match2.Success)
                {
                    Console.WriteLine(match2.Groups[1].Value);
                    match2 = match2.NextMatch();
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Выввели неверное значение");
            }
        }
    }
}