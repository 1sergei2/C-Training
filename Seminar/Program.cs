// void PrintNumbers(int num1, int num2)
// {
//     // for (int i = num1; i < num2 + 1; i++) Console.Write($"{i}, ");
//     for (int i = num1; i < num2 + 1; i++) Console.Write(i + ", ");
//     Console.WriteLine();
// }
// PrintNumbers(2, 8);
// PrintNumbers(1, 7);
// PrintNumbers(6, 12);

// void PrintDigit()
// {
//     int x = new Random().Next(10, 100);
//     Console.WriteLine($"случайное число сгенерировалось {x}");
//     int x1 = x / 10;
//     int x2 = x % 10;
//     if (x1 > x2) Console.WriteLine(x1);
//     else Console.WriteLine(x2);
// }
// PrintDigit();

// void PrintDigit()
// {
//     int x = new Random().Next(100, 1000);
//     Console.WriteLine($"случайное число сгенерировалось {x}");
//     int x1 = x / 100;
//     int x2 = x % 10;
//     Console.WriteLine(x1 + "" + x2);
//     // else Console.WriteLine(x2);
// }
// PrintDigit();

// void DeleteSecondNumber1()
// {
//     Console.WriteLine("Enter number: ");
//     string number = Console.ReadLine();
//     for (int i = 0; i < number.Length; i++)
//     {
//         if (i != 1)
//         {
//             Console.Write(number[i]);
//         }
//     }
//     Console.WriteLine();
// }
// DeleteSecondNumber1();

// int PrintDigit()
// {
//     int x = new Random().Next(10, 100);
//     Console.WriteLine($"случайное число сгенерировалось {x}");
//     int x1 = x / 10;
//     Console.WriteLine(x1);
//     int x2 = x % 10;
//     Console.WriteLine(x2);
//     if (x1 > x2) return x1;
//     else return x2;
// }
// Console.WriteLine(PrintDigit()*100);

// Напишите программу, которая будет принимать на вход два числа и выводить, является ли наименьшее число кратным наибольшему. 
// Если наибоьшее не кратно наименьшему, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно



// Console.WriteLine("Введите 2 числа ");
// int x = Convert.ToInt32(Console.ReadLine());
// int y = Convert.ToInt32(Console.ReadLine());
// if (x > y)
// {
//     if (x % y == 0) Console.WriteLine("кратно ");
//     else Console.WriteLine("не кратно " + x % y);
// }
// else
// {
//     if (y % x == 0) Console.WriteLine("Кратно ");
//     else Console.WriteLine("Не кратно " + y % x);
// }

// Console.WriteLine("Введите первое целое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе целое число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// string Multiplicity(int num1, int num2)
// {
//     string multiplicity = String.Empty;
//     int max = num1;
//     int min = num2;
//     if (num2 > num1)
//     {
//         max = num2;
//         min = num1;
//     }

//     if (max % min == 0)
//     {
//         multiplicity = $"Число {max} кратно {min}";
//     }
//     else
//     {
//         multiplicity = $"Число {max} не кратно {min}, остаток {max % min}";
//     }

//     return multiplicity;
//     }
// Console.WriteLine(Multiplicity(number1, number2));

// int GetNum4()
//         {
//             Console.Write("Введите координату х ");
//             int x = int.Parse(Console.ReadLine());
//             Console.Write("Введите координату y ");
//             int y = int.Parse(Console.ReadLine());  
//             int res;
//             if ( x>0 && y>0 )   res=1;
//             else if ( x<0 && y>0 )   res=2;
//             else if ( x<0 && y<0 )   res=3;
//             else if ( x>0 && y<0 )   res=4; 
//             else res=0; 
//             return res;
//         }

//         try
//             {
//             Console.WriteLine(GetNum4());
//             }
//         catch
//             {
//             Console.WriteLine("Надо было вводить именно числа, и именно целые!");    
//             }



// Задача 18: Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).

