using System;
using Alex.utils;


namespace HomeWork1
{
    
    internal class Programms
    {
        #region Анкета
        static void Main(string[] args)

        {
            OutputHelpers.PrintInfo(1, "Каширский Александр Александрович"); // Выводим ФИО


            Console.WriteLine("Пожалуйста, заполните анкету");
            Console.WriteLine("============================");
            Console.Write("Введите Ваше имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите Вашу Фамилию: ");
            string surname = Console.ReadLine();
            Console.Write("Введите Ваш возраст: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Введите Ваш рост: ");
            int height = int.Parse(Console.ReadLine());
            Console.Write("Введите Ваш вес: ");
            int weight = int.Parse(Console.ReadLine());

            Console.WriteLine("Выбирете метод решения");
            Console.WriteLine("1 -> используя склеивание");
            Console.WriteLine("2 -> используя форматированный вывод");
            Console.WriteLine("3 -> используя вывод со знаком $");

            int number = int.Parse(Console.ReadLine());

            if (number == 1) // метод 1
            {
                Console.WriteLine("Имя:  {0}, Фамилия:  {1}, Возраст:  {2}, Рост: {3}, Вес:  {4}", name, surname, age, height, weight);
            }
            else if (number == 2) // метод 2
            {
                string output = string.Format("Имя:  {0}, Фамилия:  {1}, Возраст:  {2}, Рост: {3}, Вес:  {4}", name, surname, age, height, weight);
                Console.WriteLine(output);
            }
            else // метод 3
            {
                Console.WriteLine($"Имя:  {name}, Фамилия:  {surname}, Возраст:  {age}, Рост: {height}, Вес:  {weight}");
            }
          
        }
        #endregion
    }

}
