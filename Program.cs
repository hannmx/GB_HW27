using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_HW27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число: ");
            int number = int.Parse(Console.ReadLine());
            int part_number = 0;
            int result_sum = 0;
            while (number > 0)
            {
                part_number = number % 10;
                number /= 10;
                result_sum += part_number;
            }
            Console.WriteLine("Сумма цифр числа: " + result_sum);
        }
    }
}
