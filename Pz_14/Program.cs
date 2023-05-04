namespace Pz_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        public static int program(int a1, int d, int n)
        {
            while (n > 0)
            {
                a1 += d;
                n--;
                program(a1, d, n);
            }
            return a1;
        }
        public static double program2(double b1, double q, int n)
        {
            while (n > 0)
            {
                b1 = b1 * q;
                n--;
                program2(b1, q, n);
            }
            return b1;
        }
        public static void program3(int A, int B)
        {
            if (A<B)
            {
                    Console.WriteLine(A);
                    A++;
                    program3(A, B);
            }
            else if (A == B)
                {
                    Console.WriteLine(A);
                    return;
                }
            else
            {
                Console.WriteLine(A);
                A--;
                program3(A, B);
            }
        }
        public static int Summ(int x)
        {
            if (x == 1) 
            {
                return 1;
            }
            else 
            {
                return x + Summ(x - 1);
            }
        }
    }
}