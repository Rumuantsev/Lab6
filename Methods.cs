﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{

    public class Methods
    {
        public static string[] TimeResult = new string[5];
        public static double[] BubbleSort(double[] Array)
        {
            
            var BubbleWatch = new Stopwatch();
            BubbleWatch.Start();

            double Buffer;
            for (int CurrentElement = 0; CurrentElement < Array.Length; CurrentElement++)
            {
                for (int NextElement = CurrentElement + 1; NextElement < Array.Length; NextElement++)
                {
                    if (Array[CurrentElement] > Array[NextElement])
                    {
                        Swap(Array, CurrentElement, NextElement);
                    }
                }
            }

            BubbleWatch.Stop();
            double time = BubbleWatch.ElapsedTicks;
            TimeResult[0] = Convert.ToString(time);

            return Array;
        }
        public static double[] InsertSort(double[] Array)
        {
            var InsertWatch = new Stopwatch();
            InsertWatch.Start();

            for (int IndexCurrent = 1; IndexCurrent < Array.Length; ++IndexCurrent)  //берем элемент
            {
                double ElementCurrent = Array[IndexCurrent];
                int IndexPrevious = IndexCurrent - 1;

                while (IndexPrevious >= 0 && Array[IndexPrevious] > ElementCurrent) //cравниваем со всеми предыдущими, пока не найдём мето для вставки элемента
                {
                    Array[IndexPrevious + 1] = Array[IndexPrevious];
                    Array[IndexPrevious] = ElementCurrent;
                    --IndexPrevious;
                }
            }
            InsertWatch.Stop();
            double time = InsertWatch.ElapsedTicks;
            TimeResult[1] = Convert.ToString(time);

            return Array;
        }
        //Метод для нахождения основного элемена для быстрой сортировки
        public static int FindMainElement(double[] Numbers, int minIndex, int maxIndex)
        {
            int MainElement = minIndex - 1;
            double temp = 0;

            for (int ArrayIndex = minIndex; ArrayIndex < maxIndex; ++ArrayIndex)
            {
                if (Numbers[ArrayIndex] < Numbers[maxIndex])
                {
                    ++MainElement;
                    temp = Numbers[MainElement];
                    Numbers[MainElement] = Numbers[ArrayIndex];
                    Numbers[ArrayIndex] = temp;
                }
            }

            ++MainElement;
            temp = Numbers[MainElement];
            Numbers[MainElement] = Numbers[maxIndex];
            Numbers[maxIndex] = temp;

            return MainElement;
        }
        //Основная функция быстрой сортировки
        public static double[] FastSort(double[] Numbers, int minIndex, int maxIndex)
        {
            //Граничное условие, при котором функция останавливается
            if (minIndex >= maxIndex)
            {
                return Numbers;
            }

            int pivot = FindMainElement(Numbers, minIndex, maxIndex);
            //Сортировка для элементов перед основным элементом
            FastSort(Numbers, minIndex, pivot - 1);
            //Сортировка для элементов после основного элемента
            FastSort(Numbers, pivot + 1, maxIndex);
            return Numbers;
        }
        public static void Swap(double[] array, int i, int j)
        {
            double temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
        public static double[] ShakerSort(double[] Array)
        {
            int left = 0,
                 right = Array.Length - 1;
            while (left < right)
            {
                for (int i = left; i < right; i++)
                {
                    if (Array[i] > Array[i + 1])
                        Swap(Array, i, i + 1);
                }
                right--;
                for (int i = right; i > left; i--)
                {
                    if (Array[i - 1] > Array[i])
                        Swap(Array, i - 1, i);
                }
                left++;
            }
            return Array;
        }
        //Проверка упорядоченности массива для болотной сортировки
        public static bool IsSorted(double[] array)
        {
            for (int ArrayIndex = 0; ArrayIndex < array.Length - 1; ArrayIndex++)
            {
                if (array[ArrayIndex] > array[ArrayIndex + 1])
                    return false;
            }
            return true;
        }

        
        public static double[] BogoSort(double[] Array)
        {
            var BogoWatch = new Stopwatch();
            BogoWatch.Start();
            while (!IsSorted(Array))
            {
                //Перемешивание элементов массива
                Random random = new Random();
                int MaxIndex = Array.Length;
                while (MaxIndex > 1)
                {
                    --MaxIndex;
                    int ArrayIndex = random.Next(MaxIndex + 1);
                    double temp = Array[ArrayIndex];
                    Array[ArrayIndex] = Array[MaxIndex];
                    Array[MaxIndex] = temp;
                }
            }
            BogoWatch.Stop();
            double time = BogoWatch.ElapsedTicks;
            TimeResult[4] = Convert.ToString(time);

            return Array;
        }


    }
}



