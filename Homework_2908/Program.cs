// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.Clear();
// Console.WriteLine("Введите число А: ");
// int A = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите число B: ");
// int B = int.Parse(Console.ReadLine());

// int NatPowOfNum()
// {
//     int n = 1;
//     int result = A;
//     while (n < B)
//     {
//         result = result * A;
//         n++;
//     }
//     return result;
// }
// Console.WriteLine("Число " + A + " в степени " + B + " равняется " + NatPowOfNum());


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.Clear();
// Console.WriteLine("Введите число: ");
// int A = int.Parse(Console.ReadLine());
// int SumDigit()
// {
//     int result = 0;
//     int result1 = 0;
//     for (int i = 0; i <= A; i++)
//     {
//         result = A % 10;
//         result1 = result1 + result;
//         A = A / 10;
//     }
//     return result1;
// }

// Console.WriteLine("Сумма цифр в числе " + A + " равна " + SumDigit());

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// Console.Clear();
// int[] array = new int[8];
// Random rand = new Random();
// Console.Write("[");
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = rand.Next(0, 30);
//     Console.Write(array[i]);
//     Console.Write(", ");
// }
// Console.Write("]");

// Необязательная к выполнению задача (не будет влиять на итоговую оценку ДЗ)
// Дополнительная задача (задача со звёздочкой): Напишите программу, которая задаёт массив из 10 элементов, которые необходимо 
// заполнить случайными значениями в диапазоне от -10 до 10 и найти максимальное значение среди них
// [-1, 2, 4, 6, -7, 9, -3, -4, -6 ,1] -> 9
// [-5, 1, -9, 6, -7, -2, -3, -4, -6 ,1] -> 6
// [-7, 2, 4, 6, -7, 7, -3, -4, -2 ,1] -> 7

// Console.Clear();
// int[] array = new int[10];
// Random rand = new Random();
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = rand.Next(-10, 11);
//     Console.Write(array[i]);
//     Console.Write(", ");
// }
// Console.WriteLine();
// Array.Sort(array);
// int maxValue = array[array.Length-1];
// Console.WriteLine("Максимальный элемент массива " + maxValue);