// string GetNum4()
// {
//     Console.Write("Введите число от 1 до 4: ");
//     int res = Convert.ToInt32(Console.ReadLine());
//     string what = string.Empty;

//     if (res == 1) what = "x > 0, y > 0";
//     else if (res == 2) what = "x < 0, y > 0";
//     else if (res == 3) what = "x < 0, y < 0";
//     else if (res == 4) what = "x > 0, y < 0";
//     else Console.WriteLine("Надо было вводить числа от 1 до 4!");
//     return what;
// }

// try
//     {
//     Console.WriteLine(GetNum4());
//     }
// catch
//     {
//     Console.WriteLine("Надо было вводить цифры");
//     }


// Задача 21: Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

// double Res()
// {
//     Console.WriteLine("Введите координаты точки A (x;y): ");
//     int xa = Convert.ToInt32(Console.ReadLine());
//     int ya = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите координаты точки B (x;y):");
//     int xb = Convert.ToInt32(Console.ReadLine());
//     int yb = Convert.ToInt32(Console.ReadLine());
//     int x =xa-xb;
//     int y = ya-yb;
//     double S = Math.Sqrt((Math.Pow(x,2)+Math.Pow(y,2)));
//     return S;
// }
// try
// {
//     Console.WriteLine(Res());
// }
// catch
// {
//     Console.WriteLine("Введите цифры");
// }


// Задача 22: Напишите программу, которая принимает на вход 
// число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// Console.WriteLine("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int index = 0;
// string res = string.Empty;
// for (index = n + 1; index++)
// {
//     res = Convert.ToString(index * index);
//     index++;
// }
// Console.Write(res);

// void SquareTableN()
// {
//     Console.Write("Введите число ");
//     int N = Convert.ToInt32(Console.ReadLine());
//     int[] answer = new int[N];
//     if (N > 0)
//     {
//         for (int i = 1; i < (N + 1); i++)
//         {
//             answer[i - 1] = (i * i);
//         }
//     }
//     else
//     {
//         Console.Write("Надо было вводить положительные числа");
//     }
//     var str = string.Join(" ", answer);
//     Console.WriteLine(str);
// }

// try
// {
//     SquareTableN();
// }
// catch
// {
//     Console.Write("Надо было вводить числа");
// }





// Console.WriteLine("Введите число А: ");
// int A = int.Parse(Console.ReadLine());

// int GetSum(int a)
// {
//     int sum = 0;
//     for (int i= 0; i <= a; i++)
//     {
//         sum += i;
//     }
//     return sum;
// }
// Console.WriteLine(GetSum(A));



//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Console.WriteLine("Введите число ");
// int num = int.Parse(Console.ReadLine());
// int Digits()
// {
//     int count = 0;
//     for (int i = 0; i <= num; i++)
//     {
//         num = num/10;
//         count += 1;
//     }
//     return count;
// }
// Console.WriteLine(Digits());

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

// Console.WriteLine("Введите число А: ");
// int A = int.Parse(Console.ReadLine());

// int GetComp(int a)
// {
//     int comp  = 1;
//     for (int i = 1; i <= a; i++)
//     {
//         comp *= i;
//     }
//     return comp;
// }
// Console.WriteLine(GetComp(A));

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[] array = new int[8];
// Random rand = new Random();
// for (int i = 0; i < array.Length; i++)
// {
//    array[i] = rand.Next(0,2);
//    Console.Write(array[i]);
// }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 31: Задайте массив из 12 элементов,
// заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20

// Console.Clear();

// int [] array = GetArray(12,-9,9);

// Console.WriteLine(String.Join(" ", array));

// int sumPositive = 0;
// int sumNegative = 0;

// foreach(int element in array){
//      sumPositive += element > 0 ? element : 0;
//      sumNegative += element < 0 ? element : 0; 
// }

// Console.WriteLine($"sum posititve: {sumPositive} sum Negative {sumNegative}");

