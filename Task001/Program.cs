// //Void : нет оператора return

// // тип_возр_значения имя (параметры)
//      int Calculate (int a , int b, char sing) // на вход подаются два числа, 3 параметр : знак (*;/; +; -)
//      {
//         int result = 0;
//         // для char одинарные ковычки, для остального ""
//         if (sing == '*')
//         {
//             result = a * b;
//         }
//         else if (sing == '+' )
//         {
//             result = a+b;
//         }
//         else if (sing == '-')
//         {
//             result = a-b;
//         }
//         else
//         {
//             Console.WriteLine("Обработка искл. :такого знака нет");
//         }
//         return result ;
//      }

// System.Console.WriteLine(Calculate(3,5, '+'));
// System.Console.WriteLine(Calculate(2,6, '*'));
// System.Console.WriteLine(Calculate(7,2, '-'));
// System.Console.WriteLine(Calculate(3,5, '_'));
//=======================================
// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

//Без метода

// System.Console.WriteLine("Введите число А: ");
// // limit - искомое число А
// int limit = Convert.ToInt32(System.Console.ReadLine());
// int sum = 0;
// for (int i = 1; i<= limit; i++)
// {
//     sum = sum + i; // это можно записать как "sum += i"
// }
// Console.WriteLine($"сумма чисел от 1 до {limit} = {sum}");

// //хардкор
// System.Console.WriteLine("Введите число A: ");
// int limit = Convert.ToInt32(Console.ReadLine());
// int GetSum(int A)// A = limit
// {
//      int sum = 0;
//     for (int i = 1; i<= limit; i++)
//     {
//         sum = sum + i; // это можно записать как "sum += i"
//     }
//     return sum;
// }
// Console.WriteLine($"Сумма чисел от 1 до {limit} = {GetSum(limit)}");

//------------------
// // Метод для получения факториала
// System.Console.WriteLine("Введите число A: ");
// int limit = Convert.ToInt32(Console.ReadLine());
// int GetFactorial(int A)// A = limit
// {
//     int fuctorial = 1;
//     for (int i = 1; i <= limit; i++)
//     {
//         fuctorial = fuctorial * i; // это можно записать как "fuctorial += i"
//     }
//     return fuctorial;
// }
// Console.WriteLine($"Факториал числа {limit} = {GetFactorial(limit)}");
//================

//Определить массив из 8 чисел с нулями и единицами в случайном порядке

// void FillArray(int[] collection)//определили массив из 10-ти элементов
// //Наполнение массива случайными числами
// {
//     int Length = collection.Length;
//     int index = 0;
//     while (index < Length)
//     {
//         collection[index] = new Random().Next(2);
//         index++;
//     }
// }

// void PrintArray(int[] col)//Вывел\распечатал массив в терминал
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.WriteLine(col[position]);
//         position++;
//     }
// }
/// Метод преподавателя ниже
int[] GetBinaryArray(int size)
{
    int[] array = new int[size]; // Получается массив на size(8) элементов
    // Массив состоит из 8 нулей
    // size = array.Length
    for (int i = 0; i < size; i++)
    {
        // array[i] = new Random().Next(0,2);
        array[i] = new Random().Next(2); // [0;1]
        // array[0] = 0, array[1] = 0, array[2] = 0
    }
    return array;
}

int[] resultArray = GetBinaryArray(8);
double[] test = new double[10]; 

// for (int i = 0; i < resultArray.Length; i++) //аналогичный способ вывода
// {
//     Console.Write(resultArray[i] + "\t"); //аналогичный способ вывода
// }

System.Console.WriteLine($"Массив : [ {String.Join(": ", resultArray)} ]");