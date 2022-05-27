using System;
using static System.Console;

namespace lesson_3_10_3
{
    internal class Program
    {
        static void Main(string[] args)  // точка входа
        {

            
                Write($"Здравствуйте! Введите число и нажмите \"Enter\": ");
                int count = 0;
                int whole = int.Parse(ReadLine());
                bool n = true;
                int i = 2;
                while (i <= Math.Sqrt(whole))
                if (whole % i == 0) // если whole делится без остатка на i - возвращаем false (число не простое)
                {
                    n = false;
                        count++; 
                    break;
                }
                else
                {
                    i++;
                }
                if (n == true)
                {
                   WriteLine("Число простое");
                }
                else
                {
                   WriteLine("Число непростое");
                }
                ReadKey();
            
        }
    }
}
