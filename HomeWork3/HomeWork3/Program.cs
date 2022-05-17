using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hw.Utils;

namespace HomeWork3
{

    /// <summary>
    /// Структура описывает комплексное число
    /// </summary>
    class ComplexClass
    {
        /// <summary>
        /// Действительная часть комплексного числа
        /// </summary>
        private double re;

        /// <summary>
        /// Мнимая часть комплексного числа
        /// </summary>
        private double im;

        public double Re
        {
            get
            {
                return re;
            }

            set
            {



                re = value;
            }

        }

        public double Im
        {
            get
            {
                return im;
            }

            set
            {
                im = value;
            }
        }


        public ComplexClass()
        {

        }

        public ComplexClass(double re, double im)
        {
            if (im == 0)
            {
                throw new Exception("На ноль делить нельзя!");
            }
            this.re = re;
            this.im = im;
        }

        /// <summary>
        /// Сложение комплексных чисел
        /// </summary>
        /// <param name="x">Комплексное число</param>
        /// <returns>Результат сложения комплексных чисел</returns>
        public ComplexClass Plus(ComplexClass x)
        {
            ComplexClass complexRes = new ComplexClass(re + x.re, im + x.im);
            return complexRes;
        }

        public static ComplexClass Plus(ComplexClass a, ComplexClass b)
        {
            ComplexClass complexRes = new ComplexClass(a.re + b.re, a.im + b.im);
            return complexRes;
        }

        public static ComplexClass Minus(ComplexClass a, ComplexClass b)
        {
            ComplexClass complexRes = new ComplexClass(a.re - b.re, a.im - b.im);
            return complexRes;
        }

        public static ComplexClass Multiplication(ComplexClass a, ComplexClass b)
        {
            ComplexClass complexRes = new ComplexClass(a.re * b.re, a.im * b.im);
            return complexRes;
        }

        public static ComplexClass Division(ComplexClass a, ComplexClass b)
        {
            ComplexClass complexRes = new ComplexClass(a.re / b.re, a.im / b.im);
            return complexRes;
        }

        public override string ToString()
        {
            //return base.ToString();
            return $"{re} + {im}i";
        }


    }

    /// <summary>
    /// Структура описывает комплексное число
    /// </summary>
    struct Complex
    {
        /// <summary>
        /// Действительная часть комплексного числа
        /// </summary>
        public double re;

        /// <summary>
        /// Мнимая часть комплексного числа
        /// </summary>
        public double im;

        /// <summary>
        /// Сложение комплексных чисел
        /// </summary>
        /// <param name="a">Первое комплексное число</param>
        /// <param name="b">Второе комплексное число</param>
        /// <returns></returns>
        public static Complex Plus(Complex a, Complex b)
        {
            Complex complexRes;
            complexRes.re = a.re + b.re;
            complexRes.im = a.im + b.im;
            return complexRes;
        }

        public static Complex Minus(Complex a, Complex b)
        {
            Complex complexRes;
            complexRes.re = a.re - b.re;
            complexRes.im = a.im - b.im;
            return complexRes;
        }

        public static Complex Multiplication(Complex a, Complex b)
        {
            Complex complexRes;
            complexRes.re = a.re * b.re;
            complexRes.im = a.im * b.im;
            return complexRes;
        }

        public static Complex Division(Complex a, Complex b)
        {
            Complex complexRes;
            complexRes.re = a.re / b.re;
            complexRes.im = a.im / b.im;
            return complexRes;
        }

        //TODO: Добавить методы вычитания, умножения, деления комплексных чисел

        public override string ToString()
        {
            //return base.ToString();
            return $"{re} + {im}i";
        }


    }

    internal class Program
    {

        static void Task2()
        {
            #region "Шапка" задачи
            Console.Clear();
            Outputhelpers.PrintInfo(3, "Николаева Антонина Викторовна");
            Outputhelpers.TaskInfo(2, "С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse.");
            #endregion
            int sum = 0; // Объявим перменную для хранения суммы чисел
            #region Запускаем цикл

            bool isNumber;
            int number;

            do
            {
                Console.WriteLine("Для выполнения вводите числа. Для завершения и выдачи суммы всех нечетных положительных чисел нажмите 0:");
                var numberInput = Console.ReadLine(); // Получим строку ввода
                isNumber = int.TryParse(numberInput, out number); // Проверим, является ли строка ввода числом

                if (!isNumber) // Если строка ввода не является числом, выведем соответствующую информацию на экран
                {
                    Console.WriteLine($"{numberInput} не является целым числом, будьте внимательны.");
                }
                else
                {

                    // Число должно быть НЕчетным + положительным (метод IsOdd проверяем число на четность)
                    // Если число удовлетворяет условию, прибавляем число к общей сумме, если нет, прибавляем 0 (т. е. по факту, ничего не прибавляем)

                    sum += !Outputhelpers.IsOdd(number) && number > 0 ? number : 0;
                }
            }
            // Цикл будет работать до тех пор пока мы не введем правильное число и это число не будет равно 0
            while (!(isNumber && number == 0));
            // Как только мы ввели число 0, работа приложения завершается, выводим на экран сумму чисел
            Console.WriteLine($"Cумма нечетных положительных чисел: {sum}");
            #endregion
            #region Готовимся к переходу в стартовое меню
            Outputhelpers.BackToMenu();
            #endregion

        }


