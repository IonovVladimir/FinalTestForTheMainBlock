using System;
using System.Drawing;

internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        //Задача: Написать программу, которая из имеющегося массива строк
        //формирует новый массив из строк, длина которых меньше,
        //либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
        //либо задать на старте выполнения алгоритма. При решении не рекомендуется
        //пользоваться коллекциями, лучше обойтись исключительно массивами.

        //функция чтения с консоли и перевода в целые числа
        int InputStrToInt(string text) 
        {
            Console.WriteLine(text);
            return Convert.ToInt32(Console.ReadLine()); 
        }

        //функция заполнения массива с консоли (работает ли?)
        void FillStrArray(string[] strAr, int n ) 
        {
            for (int i = 0; i < n; i++) 
            {
                Console.WriteLine($"Введи {i} элемент массива");
                strAr[i] = Console.ReadLine();
            }
        }

        //функция вывода элементов массива
        void PrintStrArray(string[] strAr, int n) 
        {
            for (int i = 0; i < n; i++) 
            { 
                Console.WriteLine($"{i}: {strAr[i]} ");
            }
        }

       
        int n = InputStrToInt("Введи размер входного массива = ");
        Console.WriteLine($"Входной массив состоит из {n} элементов.");
        string[] strAr = new string[n];

        FillStrArray(strAr, n );
        Console.WriteLine();
        Console.WriteLine("~~~~~~~~~");
        Console.WriteLine();
        PrintStrArray(strAr, n);

        //продолжение
        Console.WriteLine("~~~~~~~~~");

        string[] strNewArr = new string[n];
        int m = InputStrToInt("Введи ограничение по количеству символов = ");
        int count = 0;

        for (int i = 0; i < n; i++) 
        {
            if (strAr[i].Length <= m) 
            {
                strNewArr[count] = strAr[i];
                count++;
            }
        }

        PrintStrArray(strNewArr, count);



    }
}