// int[] GetArray(int size, int min, int max){
//     int[] result = new int[size];
//     for(int i = 0; i < size; i++){
//         result[i] = new Random().Next(min, max + 1);
//     }
// return result;
// }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// Console.Clear(); 
// Console.WriteLine("Укажите длину массива: "); 
// int size = int.Parse(Console.ReadLine()); 
// int [] rand = new int[size]; 
// int [] rand2 = new int[size]; 
// for (int i = 0; i < rand.Length; i++){ 
//     rand[i] = new Random().Next(-99, 100); 
//     Console.Write(rand[i]+" "); 
// } 
// Console.WriteLine(); 
// for (int i = 0; i < rand.Length; i++){ 
//     rand2[i] = rand[i] * -1; 
//     Console.Write(rand2[i]+" "); 
// } 
// Console.WriteLine(); 

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// Console.Clear(); 
// Console.WriteLine("Укажите длину массива: "); 
// int size = int.Parse(Console.ReadLine()); 
// Console.WriteLine("Введите искомое число: "); 
// int num = int.Parse(Console.ReadLine()); 
// int [] rand = new int[size]; 
// bool A = false; 
// for (int i = 0; i < rand.Length; i++){ 
//     rand[i] = new Random().Next(0, 11); 
//     Console.Write(rand[i]+" "); 
//     if (rand[i] == num) 
//         A = true; 
// } 
// Console.WriteLine(); 
// if (A == true) 
//     Console.WriteLine("Да"); 
// else 
//     Console.WriteLine("Нет");

// .............................................................................................................................................
// Console.Clear();

// Console.WriteLine("Введите размерность массива: ");
// int size = int.Parse(Console.ReadLine());

// int [] array = GetArray(size,-9,9);

// Console.WriteLine(String.Join(" ", array));

// Console.WriteLine("Введите значение");
// int findNumber = int.Parse(Console.ReadLine());

// Console.WriteLine(array.FirstOrDefault(p=>p == findNumber) != 0 ? "Да" : "Нет");


// int [] GetArray(int size, int min, int max){
//     int[] result = new int[size];

//     for(int i = 0; i < size; i++){
//         result[i] = new Random().Next(min, max + 1);
        
//     }
// return result;
// }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайтедля 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// Console.Clear(); 
// int [] array = GetArray(123,-99,199); 
// int j = 0; 
// int [] GetArray(int size, int min, int max){ 
//     int[] result = new int[size]; 
 
//     for(int i = 0; i < size; i++){ 
//         result[i] = new Random().Next(min, max + 1); 
//     } 
// return result; 
// } 
// int FindNumber(int [] array){ 
//     for (int i = 0; i < array.Length; i++){ 
//         if (array[i] >= 10 && array[i] <= 99) 
//             j++; 
//     } 
// return j; 
// } 
// Console.WriteLine (String.Join(" ", array)); 
// Console.WriteLine (FindNumber(array));

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// Console.Clear();

// int [] array = new int[5];

// for (int i = 0; i < 5; i++) {
//     array[i] = new Random().Next(0, 10);
// }

// Console.WriteLine(String.Join(" ", array));

// int z = array.Length - 1;
// for (int i = 0; i < z; i++)
// {
//     int pr = array[i] * array[z];
//     z--;
//     Console.Write(pr + " ");
// }

// if (array.Length % 2 != 0) {Console.Write (array[array.Length/2]); 
// }
// ..........................................................................................................................................................
// int[] GetArray(int size, int min, int max)
// {
//     int[] result = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(min, max + 1);

//     }
//     return result;
// }
// int ReadNumber()
// {
//     int number = 0;
//     while (true)
//     {
//         Console.WriteLine("Введите размерность");
//         if (!int.TryParse(Console.ReadLine(), out number))
//         {
//             Console.WriteLine("Некорректный ввод");
//         }
//         else break;
//     }
//     return number;
// }

