using System;
    namespace HW_1__2_1
{
    class Programm
    {
        static string FromIntToByte(int value)
        {
            string tmp_value = "";
            string ans_value = "";
            int bit = 1;
            if (value == 0)
            {
                return "0";
            }
            while (value >= bit)
            {
                tmp_value += (value & bit) > 0 ? "1" : "0";
                bit <<= 1;
            }
            for (int i = tmp_value.Length - 1; i >= 0; --i)
            {
                ans_value += tmp_value[i];
            }
            return ans_value;
        }
        static void Main(string[] args)
        {
            int first = Convert.ToInt32(Console.ReadLine());
            Console.Write(FromIntToByte(first));
        }
    }
}