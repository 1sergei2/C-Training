using static System.Console;

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Clear();
// double [,] array = GetArray(3, 4, -10, 10);
// double [,] GetArray(int m, int n, double min, double max){
//     double [,] result = new double[m, n];
//     for (int i = 0; i < m; i++){
//         for (int j = 0; j < n; j++){
//             result[i, j] = new Random().NextDouble()*20-10;
//         }
//     }
//     return result;
// }
// void PrintArray(double[,] inArray){
//     for (int i = 0; i < inArray.GetLength(0); i++){
//         for (int j = 0; j < inArray.GetLength(1); j++){
//         double alignNumber = Math.Round(array[i, j], 1);
//         Console.Write(alignNumber + " ");
//       }
//       Console.WriteLine();
//     }
// }
// PrintArray(array);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Clear();
// Write("Введите количество строк массива (m): ");
// int m = Convert.ToInt32(Console.ReadLine());
// Write("Введите количество столбцов массива (n): ");
// int n = Convert.ToInt32(Console.ReadLine());
// Clear();
// WriteLine($"m = {m}, n = {n}.");
// int[,] array = new int[m, n];
// void GetArray(int [,] array){
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++){
//         for (int j = 0; j < n; j++){
//             array[i, j] = new Random().Next(1, 11);
//         }
//     }
// }
// GetArray(array);
// void PrintArray(int[,] inArray){
//     for (int i = 0; i < inArray.GetLength(0); i++){
//         for (int j = 0; j < inArray.GetLength(1); j++){
//             Write($"{inArray[i, j]} ");
//         }
//         WriteLine();
//     }
// }
// PrintArray(array);

// Write("Введите координаты позиции элемента, разделенные запятой: ");
// string positionElement = Console.ReadLine();
// positionElement = RemovingSpaces(positionElement);
// int[] position = ParserString(positionElement);

// if(position[0] <= m 
// && position[1] <= n 
// && position[0] >= 0 
// && position[1] >= 0) 
// {
//   double result = array[position[0]-1, position[1]-1];
//   Console.Write($"Значение элемента: {result}");
// }
// else Console.Write($"Такого элемента в массиве нет.");

// int[] ParserString(string input){
//   int countNumbers = 1;
//   for (int i = 0; i < input.Length; i++){
//       if (input[i] == ',')
//           countNumbers++;
//   }
//   int[] numbers = new int[countNumbers];
//   int numberIndex = 0;
//   for(int i = 0; i < input.Length; i++){
//     string subString = String.Empty;
//     while (input[i] != ','){
//       subString += input[i].ToString();
//       if (i >= input.Length - 1)
//         break;
//       i++;
//     }
//     numbers[numberIndex] = Convert.ToInt32(subString);
//     numberIndex++;
//   }

//   return numbers;
// }

// string RemovingSpaces (string input){
//   string output = String.Empty;
//   for (int i = 0; i < input.Length; i++){
//     if (input[i] != ' ') {
//       output += input[i];
//     }
//   }
//   return output;
// }



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Clear();
Write("Введите количество строк массива (m): ");
int m = Convert.ToInt32(Console.ReadLine());
Write("Введите количество столбцов массива (n): ");
int n = Convert.ToInt32(Console.ReadLine());
Clear();
int[,] array = new int[m, n];
void GetArray(int [,] array){
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            array[i, j] = new Random().Next(1, 11);
        }
    }
}
GetArray(array);
void PrintArray(int[,] inArray){
    for (int i = 0; i < inArray.GetLength(0); i++){
        for (int j = 0; j < inArray.GetLength(1); j++){
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
}
PrintArray(array);
Console.Write($"\nCреднее арифметическое:\n");
for (int i = 0; i < n; i++){
  double arithmeticMean = 0;
  for (int j = 0; j < m; j++){
    arithmeticMean += array[j, i];
  }
  arithmeticMean = Math.Round(arithmeticMean / m, 1);
  Console.WriteLine($"столбца № {i+1} {arithmeticMean}");
}