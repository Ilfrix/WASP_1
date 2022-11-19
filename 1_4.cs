using System;
namespace Les_1_4{
    class Program
    {
        static int factorial(int x)
        {
            if (x <= 1) return 1;
            return x * factorial(x - 1);
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n;++i)
            {
                string tmp = "";
                for (int j = 0; j <= i; ++j) 
                {
                    tmp += (factorial(i) / (factorial(j) * factorial(i - j))).ToString() + ' ';
                }
                Console.WriteLine(tmp);
            }
        }
    }
}