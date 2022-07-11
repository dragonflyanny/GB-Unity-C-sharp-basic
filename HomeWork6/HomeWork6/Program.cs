using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using hw.Utils;
using System.Text.RegularExpressions;

namespace HomeWork5
{
    // Описываем делегат. В делегате описывается сигнатура методов, на
    // которые он сможет ссылаться в дальнейшем (хранить в себе)
    public delegate double DoOperation(double x, double y);


    internal class Program
    {

        // Создаем метод, который принимает делегат
        // На практике этот метод сможет принимать любой метод
        // с такой же сигнатурой, как у делегата
        public static void Table(DoOperation operation, double a, double b)
        {
            double res = operation(a, b);
            Console.WriteLine($" = {res}");
        }
        // Создаем метод для передачи его в качестве параметра в Tablef
        public static double Sqrt(double a, double b)
        {
            Console.Write($"{a} * {b} * 2");
            return a * b *2;
        }

        public static double Sin(double a, double b)
        {
            Console.Write($"{a} * sin {b}");
            double c = Math.Sin (b);
            return a*c;
        }

        public static void Process(DoOperation operation, double a, double b)
        {
            double res = operation(a, b);
            Console.WriteLine($" = {res}");
        }

        static void Main(string[] args)
        {




            bool f = true;



            while (f)
            {
                Outputhelpers.PrintInfo(6, "Николаева Антонина Викторовна");
                Console.WriteLine("Меню домашней работы");
                Console.WriteLine("=================================");
                Console.WriteLine("1 -> Задача 1: Программа вывода таблицы функци");
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
            Outputhelpers.PrintInfo(6, "Николаева Антонина Викторовна");
            Outputhelpers.TaskInfo(1, "Изменить программу вывода таблицы функции так," +
                " чтобы можно было передавать функции типа double(double, " +
                "double).Продемонстрировать работу на функции с функцией a * x ^ 2" +
                " и функцией a * sin(x).");
            #endregion

            Process(Sqrt, 34, 5);
            Process(Sin, 34, 5); //я не смогла разобраться почему возвращает не то( простите
            Console.WriteLine("я не смогла разобраться почему возвращает не то( простите");




            #region Готовимся к переходу в стартовое меню
            Outputhelpers.BackToMenu();
            #endregion

        }




 




    }

}