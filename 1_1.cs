using System; //подключение библиотек
namespace Lesson_1
{
    class HW_1_1
    {
        static void Main(string[] args)
        {
            for (int i = 1000; i < 9999; ++i)
            {
                for (int j = 0; (i / 1000 > i / 100 % 10) && (i / 100 % 10 > i / 10 % 10) && (i / 10 % 10 > i % 10) && j < 1; ++j)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
