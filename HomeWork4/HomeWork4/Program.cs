using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hw.Utils;

namespace HomeWork3
{

    class StaticClass
    {
        #region Private Fields

        private int[] a;

        #endregion
        #region Public Properties

        public int this[int index]
        {
            get
            {
                return a[index];
            }

            set
            {
                a[index] = value;
            }
        }


        #endregion
        public StaticClass(int[] array)
        {
            this.a = array;
        }
        public StaticClass(int n, int min, int max)
        {
            a = new int[n];
            Random rnd = new Random();

        for (int i = 0; i < n; i++)
                a[i] = rnd.Next(min, max);
        }
        public StaticClass(string fileName)
        {
            a = LoadArrayFromFile(fileName);
        }

        public override string ToString()
        {
            string s = "";
            foreach (int v in a)
                s = s + v + " ";
            return s;
        }

        public int CountPairs3
        {
            get
            {
                int count = 0;
                for (int i = 1; i < a.Length; i++)
                    if 

                        (a[i-1] % 3 == 0 || a[i] % 3 == 0) count++;

                return count;
            }
        }
        private int[] LoadArrayFromFile(string fileName)
        {
            if (!File.Exists(fileName))
                throw new FileNotFoundException();

            // StreamReader StreamWriter

            int[] buf = new int[1000];

            StreamReader streamReader = new StreamReader(fileName);

            //streamReader.EndOfStream
            //streamReader.ReadLine();

            int counter = 0;
            while (!streamReader.EndOfStream)
            {
                buf[counter] = int.Parse(streamReader.ReadLine());
                counter++;
            }

            int[] arr = new int[counter];
            Array.Copy(buf, arr, counter);
            streamReader.Close();
            return arr;
        }

    }





internal class Program
    {

        static void Main(string[] args)
        {




            bool f = true;



            while (f)
            {
                Outputhelpers.PrintInfo(4, "Николаева Антонина Викторовна");
                Console.WriteLine("Меню домашней работы");
                Console.WriteLine("=================================");
                Console.WriteLine("1 -> Задача 1: Дан целочисленный массив из 20 элементов.");
                Console.WriteLine("2 -> Задача 2: Дан целочисленный массив из 20 элементов. Реализовать в виде статического класса StaticClass.");
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

        static void Task1()
        {
            #region "Шапка" задачи
            Console.Clear();
            Outputhelpers.PrintInfo(4, "Николаева Антонина Викторовна");
            Outputhelpers.TaskInfo(1, "Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно. " +
                "Заполнить случайными числами. Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится " +
                "на 3. В данной задаче под парой подразумевается два подряд идущих элемента массива.");
            #endregion

            int n = 20;
            int min = -10000;
            int max = 10000;
            int[] arr;
            arr = new int[n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
                arr[i] = rnd.Next(min, max);

            for (int i = 0; i < 20; i++)
            {
                Console.Write($"{arr[i]}\t");
            }
            Console.WriteLine();
            Console.WriteLine("В данном массиве есть пар чисел, где только одно число делится на 3:");
            int count = 0;
            for (int i = 1; i < arr.Length; i++)
                if

                    (arr[i - 1] % 3 == 0 || arr[i] % 3 == 0 ) count++;
            Console.WriteLine(count);








            #region Готовимся к переходу в стартовое меню
            Outputhelpers.BackToMenu();
            #endregion

        }


        static void Task2()
        {

            #region "Шапка" задачи
            Console.Clear();
            #endregion

            bool f = true;



            while (f)
            {
                Console.Clear();
                Outputhelpers.PrintInfo(4, "Николаева Антонина Викторовна");
                Console.WriteLine("Задание 2 - Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно. " +
                "Заполнить случайными числами. Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится " +
                "на 3. В данной задаче под парой подразумевается два подряд идущих элемента массива. Реализуйте задачу 1 в виде статического класса StaticClass;");
                Console.WriteLine("=================================");
                Console.WriteLine("1 -> Подзадача 1: Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1.");
                Console.WriteLine("2 -> Подзадача 2: Добавьте статический метод для считывания массива из текстового файла.Метод должен возвращать массив целых чисел.");
                Console.WriteLine("3 -> Подзадача 3: Добавьте обработку ситуации отсутствия файла на диске.");
                Console.WriteLine("0 -> Возвращение в основное меню");
                Console.WriteLine("=================================\n");

                Console.Write("Введите номер подзадачи: ");

                int number = int.Parse(Console.ReadLine());

                switch (number)
                {
                    case 0:
                        Outputhelpers.BackToMenu();
                        f = false;
                        break;

                    case 1:
                        Task21();
                        Console.WriteLine();
                        break;

                    case 2:
                        Task22();
                        Console.WriteLine();
                        break;

                    case 3:
                        Task23();
                        Console.WriteLine();
                        break;

                    default:
                        Console.WriteLine("Вы ввели некорректный номер задачи.\nПовторите ввод.");
                        break;

                }

            }







        }
        static void Task21()
        {
            #region "Шапка" задачи
            Console.Clear();
            Outputhelpers.PrintInfo(4, "Николаева Антонина Викторовна");
            Console.WriteLine("Подзадача 1: Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1.");
            #endregion

            StaticClass array1 = new StaticClass(20, -10000, 10000);
            Console.WriteLine(array1.ToString());
            Console.WriteLine("В данном массиве есть пар чисел, где только одно число делится на 3:");
            Console.WriteLine(array1.CountPairs3);


            #region Готовимся к переходу в стартовое меню
            Outputhelpers.BackToMenu();
            #endregion

        }

        static void Task22()
        {
            #region "Шапка" задачи
            Console.Clear();
            Outputhelpers.PrintInfo(4, "Николаева Антонина Викторовна");
            Console.WriteLine("Подзадача 2: Добавьте статический метод для считывания массива из текстового файла.Метод должен возвращать массив целых чисел.");
            #endregion


            StaticClass array2 = new StaticClass(AppDomain.CurrentDomain.BaseDirectory + "ArrayList.txt");
            Console.WriteLine(array2);


            #region Готовимся к переходу в стартовое меню
            Outputhelpers.BackToMenu();
            #endregion

        }

        static void Task23()
        {
            #region "Шапка" задачи
            Console.Clear();
            Outputhelpers.PrintInfo(4, "Николаева Антонина Викторовна");
            Console.WriteLine("Подзадача 3: Добавьте обработку ситуации отсутствия файла на диске.");
            #endregion

            Console.WriteLine("Проверка обработки ситуации отсутствия файла на диске. После нажатия любой клавиши будет проведена попытка запуска метода считывания " +
                            "массива из текстового файла с некорректным названием - ArrayListErr.txt. Это приведет к вылетанию программы с ошибкой.");
            Console.ReadLine();
            StaticClass array3 = new StaticClass(AppDomain.CurrentDomain.BaseDirectory + "ArrayListErr.txt");


            #region Готовимся к переходу в стартовое меню
            Outputhelpers.BackToMenu();
            #endregion

        }


    }

}