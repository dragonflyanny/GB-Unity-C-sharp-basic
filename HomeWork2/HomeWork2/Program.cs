using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hw.Utils;

namespace HomeWork2
{


    internal class Program
    {
                

        static void Main(string[] args)
        {
            bool f = true;

            

            while (f)
            {
                Outputhelpers.PrintInfo(2, "Николаева Антонина Викторовна");
                Console.WriteLine("Меню домашней работы");
                Console.WriteLine("=================================");
                Console.WriteLine("1 -> Задача 1: Написать метод, возвращающий минимальное из трёх чисел.");
                Console.WriteLine("2 -> Задача 2: Написать метод подсчета количества цифр числа.");
                Console.WriteLine("3 -> Задача 3: С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.");
                Console.WriteLine("4 -> Задача 4: Реализовать метод проверки логина и пароля.");
                Console.WriteLine("0 -> Завершение работы приложения");
                Console.WriteLine("=================================\n");

                Console.Write("Введите номер задачи: ");
                
                int number = int.Parse(Console.ReadLine());

                switch (number)
                {
                    case 0:
                        Console.WriteLine("Завершение работы приложения ...");
                        Outputhelpers.Pause();
                        f = false;
                        break;

                    case 4:
                        Task4();
                        Console.WriteLine();
                        break;

                    case 3:
                        Task3();
                        Console.WriteLine();
                        break;

                    case 2:
                        Task2();
                        Console.WriteLine();
                        break;

                    case 1:
                        Task1();
                        Console.WriteLine();
                        break;

                    default:
                        Console.WriteLine("Вы ввели некорректный номер задачи.\nПовторите ввод.");
                        break;

                }

            }
        }

        static void Task1()
        {

            #region "Шапка" задачи
            Console.Clear();
            Outputhelpers.PrintInfo(2, "Николаева Антонина Викторовна");
            Outputhelpers.TaskInfo(1, "Написать метод, возвращающий минимальное из трёх чисел.");
            #endregion
            #region Получаем данные
            Console.WriteLine("Для выполнения потребуется ввести 3 числа. Вводите числа поочередно.");
            Console.Write("Введите первое число: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите третье число: ");
            int c = int.Parse(Console.ReadLine());
            int max;
            #endregion
            #region Вычисление
            if (a > b)
            {
                if (a > c)
                { max = a; }
                else
                { max = c; }
            }
            else if (b > c)
            { max = b; }
            else
            { max = c; }
            Console.WriteLine($"Было введено 3 числа: {a} {b} {c}. Наибольшее число {max}");
            #endregion
            #region Готовимся к переходу в стартовое меню
            Outputhelpers.BackToMenu();
            #endregion
        }

        static void Task2()
        {
            #region "Шапка" задачи
            Console.Clear();
            Outputhelpers.PrintInfo(2, "Николаева Антонина Викторовна");
            Outputhelpers.TaskInfo(2, "Написать метод подсчета количества цифр числа.");
            #endregion
            #region Получаем данные
            Console.WriteLine("Для выполнения потребуется ввести число. " +
                "Вы можете вводить отрицательные и положительные числа в пространстве " +
                "от -2 147 483 647 до 2 147 483 647. \nВведите число: ");
            int a = int.Parse(Console.ReadLine());
            int b = a;
            int count = 0;
            #endregion
            #region Вычисление
            while (b != 0)
            {
                count++;
                b = b / 10;// так как n-целое, деление целочисленное
            }
            Console.WriteLine($"Было введено число: {a}. Это число состоит из {count} цифр.");
            #endregion
            #region Готовимся к переходу в стартовое меню
            Outputhelpers.BackToMenu();
            #endregion

        }

        static void Task3()
        {
            #region "Шапка" задачи
            Console.Clear();
            Outputhelpers.PrintInfo(2, "Николаева Антонина Викторовна");
            Outputhelpers.TaskInfo(3, "С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.");
            #endregion
            #region Запускаем цикл
            Console.WriteLine("Пожалуйста, введите число. При введении числа 0 вводи чисел будет завершен, и будет подсчитана сумма всех введенных чисел");
            int a;
            int count = 0;
            int c;
            do
            {
                Console.Write("Введите число:");
                a = int.Parse(Console.ReadLine());
                c = ((a % 2 == 0) ? 0 : a);
                count = count + c;
            }
            while (a != 0);
            Console.WriteLine($"Общая сумма всех введенных чисел равна {count}");
            #endregion
            #region Готовимся к переходу в стартовое меню
            Outputhelpers.BackToMenu();
            #endregion

        }

        static void Task4()
        {
            #region "Шапка" задачи
            Console.Clear();
            Outputhelpers.PrintInfo(2, "Николаева Антонина Викторовна");
            Outputhelpers.TaskInfo(3, "Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. " +
                "На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). " +
                "Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает " +
                "его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.");
            #endregion
            #region Получаем данные
            //возможность изменения логина и пароля
            string login = "root";
            string password = "GeekBrains";
            int count = 3;
            int l;
            int p;

            #endregion
            #region Запускаем цикл

            do
            {
            
                Console.WriteLine("Для продолжения необходима авторизация. \nВведите логин:");
                l = String.Compare(login, Console.ReadLine());
                Console.WriteLine("Для продолжения необходима авторизация. \nВведите пароль:");
                p = String.Compare(password, Console.ReadLine());

                if (l > p)
                {
                    Console.WriteLine("Авторизация прошла неуспешно. \nПопробуйте еще раз"); }
                else  if (l==0)
                {     
                    Console.WriteLine("Авторизация прошла успешно. \nВсе отлично!");
                    Console.WriteLine($"Было использовано {count} попыток из 3");
                    break;
                }
                else { Console.WriteLine("Авторизация прошла неуспешно. \nПопробуйте еще раз"); }

                Console.WriteLine($"Было использовано {count} попыток из 3");
                count--;
            }
            while (count != 0);


            
            #endregion
            #region Готовимся к переходу в стартовое меню
            Outputhelpers.BackToMenu();
            #endregion

        }
    }
}
