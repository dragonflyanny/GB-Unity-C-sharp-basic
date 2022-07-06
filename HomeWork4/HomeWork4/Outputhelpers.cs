using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw.Utils
{
    public class Outputhelpers
    {
        /// <summary>
        /// Вывод информации о студенте и номере урока на экран
        /// </summary>
        /// <param name="homeworkNumber">Номер урока</param>
        /// <param name="fio">ФИО</param>
        public static void PrintInfo(int homeworkNumber, string fio)
        {
            Console.WriteLine($"Домашняя работа. Урок {homeworkNumber}");
            Console.WriteLine($"Студент {fio}");
            Console.WriteLine("=================================");
            Console.WriteLine();
        }

        /// <summary>
        /// Остановка программы для чтения. Содержит ==== в начале для удобства
        /// </summary>
        public static void Pause ()
        {
            Console.WriteLine();
            Console.WriteLine("=======================");
            Console.WriteLine("Нажмите любую кнопку для продолжения");
            Console.ReadKey();
        }

        /// <summary>
        /// Информация о выполняемом задании
        /// </summary>
        /// <param name="taskNumber">Номер задания</param>
        /// <param name="taskDescroption">Описание и условия задачния</param>
        public static void TaskInfo( int taskNumber, string taskDescroption)
        {
            Console.WriteLine("=======================");
            Console.WriteLine($"Выполнение задачи {taskNumber} - {taskDescroption}");
            Console.WriteLine("=======================");
        }

        /// <summary>
        /// Возвращение в основное меню
        /// </summary>
        public static void BackToMenu()
        {
            Console.WriteLine("Возвращение в основное меню. Нажмите любую клавишу");
            Console.ReadLine();
            Console.Clear();
        }


        public static bool IsOdd(int n)
        {
            return n % 2 == 0;
        }


    }
}