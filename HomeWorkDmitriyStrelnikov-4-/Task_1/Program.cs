using System;

namespace Task_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /* Стрельников.
             * Задание №1.
             * Дан  целочисленный  массив  из 20 элементов.  Элементы  массива 
             * могут принимать  целые  значения  от –10 000 до 10 000 включительно. 
             * Заполнить случайными числами.  Написать программу, позволяющую 
             * найти и вывести количество пар элементов массива, в которых 
             * только одно число делится на 3. В данной задаче под парой 
             * подразумевается два подряд идущих элемента массива. Например, 
             * для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2.*/
            Enter(20);
            Console.ReadLine();
        }

        private static int[] Start(int n)
        {
            int[] Arr = new int[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                Arr[i] = r.Next(-100, 101);
            }
            return Arr;
        }
        static void Enter(int n)
        {
            int[] Arr = Start(n);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(Arr[i]);
            }

            Count(n, Arr);
        }
        static void Count(int n, int[] Arr)
        {
            int sum = 0;
            for (int i = 0; i < n - 1; i++)
            {
                if ((Arr[i] % 3 == 0) && (Arr[i + 1] % 3 != 0) || (Arr[i] % 3 != 0) && (Arr[i + 1] % 3 == 0))
                    sum++;
            }

            Console.WriteLine($"Количество пар элемента массива где только один элемент делится на 3 = {sum}");
        }
    }
}