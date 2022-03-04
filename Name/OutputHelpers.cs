using System;

namespace Alex.utils

{
    public class OutputHelpers
    {
        public static void PrintInfo(int homeworkNumbers, string fio)
        {
            Console.WriteLine($"Домашняя работа. Урок: {homeworkNumbers}");
            Console.WriteLine($"Студент:  {fio}");
            Console.WriteLine("=================================================");
            Console.WriteLine();
        }
    }
}