// Console.Clear();

// int size = ReadNumber();
// int[] array = GetArray(size, 0, 10);
// int[] newArray = new int[size % 2 == 0 ? (size / 2) : (size / 2 + 1)];
// for (int i = 0; i < newArray.Length; i++)
// {
//     newArray[i] = array[i] * array[array.Length - 1 - i];
// }
// if (newArray.Length % 2 != 0)
// {
//     newArray[newArray.Length - 1] = array[array.Length / 2];
// }
// Console.WriteLine(String.Join("*", array));

// Console.WriteLine(String.Join("*", newArray));



// Семинар от 05.09.2022 ............................................................................

// Задача 39: Напишите программу, которая
// перевернёт одномерный массив (последний элемент
// будет на первом месте, а первый - на последнем и
// т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// Console.Clear();

// Console.WriteLine("Введите размерность массива: ");
// int size = int.Parse(Console.ReadLine());

// int [] array = FillArray(size, 1, 10);
// Console.WriteLine("Входной массив: ");
// Console.WriteLine(String.Join(" ", array));

// Console.WriteLine("Полученный массив: ");
// Console.WriteLine(String.Join(" ", array.Reverse()));

// int [] FillArray(int size, int min, int max)
// {
//     int [] result = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(min, max + 1);
//     }
//     return result;
// }

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 40: Напишите программу, которая принимает на
// вход три числа и проверяет, может ли существовать
// треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

// Console.Clear();
// int A, B, C;
// Console.Write("Введите длины сторон треугольника: ");
// while (!int.TryParse(Console.ReadLine(), out A) || A < 0) 
// {
//     Console.Write("Ошибка! Введите положительное число: ");
// }
// Console.Write("Введите длины сторон треугольника: ");
// while (!int.TryParse(Console.ReadLine(), out B) || B < 0) 
// {
//     Console.Write("Ошибка! Введите положительное число: ");
// }
// Console.Write("Введите длины сторон треугольника: ");
// while (!int.TryParse(Console.ReadLine(), out C) || C < 0) 
// {
//     Console.Write("Ошибка! Введите положительное число: ");
// }
// if (A < B + C & B < A + C & C < A + B) 
//     Console.Write("Может!");
// else 
//     Console.Write("Не может!");
// Console.WriteLine( );

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 42: Напишите программу, которая будет
// преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// Console.Clear();
// Console.WriteLine("Введите число: ");
// int value = int.Parse(Console.ReadLine());
// string BinaryCode = Convert.ToString(value, 2);
// Console.WriteLine("Число в двоичной системе: ");
// Console.WriteLine(BinaryCode);

//..................................................................................................

// Console.Clear();
// Console.WriteLine("Введите число: ");
// int value = int.Parse(Console.ReadLine());

// string i = " ";

// while (value > 0)
// {
//     if (value % 2 != 0){
//         i += "1";
//     }
//     else{
//         i += "0";
//     }
//     value = value / 2;
// }
// Console.WriteLine($"в двоичной системе:");
// Console.WriteLine(String.Join(" ", i.Reverse()));

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 44: Не используя рекурсию, выведите первые
// N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и
// 1
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// Console.Clear();
// Console.WriteLine("Введите число: ");
// int N = int.Parse(Console.ReadLine());
// int i = 0;
// int Fib1 = 0;
// int Fib2 = 1;
// while(i<N)
// {
//     Console.Write(Fib1 + " ");
//     Fib2 = Fib1+Fib2;
//     Fib1 = Fib2-Fib1;
//     i++;
// }


/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 45: Напишите программу, которая будет
// создавать копию заданного массива с помощью
// поэлементного копирования.

// Console.Clear();

// Console.WriteLine("Введите размерность массива: ");
// int size = int.Parse(Console.ReadLine());

// int [] array1 = FillArray(size, 1, 10);

