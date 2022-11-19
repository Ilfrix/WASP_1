using System; //подключение библиотек
namespace Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < n; ++i)
            {
                string tmp = "";
                for (int j = 0; j < n; ++j)
                {
                    tmp += (char) (n + 48 - Math.Abs(i - j));
                }
                Console.WriteLine(tmp);
            }
        }
    }
}
