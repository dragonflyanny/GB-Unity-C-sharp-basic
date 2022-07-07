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
    public static class Message
    {
        private static string[] separators = { ",", ".", "!", "?", ";", ":", " ", "-" };

        public static void PrintWords(string message)
        {
            string[] words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 3 && words[i][0] == words[i][words[i].Length - 1])
                {
                    Console.WriteLine(words[i]);
                }
            }

        }
        public static void PrintWordsMoreN(string message, byte n)
        {
            string[] words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length <= n)
                {
                    Console.WriteLine(words[i]);
                }
            }

        }


        public static void PrintWordsEnd(string message, char smb)
        {
            string[] words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            StringBuilder result = new StringBuilder("");
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i][words[i].Length - 1] != smb)
                {

                    result.Append(words[i]+" ");
                }



            }
            Console.WriteLine(result);
        }


        public static void PrintWordsMax(string message)
        {
            string[] words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder result = new StringBuilder("");
            int aaa=0;
            for (int i = 0; i < words.Length; i++)
            {

                if (aaa < words[i].Length) 
                {
                    aaa = words[i].Length;
                    result.Clear(); 
                    result.Append(words[i] + " ");

                }
                else if (aaa == words[i].Length)
                {
                    result.Append(words[i] + " ");
                }
            }
            Console.WriteLine(result);
        }

        public static void PrintWordsMaxStr(string message)
        {
            string[] words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder result = new StringBuilder("");
            StringBuilder krasota = new StringBuilder("");
            int aaa = 0;
            for (int i = 0; i < words.Length; i++)
            {

                if (aaa < words[i].Length)
                {
                    aaa = words[i].Length;
                    result.Clear();
                    result.Append(words[i] + " ");

                }
                else if (aaa == words[i].Length)
                {
                    result.Append(words[i] + " ");
                }
            }
            krasota.Append("Сейчас будут выведены все самые длинные слова в сообщении: " + result);
            Console.WriteLine(krasota);
        }
    }



    internal class Program
    {

        static void Main(string[] args)
        {




            bool f = true;



            while (f)
            {
                Outputhelpers.PrintInfo(5, "Николаева Антонина Викторовна");
                Console.WriteLine("Меню домашней работы");
                Console.WriteLine("=================================");
                Console.WriteLine("1 -> Задача 1: Создать программу, которая будет проверять корректность ввода логина.");
                Console.WriteLine("2 -> Задача 2: Разработать статический класс Message.");
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
            #endregion

            bool f = true;



            while (f)
            {
                Console.Clear();
                Outputhelpers.PrintInfo(5, "Николаева Антонина Викторовна");
                Outputhelpers.TaskInfo(1, "Создать программу, которая будет проверять корректность ввода логина. Корректным логином " +
                    "будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой.");
                Console.WriteLine("=================================");
                Console.WriteLine("1 -> Попробовать создать логин.");
                Console.WriteLine("0 -> Возвращение в основное меню");
                Console.WriteLine("=================================\n");

                Console.Write("Введите номер подзадачи: ");


                int number1 = int.Parse(Console.ReadLine());

                switch (number1)
                {
                    case 0:
                        Outputhelpers.BackToMenu();
                        f = false;
                        break;

                    case 1:
                        Task11();
                        Console.WriteLine();
                        break;


                    default:
                        Console.WriteLine("Вы ввели некорректный номер задачи.\nПовторите ввод.");
                        break;

                }

            }
        }

        static void Task11()
        {
            #region "Шапка" задачи
            Console.Clear();
            Outputhelpers.PrintInfo(5, "Николаева Антонина Викторовна");
            Outputhelpers.TaskInfo(1, "Создать программу, которая будет проверять корректность ввода логина. Корректным логином " +
                "будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой.");
            #endregion
            Console.WriteLine("Пожалуйста, введите придуманный лог. Корректным логином будет строка от 2 до 10 символов, содержащая только " +
                "буквы латинского алфавита или цифры, при этом цифра не может быть первой.");
            string str = Console.ReadLine();

            char[] arr;

            int err1;
            bool ValidCharsFound(string string1)
            {
                string pattern = @"[a-zA-Z0-9]";
                return Regex.IsMatch(string1, pattern);
            }
            bool r = ValidCharsFound(str);

            err1 = 0;
            UnicodeCategory category = char.GetUnicodeCategory(str[0]);
            if (category == UnicodeCategory.DecimalDigitNumber)
            {
                Console.WriteLine("Первым символом является цифра, нарушение правила составления логина");
                err1++;
            }



           



            if (r == false)
            {
                
                Console.WriteLine("Введенные символы не соответствуют правилу составления логина, пожалуйста, перечитайте правила");
                err1++;
            }


            if (str.Length > 1 && str.Length < 11) Console.WriteLine($"Длина логина {str.Length} - корректна.");

                else{
                Console.WriteLine($"Длина логина {str.Length} - нарушение правила составления логина.");
                                err1++;
            }
                
            if (err1==0) Console.WriteLine($"Нарушений правил составления логина не выявлено, логин корректен!.");
            else Console.WriteLine($"Допущено {err1} нарушений правил составления логина, попробуйте снова.");



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
                Outputhelpers.PrintInfo(5, "Николаева Антонина Викторовна");
                Outputhelpers.TaskInfo(2, "Разработать статический класс Message, содержащий следующие статические методы для обработки текста:");
                Console.WriteLine("=================================");
                Console.WriteLine("1 -> Подзадача 1: Вывести только те слова сообщения, которые содержат не более n букв.");
                Console.WriteLine("2 -> Подзадача 2: Удалить из сообщения все слова, которые заканчиваются на заданный символ.");
                Console.WriteLine("3 -> Подзадача 3: Найти самое длинное слово сообщения.");
                Console.WriteLine("4 -> Подзадача 4: Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.");
                Console.WriteLine("0 -> Возвращение в основное меню");
                Console.WriteLine("=================================\n");

                Console.Write("Введите номер подзадачи: ");


                int number1 = int.Parse(Console.ReadLine());

                switch (number1)
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

                    case 4:
                        Task24();
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
            Outputhelpers.PrintInfo(5, "Николаева Антонина Викторовна");
            Outputhelpers.TaskInfo(2, "Разработать статический класс Message, содержащий следующие статические методы для обработки текста:");
            Console.WriteLine("Подзадача 1: Вывести только те слова сообщения, которые содержат не более n букв.");
            #endregion
            Console.WriteLine("Введите строку из нескольких слов:");
            string message = Console.ReadLine();
            Console.WriteLine("Будут выведены лишь те слова, в которых не более n букв. Введите значение n (больше 0, меньше 255)");
            string strn = Console.ReadLine();
            byte n;
            n = Convert.ToByte(strn);
            Console.WriteLine("Слова, в которых не более " + n + " букв:");
            Message.PrintWordsMoreN(message, n);


            #region Готовимся к переходу в стартовое меню
            Outputhelpers.BackToMenu();
            #endregion

        }

        static void Task22()
        {
            #region "Шапка" задачи
            Console.Clear();
            Outputhelpers.PrintInfo(5, "Николаева Антонина Викторовна");
            Outputhelpers.TaskInfo(2, "Разработать статический класс Message, содержащий следующие статические методы для обработки текста:");
            Console.WriteLine("Подзадача 2: Удалить из сообщения все слова, которые заканчиваются на заданный символ.");
            #endregion
            Console.WriteLine("Введите строку из нескольких слов:");
            string message = Console.ReadLine();
            Console.WriteLine("Из сообщения будут удалены слова, которые заканчиваются на указанный символ. Укажите символ:");
            char smb;
            smb = char.Parse(Console.ReadLine());
            Console.WriteLine("Слова, которые не заканчиваются на " + smb);
            Message.PrintWordsEnd(message, smb);




            #region Готовимся к переходу в стартовое меню
            Outputhelpers.BackToMenu();
            #endregion

        }

        static void Task23()
        {
            #region "Шапка" задачи
            Console.Clear();
            Outputhelpers.PrintInfo(5, "Николаева Антонина Викторовна");
            Outputhelpers.TaskInfo(2, "Разработать статический класс Message, содержащий следующие статические методы для обработки текста:");
            Console.WriteLine("Подзадача 3: Найти самое длинное слово сообщения.");
            #endregion
            
            Console.WriteLine("Введите строку из нескольких слов. Пожалуйста, вводите слова разной длины");
            string message = Console.ReadLine();

            Message.PrintWordsMax(message);

            #region Готовимся к переходу в стартовое меню
            Outputhelpers.BackToMenu();
            #endregion

        }

        static void Task24()
        {
            #region "Шапка" задачи
            Console.Clear();
            Outputhelpers.PrintInfo(5, "Николаева Антонина Викторовна");
            Outputhelpers.TaskInfo(2, "Разработать статический класс Message, содержащий следующие статические методы для обработки текста:");
            Console.WriteLine("Подзадача 4: Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.");
            #endregion

            Console.WriteLine("Введите строку из нескольких слов. Пожалуйста, вводите слова разной длины");
            string message = Console.ReadLine();

            Message.PrintWordsMaxStr(message);


            #region Готовимся к переходу в стартовое меню
            Outputhelpers.BackToMenu();
            #endregion

        }




    }

}