using System;
using Alex.utils;

/// <summary>
/// /////////////////////
/// </summary>
namespace HomeWork1
{
    internal class Class1
    {
        #region Наибольшее число
        static void Task1()
        {

            Console.Clear();

            Console.WriteLine("=========================");
            Console.WriteLine("Выполнение задачи 1...");
            Console.WriteLine("Минимальное из трёх чисел");
            Console.WriteLine("=========================");
            Console.WriteLine("Введите число А: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число C: ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a <= b && a <= c)
                Console.WriteLine($"Самое минимальное число {a}");
            else if (b <= c && b <= a)
                Console.WriteLine($"Самое минимальное число {b}");
            else
                Console.WriteLine($"Самое минимальное число {c}");

            Console.ReadLine();
            Console.Clear();

        }
        #endregion

        #region Подсчет количества цифр числа
        static void Task2()
        {

            Console.Clear();

            Console.WriteLine("===============================");
            Console.WriteLine("Выполнение задачи 2...");
            Console.WriteLine("Подсчет количетсва цифр в числе");
            Console.WriteLine("===============================");
            string number = Console.ReadLine();
            Console.WriteLine($"Количество символов: ");
            Console.WriteLine(number.Length);
            Console.ReadLine();
            Console.Clear();


        }
        #endregion

        #region Подсчет суммы всех положительный чисел
        static void Task3()
        {

            Console.Clear();

            Console.WriteLine("=======================================");
            Console.WriteLine("Выполнение задачи 3...");
            Console.WriteLine("Сумма всех нечетных положительных чисел");
            Console.WriteLine("=======================================");

            {
                Console.Clear();
                Console.WriteLine("Введите число...");


                uint summ = 0;
                bool loop = true;

                while (loop)
                {
                    uint a = (uint)Convert.ToInt32(Console.ReadLine());

                    if (a % 2 == 0 && a != 0)
                    {
                        summ += a;
                    }

                    else if (a == 0)
                    {
                        loop = false;
                        break;
                    }

                }

                Console.WriteLine("Сумма чисел равна: " + summ);
            }
            Console.ReadLine();
            Console.Clear();

        }
        #endregion

        #region Проверка Логина и паролья (root : GeekBrains)
        static void Task4()
        {
            for (int Attempt = 3; Attempt > 0; Attempt--)
            {

                Console.WriteLine("=============================================");
                Console.WriteLine("Выполнение задачи 4...");
                Console.WriteLine("Проверка Логина и паролья (root : GeekBrains)");
                Console.WriteLine("=============================================");
                Console.WriteLine($"Осталось попыток: {Attempt}");
                Console.WriteLine("Введите логин: ");
                string login = Console.ReadLine();
                Console.WriteLine("Введите пароль: ");
                string password = Console.ReadLine();

                if (login == "root" && password == "GeekBrains")
                {
                    Console.WriteLine("Доступ разрешен");
                    return;
                }

                else
                {
                    Console.WriteLine("Доступ зарщен...");
                    Console.Clear();
                }

            }
        }
        #endregion

        #region Индекс массы тела
        static void Task5()
        {

            Console.Clear();
            Console.WriteLine("======================");
            Console.WriteLine("Выполнение задачи 5...");
            Console.WriteLine("Индекс массы тела");
            Console.WriteLine("======================");


            Console.WriteLine("Пожалуйста введите свой Рост");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("Пожалуйста введите свой вес");
            double m = double.Parse(Console.ReadLine());
            double result = m / Math.Pow((h / 100), 2);
            Console.WriteLine($"Ваш вес:  {m}");
            Console.WriteLine($"Ваш рост: {h}");
            Console.WriteLine($"Ваш индекс веса: {result}");

            if (result < 18.5)
            {
                Console.WriteLine("Ниже нормального веса");
                Console.ReadLine();
            }
            else if (result >= 18.5 && result < 25)
            {
                Console.WriteLine("Нормальный вес");
                Console.ReadLine();
                Console.Clear();
                return;
            }
            else if (result >= 25 && result < 30)
            {
                Console.WriteLine("Избыточный вес");
            }
            else if (result >= 30 && result < 35)
            {
                Console.WriteLine("Ожирение I степени");
            }
            else if (result >= 35 && result < 40)
            {
                Console.WriteLine("Ожирение II степени");
            }
            else if (result >= 40)
            {
                Console.WriteLine("Ожирение III степени");
            }

            double normal = 0;
            normal = 27.75 * Math.Pow((h / 100), 2);
            if (normal < m)
            {
                Console.WriteLine($"Вам нужно похудеть на: {m - normal }");
                Console.ReadLine();
                Console.Clear();
            }
            else if (normal > m)
            {
                Console.WriteLine($"Вам нужно набрать: {normal - m}");
                Console.ReadLine();
                Console.Clear();
            }

        }


        #endregion

        #region Меню
        static void Main(string[] args)
        {

            bool f = true;

            while (f)
            {

                OutputHelpers.PrintInfo(2, "Каширский Александр Александрович"); // Выводим ФИО
                Console.WriteLine("Мои задачи");
                Console.WriteLine("===================================================");
                Console.WriteLine("1 - > Наименьшее число ");
                Console.WriteLine("2 - > Подсчет количества цифр числа");
                Console.WriteLine("3 - > Подсчет суммы всех положительный чисел");
                Console.WriteLine("4 - > Проверка Логина и паролья (root : GeekBrains)");
                Console.WriteLine("5 - > Индекс массы тела");
                Console.WriteLine("0 - > Завершение приложения");
                Console.WriteLine("===================================================");

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
                    case 5:
                        Task5();
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
        #endregion
    }
}