// int [] FillArray(int size, int min, int max){
//     int [] result = new int[size];
//     for(int i = 0; i < size;i++){
//         result[i] = new Random().Next(min, max + 1);
//     }
//     return result;
// }
// Console.WriteLine(String.Join(" ", array1));
// int [] array2 = new int[size];
// for(int i = 0; i <size; i++)
// {
//     array2[i] = array1[i];
// }
// Console.WriteLine(String.Join(" ", array2));





// Семинар 08.09.2022...........................................................................................................................

//Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.

// Console.Clear();

// Console.Write("Количество строк в массиве: ");
// int rows = int.Parse(Console.ReadLine());

// Console.Write("Количество столбцов в массиве: ");
// int columns = int.Parse(Console.ReadLine());

// int [,] array = FillArray(rows, columns, 1 , 10);

// PrintArray(array);

// int [,] FillArray(int rows, int columns, int min, int max){
//     int[,] array = new int[rows,columns];
//     for(int i = 0; i < rows; i++){
//         for(int j = 0; j< columns; j++){
//             array[i,j] = new Random().Next(min, max + 1);
//         }
//     }
//     return array;
// }

// void PrintArray(int [,] filledArray){
//     for(int i = 0; i<filledArray.GetLength(0);i++){
//         for(int j = 0; j < filledArray.GetLength(1);j++){
//             Console.Write($"{filledArray[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// Console.Clear();

// int [,] array = FillArray(3, 4);

// int [,] FillArray(int rows, int columns)
// {
//     int[,] array = new int[3, 4];
//     for(int i = 0; i < rows; i++)
//     {
//         for(int j = 0; j< columns; j++)
//         {
//             array[i,j] = i + j;
//         }
//     }
//     return array;
// }

// void PrintArray(int [,] filledArray){
//     for(int i = 0; i<filledArray.GetLength(0);i++){
//         for(int j = 0; j < filledArray.GetLength(1);j++){
//             Console.Write($"{filledArray[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// PrintArray(array);

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 49: Задайте двумерный массив. Найдите элементы,
// у которых оба индекса чётные, и замените эти элементы на
// их квадраты.
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

// Console.Clear();
// Console.Write("Количество строк в массиве: ");
// int rows = int.Parse(Console.ReadLine());
// Console.Write("Количество столбцов в массиве: ");
// int columns = int.Parse(Console.ReadLine());
// int [,] array = FillArray(rows, columns, 1 , 10);
// PrintArray(array);
// Console.WriteLine();
// PrintArray(FillArrayCheck(array));
// int [,] FillArrayCheck(int [,] array)
// {
//     for(int i = 1; i < rows; i++)
//     {
//         for(int j = 1; j< columns; j++)
//         {
//             if (i % 2 == 1 && j % 2 == 1)
//             {
//                 array[i,j] *= array[i,j];
//             }
//         }
//     }
//     return array;
// }
// int [,] FillArray(int rows, int columns, int min, int max)
// {
//     int[,] array = new int[rows,columns];
//     for(int i = 0; i < rows; i++)
//     {
//         for(int j = 0; j< columns; j++)
//         {
//             array[i,j] = new Random().Next(min, max);
//         }
//     }
//     return array;
// }
// void PrintArray(int [,] filledArray)
// {
//     for(int i = 0; i<filledArray.GetLength(0);i++)
//     {
//         for(int j = 0; j < filledArray.GetLength(1);j++)
//         {
//             if (filledArray[i,j] / 10 == 0)
//             Console.Write($"{filledArray[i,j]} ");
//             else Console.Write($"{filledArray[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 51: Задайте двумерный массив. Найдите сумму главной диагонали
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

