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
            int second = Convert.ToInt32(Console.ReadLine());
            int sum_of_values = first + second;
            string first_byte = "", second_byte = "", sum_byte = "";
            first_byte = FromIntToByte(first);
            second_byte = FromIntToByte(second);
            sum_byte = FromIntToByte(sum_of_values);
            string result_first = "", result_second = "", space = "";
            for (int i = first_byte.Length; i < sum_byte.Length; ++i)
            {
                result_first += "0";
            }
            for (int i = second_byte.Length; i < sum_byte.Length; ++i)
            {
                result_second += "0";
            }
            for (int i = 0; i < sum_byte.Length; ++i)
            {
                space += ".";
            }
            result_first += first_byte;
            result_second += second_byte;
            Console.WriteLine(result_first);
            Console.WriteLine(result_second);
            Console.WriteLine(space);
            Console.WriteLine(sum_byte);
        }
    }
}