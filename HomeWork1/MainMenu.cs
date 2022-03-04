using Alex.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class MainMenu
    {
        #region Анкета
        static void Task1()
        {
            Console.WriteLine("============================");
            Console.WriteLine("Выполнение задачи 1...");
            Console.WriteLine("============================");

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

        #region Рост человека
        static void Task2()
        {
            Console.WriteLine("============================");
            Console.WriteLine("Выполнение задачи 2...");
            Console.WriteLine("============================");

            Console.WriteLine("Пожалуйста введите свой вес");
            double m = double.Parse(Console.ReadLine());
            Console.WriteLine("Пожалуйста введите свой Рост");
            double h = double.Parse(Console.ReadLine());
            double result = m / Math.Pow(h, 2);
            Console.WriteLine($"Ваш вес:  {m}");
            Console.WriteLine($"Ваш рост: {h}");
            Console.WriteLine($"Ваш индекс веса: {result}");
            Console.ReadLine();


        }
        #endregion
        static void Task3()
        {
            Console.WriteLine("============================");
            Console.WriteLine("Выполнение задачи 3...");
            Console.WriteLine("============================");

            Console.WriteLine("Введите 1 число");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите 2 число");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Первое ваше число: {a} Второе ваше число: {b}");
          
        }
        static void Task4()
        {
            Console.WriteLine("============================");
            Console.WriteLine("Выполнение задачи 4...");
            Console.WriteLine("============================");
        }


        static void Main(string[] args)
        {
          
            bool f = true;

            while (f) {

            OutputHelpers.PrintInfo(1, "Каширский Александр Александрович"); // Выводим ФИО
            Console.WriteLine("Мои задачи");
            Console.WriteLine("===========================");
            Console.WriteLine("1 - > Задача 1 ");
            Console.WriteLine("2 - > Задача 2 ");
            Console.WriteLine("3 - > Задача 3 ");
            Console.WriteLine("4 - > Задача 4 ");
            Console.WriteLine("0 - > Завершение приложения");
            Console.WriteLine("===========================");

            Console.WriteLine("Введите номер задачи...");
            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 1:
                    Task1();
                        break;
                case 2:
                    Task2();
                        break;
                case 3:
                    Task3();
                        break;
                case 4: 
                    Task4();
                        break;
                    case 0:
                        Console.WriteLine("Завершение работы приложения");
                        f = false;
                        break;

                        default:
                        Console.WriteLine("Некорректный номер задачи, повторите ввод");
                                                break;
               }
            } 


        }

    }
}