// Console.Clear();
// Console.Write("Количество строк в массиве: ");
// int rows = int.Parse(Console.ReadLine());
// Console.Write("Количество столбцов в массиве: ");
// int columns = int.Parse(Console.ReadLine());
// int [,] array = FillArray(rows, columns, -9 , 10);
// PrintArray(array);
// Console.WriteLine();
// DiagonalArray(array);
// void DiagonalArray(int [,] array)
// {
//     int[] Sum = new int[Math.Min(rows,columns)];
//     int sum = 0;
//     for(int i = 0; i < Math.Min(rows,columns); i++)
//     {
//         sum += array[i, i];
//         Sum[i] = array[i, i];
//     }
//     Console.WriteLine($"Сумма элементов диагонали:");
//     Console.Write($"({String.Join(") + (", Sum)})");
//     Console.WriteLine($" = {sum}");
// }
// int [,] FillArray(int rows, int columns, int min, int max)
// {
//     int[,] array = new int[rows,columns];
//     for(int i = 0; i < rows; i++)
//     {
//         for(int j = 0; j< columns; j++)
//         {
//             array[i,j] = new Random().Next(min, max);
//         }
//     }
//     return array;
// }
// void PrintArray(int [,] filledArray)
// {
//     for(int i = 0; i<filledArray.GetLength(0);i++)
//     {
//         for(int j = 0; j < filledArray.GetLength(1);j++)
//         {
//             if (filledArray[i,j] >= 0)
//             Console.Write($"{filledArray[i,j]} ");
//             else
//             Console.Write($"{filledArray[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// Семинар 12.09.2022............................................................................................................................

// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

// Console.Clear();
// int[,] array = new int[4, 4];

// FillArray(array);
// PrintArray(array);

// void FillArray(int[,] ar)
// {
//     for (int i = 0; i < ar.GetLength(0); i++)
//     {
//         for (int j = 0; j < ar.GetLength(1); j++)
//         {
//             ar[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void PrintArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write(arr[i, j] + " ");
//         }
//         Console.WriteLine("");
//     }
// }


// int[,] ReversStrings(int[,] array){
// int [,] r1 = array;
// int rowcount = array.GetLength(0) - 1;
// int temporary = 0; 
//     for ( int i = 0; i < array.GetLength(1); i++){
//             temporary = array[0, i];
//             r1[0, i] = array [rowcount,i];
//             r1[rowcount, i] = temporary; 
//     }
//     return r1;
// }
//  Console.WriteLine();
// PrintArray(ReversStrings(array));

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

// Console.Clear();

// Console.Write("Количество строк в массиве: ");
// int rows = int.Parse(Console.ReadLine());

// Console.Write("Количество столбцов в массиве: ");
// int columns = int.Parse(Console.ReadLine());

// int [,] array = FillArray(rows, columns, 1 , 10);

// PrintArray(array);
// Console.WriteLine("Новый массив:");
// PrintArray(TransformationArray(array));


// int [,] TransformationArray(int [,] filledArray){
//     int[,] transformationArray = new int[rows,columns];
//     if (rows == columns){
//             for(int i = 0; i < rows; i++){
//                 for(int j = 0; j< columns; j++){
//                     transformationArray[i,j] = filledArray[j,i];
//                 }
//             }
//     }
//     else {
//     Console.WriteLine("Это невозможно");
//     return new int[0, 0];
//     }
//     return transformationArray;
// }

// int [,] FillArray(int rows, int columns, int min, int max){
//     int[,] array = new int[rows,columns];
//     for(int i = 0; i < rows; i++){
//         for(int j = 0; j< columns; j++){
//             array[i,j] = new Random().Next(min, max);
//         }
//     }
//     return array;
// }

// void PrintArray(int [,] filledArray){
//     for(int i = 0; i<filledArray.GetLength(0);i++){
//         for(int j = 0; j < filledArray.GetLength(1);j++){
//             Console.Write($"{filledArray[i,j]}  ");
//         }
//         Console.WriteLine();
//     }
// }



///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

// Console.Clear();

// Console.Write("Количество строк в массиве: ");
// int rows = int.Parse(Console.ReadLine());

