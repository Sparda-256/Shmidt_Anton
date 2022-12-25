using System.Diagnostics;
using System.Runtime.Intrinsics.X86;

namespace Pz_12
{
    internal class Program
    {
        static int RootsCount(int A,int B,int C)
        {
            int D = Convert.ToInt32(Math.Pow(B,2)-4*A*C);
            int x1 = Convert.ToInt32((-B + Math.Pow(D, 0.5)) / 2 * A);
            int x2 = Convert.ToInt32((-B - Math.Pow(D, 0.5)) / 2 * A);
            byte count= 0;
            if (x1 % 1 == 0)
            {
                count++;
            }
            if (x2 % 1 == 0)
            {
                count++;
            }
            Console.WriteLine(count);
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа A, B и C в формате Ax^2 + Bx + C = 0\nМы найдём количество корней этого уравнения:");
            int a = Convert.ToInt32(Console.ReadLine()), b = Convert.ToInt32(Console.ReadLine()), c = Convert.ToInt32(Console.ReadLine());
            if (a==0)
            {
                Console.WriteLine("А не может равняться 0");
                System.Environment.Exit(0);
            }
            RootsCount(a, b, c);
        }
    }
}