        static void Task1()
        {

            #region "Шапка" задачи
            Console.Clear();
            Outputhelpers.PrintInfo(3, "Николаева Антонина Викторовна");
            Outputhelpers.TaskInfo(1, "Дописать структуру Complex и класс Complex. Продемонстрировать работу структуры и класса.");
            #endregion

            bool f1 = true;



            while (f1)
            {
                Outputhelpers.PrintInfo(3, "Николаева Антонина Викторовна");
                Console.WriteLine("Задача 1: Дописать структуру Complex и класс Complex. Продемонстрировать работу структуры и класса.");
                Console.WriteLine("=================================");
                Console.WriteLine("1 -> Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.");
                Console.WriteLine("2 -> Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.");
                Console.WriteLine("3 -> Добавить диалог с использованием switch демонстрирующий работу класса.");
                Console.WriteLine("0 -> Возвращение в основное меню");
                Console.WriteLine("=================================\n");

                Console.Write("Введите номер задачи: ");

                int number = int.Parse(Console.ReadLine());

                switch (number)
                {
                    case 0:
                        Console.WriteLine("Возвращение в основное меню");
                        Outputhelpers.Pause();
                        f1 = false;
                        Outputhelpers.BackToMenu();
                        break;

                    case 3:
                        Console.WriteLine("Диалог через switch реализован");
                        Outputhelpers.Pause();
                        f1 = false;
                        Outputhelpers.BackToMenu();
                        break;

                    case 2:

                        #region Получаем данные
                        Console.WriteLine("Для выполнения потребуется ввести 2 комплексных числа числа.");
                        Console.WriteLine("Введите сначала действительную, а затем мнимую часть первого комплексного числа (через enter). Вы можете попытаться ввести ноль в мнимом числе");
                        ComplexClass clcomplex1 = new ComplexClass(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
                        Console.WriteLine("Введите сначала действительную, а затем мнимую часть второго комплексного числа (через enter). Вы можете попытаться ввести ноль в мнимом числе");
                        ComplexClass clcomplex2 = new ComplexClass(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
                        #endregion


                        #region Вычисление

                        ComplexClass clcomplex3 = ComplexClass.Plus(clcomplex1, clcomplex2);
                        Console.WriteLine($"Результат сложения комплексных чисел {clcomplex1} и {clcomplex2} = {clcomplex3}");

                        ComplexClass clcomplex4 = ComplexClass.Minus(clcomplex1, clcomplex2);
                        Console.WriteLine($"Результат вычитания комплексных чисел {clcomplex1} и {clcomplex2} = {clcomplex4}");

                        ComplexClass clcomplex5 = ComplexClass.Multiplication(clcomplex1, clcomplex2);
                        Console.WriteLine($"Результат умножения комплексных чисел {clcomplex1} и {clcomplex2} = {clcomplex5}");

                        ComplexClass clcomplex6 = ComplexClass.Division(clcomplex1, clcomplex2);
                        Console.WriteLine($"Результат деления комплексных чисел {clcomplex1} и {clcomplex2} = {clcomplex6}");

                        Console.ReadLine();
                        #endregion
                        #region Готовимся к переходу в стартовое меню
                        Outputhelpers.BackToMenu();
                        #endregion
                        break;

                    case 1:
                        #region Получаем данные
                        Console.WriteLine("Для выполнения потребуется ввести 2 комплексных числа числа.");
                        Complex complex1;
                        Console.WriteLine("Введите действительную часть первого комплексного числа");
                        complex1.re = double.Parse(Console.ReadLine());
                        Console.WriteLine("Введите мнимую часть первого комплексного числа. Пожалуйста, не вводите ноль");
                        complex1.im = double.Parse(Console.ReadLine());
                        Complex complex2;
                        Console.WriteLine("Введите действительную часть первого комплексного числа");
                        complex2.re = double.Parse(Console.ReadLine());
                        Console.WriteLine("Введите мнимую часть первого комплексного числа. Пожалуйста, не вводите ноль");
                        complex2.im = double.Parse(Console.ReadLine());
                        #endregion
                        #region Вычисление
                        Complex complex3 = Complex.Plus(complex1, complex2);
                        Console.WriteLine($"Результат сложения комплексных чисел {complex1} и {complex2} = {complex3}");

                        Complex complex4 = Complex.Minus(complex1, complex2); ;
                        Console.WriteLine($"Результат вычитания комплексных чисел {complex1} и {complex2} = {complex4}");

                        Complex complex5 = Complex.Multiplication(complex1, complex2);
                        Console.WriteLine($"Результат умножения комплексных чисел {complex1} и {complex2} = {complex5}");

                        Complex complex6 = Complex.Division(complex1, complex2);
                        Console.WriteLine($"Результат деления комплексных чисел {complex1} и {complex2} = {complex6}");
                        Console.ReadLine();
                        #endregion
                        #region Готовимся к переходу в стартовое меню
                        Outputhelpers.BackToMenu();
                        #endregion
                        break;

                    default:
                        Console.WriteLine("Вы ввели некорректный номер задачи.\nПовторите ввод.");
                        break;

                }

            }


        }
        static void Main(string[] args)
        {

            


            bool f = true;



            while (f)
            {
                Outputhelpers.PrintInfo(3, "Николаева Антонина Викторовна");
                Console.WriteLine("Меню домашней работы");
                Console.WriteLine("=================================");
                Console.WriteLine("1 -> Задача 1: Дописать структуру Complex и класс Complex. Продемонстрировать работу структуры и класса.");
                Console.WriteLine("2 -> Задача 2: С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse.");
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

    }
}
