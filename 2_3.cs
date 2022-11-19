using System;

namespace HW_1
{
    class Program
    {
        static void Main(string[] args)
        {
            short first = Convert.ToInt16(Console.ReadLine());
            short second = Convert.ToInt16(Console.ReadLine());
            short third = Convert.ToInt16(Console.ReadLine());
            short fourth = Convert.ToInt16(Console.ReadLine());
            //int s = 8;  //по ответу
            int s = 16; //по типу данных
            long res = Convert.ToInt64(first); //Если ли способ сделать это в одную строку? Convert от суммы у меня не работал:(
            res += Convert.ToInt64(second << s);
            res += Convert.ToInt64(third << s*2);
            res += Convert.ToInt64(fourth << s*3);
            Console.WriteLine(res);
        }
    }
}