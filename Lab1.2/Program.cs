using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._2
{
    public class Logic
    {
        public static string CheckDigitOrder(int number)
        {
            if (number < 0)
                number = -number;

            if (number < 10)
                return "Последовательность упорядочена по возрастанию";

            int previousDigit = number % 10;
            number = number / 10;

            while (number > 0)
            {
                int currentDigit = number % 10;

                if (currentDigit >= previousDigit)
                {
                    return "Последовательность не упорядочена по возрастанию";
                }

                previousDigit = currentDigit;
                number = number / 10;
            }

            return "Последовательность упорядочена по возрастанию";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int number))
            {
                Console.WriteLine("Ошибка: введите целое число");
                return;
            }

            string result = Logic.CheckDigitOrder(number);
            Console.WriteLine(result);
        }
    }
}