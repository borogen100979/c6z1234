// ﻿// Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

// // Вариант 1
// string CharOfString(char[,] arr)
// {
//     string st = ""; // обязательно двойные ковычки

//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.WriteLine(i);
//             st += arr[i, j];
//         }
//     }
//     return st;
// }

// // Вариант 2
// void CharOfString2(char[,] arr)
// {
//     string st = ""; // 
//     foreach (var i in arr)
//     {
//         Console.WriteLine(i);
//         st += i; // st = st + i
//     }
//     Console.WriteLine(st);
// }


// char[,] chars = new char[,]
// {
//     { 'a', '1' },
//     { 'c', 'd' }
// };
// Console.WriteLine(CharOfString(chars));
// CharOfString2(chars);

// //Ответ
// public class Task1
// {
//     public static void Main(string[] args)
//     {
//         // Инициализация двумерного массива символов
//         char[,] charArray = new char[,] { { 'a', 'b' }, { 'c', 'd' } };
//         // Вызов метода для создания строки из 2D массива
//         string result = CreateStringFrom2DArray(charArray);
//         // Вывод результата
//         Console.WriteLine(result);
//     }
//     // Метод для создания строки из двумерного массива символов
//     public static string CreateStringFrom2DArray(char[,] array)
//     {
//         string result = "";
//         // Цикл по каждому элементу в двумерном массиве
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 // Добавление каждого символа в результирующую строку
//                 result += array[i, j];
//             }
//         }
//         return result;
//     }
// }


﻿// Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

// string text = "gdsKGF34!-0";
// string result = text.ToLower();
// Console.Write(result);


// public class Task2
// {
//     public static void Main(string[] args)
//     {
//         // Входная строка со смешанными буквами обоих регистров
//         string input = "aBcD1ef!-";
//         // Преобразование всех заглавных букв в строчные
//         string result = input.ToLower();
//         // Вывод результата
//         Console.WriteLine(result);
//     }
// }






// ﻿// Задайте произвольную строку. Выясните, является ли она палиндромом. 
// //(Справа на лево и слева на право читается одинаково).

// using System.Text;
// Console.InputEncoding = Encoding.Unicode;
// Console.OutputEncoding = Encoding.Unicode;

// bool IsPalindrom(string str)
// {
//     bool a = false;
//     bool b = false;
//     int count = 0;
//     for (int i = 0; i < str.Length / 2; i++)
//     {
//         if (str[i] == str[str.Length - i - 1])
//         {
//             a = true;
//             if (a)
//             {
//                 count++;
//             }
//         }
//     }
//     if (count == str.Length / 2)
//     {
//         b = true;
//     }
//     return b;
// }

// void Print(bool str)
// {
//     if (str)
//     {
//         Console.WriteLine("Да");
//     }
//     else
//     {
//         Console.WriteLine("Нет");
//     }
// }

// string str = "шалаш";
// bool isPalindrom = IsPalindrom(str);
// Print(isPalindrom);




﻿// Задайте строку, состоящую из слов, разделенных пробелами. 
// Сформировать строку, в которой слова расположены в обратном порядке. 
// В полученной строке слова должны быть также разделены пробелами.

string[] GetInvertedArray(string[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        (array[array.Length - 1 - i], array[i]) = (array[i], array[array.Length - 1 - i]);
    }
    return array;
}

void ShowArray(string[] col)
{
    foreach (string item in col)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();

}

string str = "Hello my world";
string[] arr = str.Split(" ");

string[] res = GetInvertedArray(arr);
ShowArray(res);


