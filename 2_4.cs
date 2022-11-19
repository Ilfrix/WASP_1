using System;

namespace HW_1
{
    class Program
    {
        static void Main(string[] args)
        {
            long value = Convert.ToInt64(Console.ReadLine());
            int s = 16; //по типу данных
            //int s = 8;//по ответу
            long mod = (1 << s)-1;
            string answer = "";
            for (int i = 0; i < 4; ++i)
            {
                answer += Convert.ToString(value & mod) + " ";
                value >>= s;
            }
            Console.WriteLine(answer);
        }
    }
}