// Console.Write("Количество столбцов в массиве: ");
// int columns = int.Parse(Console.ReadLine());

// int [,] array = FillArray(rows, columns, 0 , 10);

// PrintArray(array);
// Console.WriteLine(String.Join (" ", FrequencyDictionary(array)));

// int [] SortArray = FrequencyDictionary(array);
// Array.Sort(SortArray);
// PrintData(SortArray);

// void PrintData(int[] inArray){
//     int el=inArray[0];
//     int count = 1;
//     for (int i = 1; i < inArray.Length; i++){
//         if(inArray[i]!=el){
//             Console.WriteLine($"{el} встречается {count}");
//             el=inArray[i];
//             count=1;
//         }
//         else
//             count++;
//     }
//     Console.WriteLine($"{el} встречается {count}");
// }

// int [] FrequencyDictionary(int [,] filledArray){
//     int [] frequencyDictionary = new int[filledArray.GetLength(0)*filledArray.GetLength(1)];
//     int count = 0;
//     for(int i = 0; i<filledArray.GetLength(0);i++){
//         for(int j = 0; j < filledArray.GetLength(1);j++){
//             frequencyDictionary[count] = filledArray[i,j];
//             count++;
//         }
//     } 
//     return frequencyDictionary;
// }

// int [,] FillArray(int rows, int columns, int min, int max){
//     int[,] array = new int[rows,columns];
//     for(int i = 0; i < rows; i++){
//         for(int j = 0; j< columns; j++){
//             array[i,j] = new Random().Next(min, max);
//         }
//     }
//     return array;
// }

// void PrintArray(int [,] filledArray){
//     for(int i = 0; i<filledArray.GetLength(0);i++){
//         for(int j = 0; j < filledArray.GetLength(1);j++){
//             Console.Write($"{filledArray[i,j]}  ");
//         }
//         Console.WriteLine();
//     }
// }

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

using static System.Console;
//2

Clear();

Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine());
Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine());
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
WriteLine();
WriteLine($"Минимальный элемент находится -> {String.Join(" ",GetIndexMinEl(array))}" );
WriteLine();
PrintArray(GetResultArray(array, GetIndexMinEl(array)));

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }

    }
    return result;
}

int[] GetIndexMinEl(int[,] inArray)
{
    int[] result = new int[]{0,0};
    int min=inArray[0,0];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if(min>inArray[i,j])
            {
                min=inArray[i,j];
                result[0]=i;
                result[1]=j;
            }
        }
    }
    return result;
}

int[,] GetResultArray(int[,] inArray, int[] indexes)
{
    int[,] result = new int[inArray.GetLength(0) - 1, inArray.GetLength(1) - 1];
    int row = 0;
    int column = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        if (i == indexes[0]) continue;
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (j == indexes[1]) continue;
            result[row, column] = inArray[i, j];
            column++;
        }
        column = 0;
        row++;
    }
    return result;
}


void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
}

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника

// using static System.Console;
// //3

// Clear();

// Write("Введите нужное количество строк треугольника Паскаля: ");
// int rows = int.Parse(ReadLine());
// PrintTriangle(rows);


// void PrintTriangle(int n)
// {
//     for (int i = 0; i < n; i++)
//     {
//         for (int c = 0; c <= (n - i); c++) // создаём после каждой строки n-i отступов от левой стороны консоли, чем ниже строка, тем меньше отступ
//         {
//             Write("  ");
//         }
//         for (int c = 0; c <= i; c++)
//         {
//             Write("   "); // создаём пробелы между элементами треугольника
//             Write(factorial(i) / (factorial(c) * factorial(i - c))); //формула вычисления элементов треугольника
//         }
//         WriteLine(); // после каждой строки с числами отступаем две пустые строчки
//     }
// }
// float factorial(int n)
// {
//     float x = 1;
//     for (int i = 1; i <= n; i++)
//     {
//         x *= i;
//     }
//     return x;
// }