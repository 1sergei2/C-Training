﻿// Вид 1
// void Method1 ()
// {
//     Console.WriteLine("Автор...");
// }
// Method1 ();

// Вид 2
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2(msg: "Текст сообщения");

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// // Method21(msg: "Текст", count: 4);
// Method21(count: 4, msg: "Текст 2");

// Вид 3

// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);

// Вид 4

// string Method4(int count, string c)
// {
//     int i = 0;
//     string result = String.Empty;
//     while (i<count)
//     {
//         result = result + c;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "qwerty ");
// Console.WriteLine(res);

// string Method4(int count, string c)
// {
//     string result = String.Empty;
//     for (int i = 0; i<count; i++)
//     {
//         result = result + c;
//     }
//     return result;
// }
// string res = Method4(10, "qwerty ");
// Console.WriteLine(res);

// for (int i = 2; i <= 9; i++)
// {
//     for (int j = 2; j <= 9; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine();
// }

// ======= Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".

// string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
//             + "ежели бы вас послали вместо нашего милого Винцегероде,"
//             + "вы бы взяди приступом согласие прусского короля. "
//             + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             0123
// s[3]  // r 

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;

//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
// }
// string newText = Replace (text, ' ', '|');
// newText = Replace (newText, 'к', 'К');
// newText = Replace (newText, 'а', 'Ж');
// Console.WriteLine(newText);


// int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

// void PrintArray(int[] array)
// {
//     int count = array.Length;

//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// void SelectionSort(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int minPos = i;

//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if(array[j] < array[minPos]) minPos = j;
//         }

//         int temporary = array [i];
//         array[i] = array[minPos];
//         array[minPos] = temporary;
//     }
// }

// PrintArray(arr);
// SelectionSort(arr);
// PrintArray(arr);