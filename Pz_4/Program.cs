namespace Pz_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Узнать количество дней в месяце");
            Console.Write("Введите год:");
            int god = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите номер месяца:");
            int m = Convert.ToInt32(Console.ReadLine());
            if (m > 12 || m <= 0 || god < 0)
            {
                Console.WriteLine("Вы ввели некорректные данные, мы даём вам второй шанс, третьего не будет!!!:");
                Console.Write("Введите год:");
                god = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите номер месяца:");
                m = Convert.ToInt32(Console.ReadLine());
                bool vysokos = god % 4 == 0 && god % 100 != 0 || god % 400 == 0;
                switch (m)
                {
                    case 1:
                        Console.WriteLine(31);
                        break;
                    case 2:
                        switch (vysokos)
                        {
                            case true: //високосный
                                Console.WriteLine(29);
                                break;
                            case false: //не високосный
                                Console.WriteLine(28);
                                break;
                        }
                        break;
                    case 3:
                        Console.WriteLine(31);
                        break;
                    case 4:
                        Console.WriteLine(30);
                        break;
                    case 5:
                        Console.WriteLine(31);
                        break;
                    case 6:
                        Console.WriteLine(30);
                        break;
                    case 7:
                        Console.WriteLine(31);
                        break;
                    case 8:
                        Console.WriteLine(31);
                        break;
                    case 9:
                        Console.WriteLine(30);
                        break;
                    case 10:
                        Console.WriteLine(31);
                        break;
                    case 11:
                        Console.WriteLine(30);
                        break;
                    case 12:
                        Console.WriteLine(31);
                        break;
                }
            }
            else
            {
                bool vysokos = god % 4 == 0 && god % 100 != 0 || god % 400 == 0;
                switch (m)
                {
                    case 1:
                        Console.WriteLine(31);
                        break;
                    case 2:
                        switch (vysokos)
                        {
                            case true: //високосный
                                Console.WriteLine(29);
                                break;
                            case false: //не високосный
                                Console.WriteLine(28);
                                break;
                        }
                        break;
                    case 3:
                        Console.WriteLine(31);
                        break;
                    case 4:
                        Console.WriteLine(30);
                        break;
                    case 5:
                        Console.WriteLine(31);
                        break;
                    case 6:
                        Console.WriteLine(30);
                        break;
                    case 7:
                        Console.WriteLine(31);
                        break;
                    case 8:
                        Console.WriteLine(31);
                        break;
                    case 9:
                        Console.WriteLine(30);
                        break;
                    case 10:
                        Console.WriteLine(31);
                        break;
                    case 11:
                        Console.WriteLine(30);
                        break;
                    case 12:
                        Console.WriteLine(31);
                        break;

                }
            }
        }
    }
}