using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//зубчатые, многомерные массивы


namespace CS_Lesson_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();

            //p.Task_1();
            //p.Task_2();
            //p.Task_3();
            //p.Task_4();
            //p.Task_5();
            p.Task_6();
        }

        private void Task_1()
        {
            //одномерный массив 
            int[] arr1D = new int[3] { 1, 2, 3 };

            // многомерный массив
            int[,] arr2D = new int[16, 16];

            // зубчатый массив
            int[][] arr2D_jagged = new int[2][];
            arr2D_jagged[0] = new int[] { 1, 2, 3 };
            arr2D_jagged[1] = new int[] { 4, 5, 6, 7 };
            Console.WriteLine(arr2D_jagged[1][0]);      // 4
            int sum = 0;
            foreach (int el in arr1D)
            {
                sum += el;
            }
            Console.WriteLine(sum); // 6
        }

        // enum (перечисление)
        enum DaysOfWeek{ Monday = 5, Tuesday = 10, Wedsday, Thusday, Friday, Saturday, Sunday }
        private void Task_2()
        {
            // объявление строки
            string str;

            DaysOfWeek day = DaysOfWeek.Monday;

            Console.WriteLine(day);

            Random rnd = new Random();
            int RandomNum = rnd.Next(1, 10);
        }

        private void Task_3()
        {
            Random rnd = new Random();
            int RandomNum = rnd.Next(1, 10);
            int[] arr_ = new int[10];
            for (int i = 0; i < arr_.Length; i++)
            {
                arr_[i] = rnd.Next(1, 10);
                Console.Write(arr_[i]+" ");
            }
            Console.WriteLine();
            int countOfOdd = 0;
            int countOfEven = 0;
            foreach(int el in arr_)
            {
                if((el&1) == 1)
                {
                    countOfOdd++;
                }
                else
                {
                    countOfEven++;
                }
            }
            int count = 0;
            int countOfUniq = 0;
            for(int i = 0; i < arr_.Length; i++)
            {
                for(int j = 0; j < arr_.Length; j++)
                {
                    if(i == j)
                    {
                        continue;
                    }
                    if (arr_[i] == arr_[j])
                    {
                        count++;
                        break;
                    }
                }
                if (count == 0)
                {
                    countOfUniq++;
                }
                count = 0;
            }
            Console.WriteLine("Количество нечётных чисел - " + countOfOdd
                + "\nКоличество чётных чисел - " + countOfEven +
                "\nКоличество уникальных чисел - " + countOfUniq);

        }

        private void Task_4()
        {
            string str = "Hello   world!   C#   second   lesson.";
            
            string[] arrOfStr = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            
            Console.WriteLine(arrOfStr.Length);
        }

        private void Task_5()
        {
            int size = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            
            int[] arr_ = new int[size];
            for (int i = 0; i < arr_.Length; i++)
            {
                arr_[i] = rnd.Next(1, 10);
                Console.Write(arr_[i] + " ");
            }
            int min = arr_[0];
            int max = arr_[0];
            for(int i = 1; i < arr_.Length; i++)
            {
                if(min > arr_[i])
                {
                    min = arr_[i];
                }
                if(max < arr_[i])
                {
                    max = arr_[i];
                }
            }
            Console.WriteLine("\nmin = " + min + "\nmax = " + max);
        }

        private void Task_6()
        {
            int sizeCol = Convert.ToInt32(Console.ReadLine());
            int sizeStr = Convert.ToInt32(Console.ReadLine());
            int[,] arr2D = new int[sizeStr, sizeCol];
            Random rnd = new Random();
            
            for (int i = 0; i < sizeStr; i++)
            {
                for (int j = 0; j < sizeCol; j++)
                {
                    arr2D[i, j] = rnd.Next(1, 50);
                    Console.Write(arr2D[i, j] + " ");
                }
                Console.WriteLine();
            }
            int min = arr2D[0, 0];
            int max = arr2D[0, 0];

            for (int i = 0; i < sizeStr; i++)
            {
                for(int j = 0; j < sizeCol; j++)
                {
                    if (min > arr2D[i, j])
                    {
                        min = arr2D[i, j];
                    }
                    if (max < arr2D[i, j])
                    {
                        max = arr2D[i, j];
                    }
                }
            }
            Console.WriteLine("\nmin = " + min + "\nmax = " + max);
        }


    }
}


