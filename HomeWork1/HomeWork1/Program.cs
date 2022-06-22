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
                Outputhelpers.PrintInfo(1, "Николаева Антонина Викторовна");
                Console.WriteLine("Меню домашней работы");
                Console.WriteLine("=================================");
                Console.WriteLine("1 -> Задача 1: Написать программу «Анкета».");
                Console.WriteLine("2 -> Задача 2: Рассчитать и вывести индекс массы тела (ИМТ).");
                Console.WriteLine("3 -> Задача 3: Написать программу, которая подсчитывает расстояние между точками");
                Console.WriteLine("6 -> Задача 6: Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause)");
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

                    case 6:
                        Task6();
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
            Outputhelpers.PrintInfo(1, "Николаева Антонина Викторовна");
            Outputhelpers.TaskInfo(1, "Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку");
            #endregion
            #region Получаем данные
            Console.WriteLine("Анкета");
            Console.WriteLine("Пожалуйста, ответьте на несколько вопросов.");
            //Необходимо запросить следующее: имя, фамилия, возраст, рост, вес
            Console.Write("Введите ваше имя: ");
            string name1 = Console.ReadLine();
            Console.Write("Введите вашу фамилию: ");
            string fname1 = Console.ReadLine();
            Console.Write("Введите ваш возраст (полных лет): ");
            string age1 = Console.ReadLine();
            Console.Write("Введите ваш рост (в сантиметрах): ");
            string hight1 = Console.ReadLine();
            Console.Write("Введите ваш вес (в килограммах): ");
            string weight1 = Console.ReadLine();
            //Конвертируем числа
            int a1 = int.Parse(age1);
            double h1 = double.Parse(hight1);
            int w1 = int.Parse(weight1);
            #endregion
            #region Вывод собранной информации в одну строку
            Console.WriteLine("Вывод собранной информации в одну строку используя склеивание");
            Console.WriteLine("Анкетируемый: {0} {1}, полных лет: {2}, рост: {3} см., вес: {4} кг.", name1, fname1, a1, h1, w1);
            Console.WriteLine("Вывод собранной информации в одну строку используя форматированный вывод. Добавим рост в метрах (чтобы показать форматирование");
            Console.WriteLine("Анкетируемый: {0} {1}, полных лет: {2}, рост: {3} см. (примерно {4:F} м.), вес: {5} кг.", name1, fname1, a1, h1, h1 / 100, w1);
            Console.WriteLine("Вывод собранной информации в одну строку используя вывод со знаком $");
            Console.WriteLine($"Анкетируемый: {name1} {fname1}, полных лет: {a1}, рост: {h1} см. (примерно {h1 / 100:F} м.), вес: {w1} кг.");
            #endregion
            #region Готовимся к переходу в стартовое меню
            Outputhelpers.BackToMenu();
            #endregion
        }

        static void Task2()
        {
            #region "Шапка" задачи
            Console.Clear();
            Outputhelpers.PrintInfo(1, "Николаева Антонина Викторовна");
            Outputhelpers.TaskInfo(2, "Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.");
            #endregion
            #region Получаем данные
            Console.WriteLine("Расчет IMT.");
            Console.WriteLine("Пожалуйста, ответьте на несколько вопросов.");
            //Необходимо запросить следующее: рост, вес
            Console.Write("Введите ваш рост (в сантиметрах): ");
            string hight2 = Console.ReadLine();
            Console.Write("Введите ваш вес (в килограммах): ");
            string weight2 = Console.ReadLine();
            //Конвертируем числа
            //сантиметры сразу в метры
            double h2 = double.Parse(hight2) / 100;
            double w2 = double.Parse(weight2);
            #endregion
            #region Вычисление
            double imt = RasImt(w2, h2);
            //используя вывод со знаком $
            Console.WriteLine($"Анкетируемый: вес {w2} кг, рост {h2} метра, индекса массы тела (ИМТ) по формуле ИМТ=вес/(рост*рост) {imt}");
            #endregion
            #region Готовимся к переходу в стартовое меню
            Outputhelpers.BackToMenu();
            #endregion

        }

        static double RasImt(double a, double b)
        {
            double res;
            res = a / (b * b);
            return res;
        }

        static void Task3()
        {
            #region "Шапка" задачи
            Console.Clear();
            Outputhelpers.PrintInfo(1, "Николаева Антонина Викторовна");
            Outputhelpers.TaskInfo(3, "Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2).");
            #endregion
            #region Получаем данные
            Console.WriteLine("Расчет расстояния.");
            Console.WriteLine("Пожалуйста, задайте координаты двух точек по осям x и y.");

            //Запрашиваем координаты
            Console.Write("введите координату x первой точки: ");
            string stringx1 = Console.ReadLine();
            Console.Write("введите координату y первой точки: ");
            string stringy1 = Console.ReadLine();
            Console.Write("введите координату x второй точки: ");
            string stringx2 = Console.ReadLine();
            Console.Write("введите координату y второй точки: ");
            string stringy2 = Console.ReadLine();

            //Конвертируем числа
            int x1 = int.Parse(stringx1);
            int y1 = int.Parse(stringy1);
            int x2 = int.Parse(stringx2);
            int y2 = int.Parse(stringy2);

            #endregion
            #region Вычисление
            //по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2).
            double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            #endregion

            #region Вывод информации
            //используя вывод со знаком $
            Console.WriteLine($"Расстояние между точками 1 ({x1},{y1}) и 2 ({x2},{y2}) составляет {result}");
            #endregion
            #region Расчет по формуле
            double result3 = RasFor(x1, y1, x2, y2);
            #endregion

            #region Вывод информации
            Console.WriteLine("Выполнить задание, оформив вычисления расстояния между точками в виде метода.");
            Console.WriteLine($"Расстояние между точками 1 ({x1},{y1}) и 2 ({x2},{y2}) составляет {result}");
            #endregion
            #region Готовимся к переходу в стартовое меню
            Outputhelpers.BackToMenu();
            #endregion


        }
        /// <summary>
        /// Расчет расстояния между точками по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2))
        /// </summary>
        /// <param name="x1">координата точки 1 по оси x</param>
        /// <param name="y1">координата точки 1 по оси y</param>
        /// <param name="x2">координата точки 2 по оси x</param>
        /// <param name="y2">координата точки 2 по оси y</param>
        /// <returns>расстояние между точками</returns>
        static double RasFor(int x1, int y1, int x2, int y2)
        {
            //по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2).
            double res;
            res = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return res;
        }



        static void Task6()
        {
            #region "Шапка" задачи
            Console.Clear();
            Outputhelpers.PrintInfo(1, "Николаева Антонина Викторовна");
            Outputhelpers.TaskInfo(6, "Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause)");
            #endregion
            #region Демонстрация

            Console.WriteLine("Демонстрация класса PrintInfo");
            Outputhelpers.PrintInfo(1, "Николаева Антонина Викторовна");
            Console.WriteLine();
            Console.WriteLine("Демонстрация класса TaskInfo");
            Outputhelpers.TaskInfo(6, "Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause)");
            Console.WriteLine();
            Console.WriteLine("Демонстрация класса Pause - нажмите любую клавишу для продолжения");
            Outputhelpers.Pause();
            Console.WriteLine();
            Console.WriteLine("Демонстрация класса BackToMenu и завершение работы");
            Outputhelpers.BackToMenu();

            #endregion

        }
    }
}
