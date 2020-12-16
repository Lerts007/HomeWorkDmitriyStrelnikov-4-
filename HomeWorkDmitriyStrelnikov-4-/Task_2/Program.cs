using System;

namespace Task_2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /* Стрельников.
             * Задание №2
             * Реализуйте задачу 1 в виде статического класса StaticClass;
             * а) Класс должен содержать статический метод, который принимает 
             *    на вход массив и решает задачу 1;
             * б) *Добавьте статический метод для считывания массива из 
             *    текстового файла. Метод должен возвращать массив целых чисел;
             * в)**Добавьте обработку ситуации отсутствия файла на диске.
             */
            //StaticClass.Enter(20);
            try
            {
                FileWorker s = new FileWorker("date.txt");
                s.Print();
            }
            catch
            {

                Console.WriteLine("Файл не найден!");
            }
            Console.ReadLine();
        }
    }
}