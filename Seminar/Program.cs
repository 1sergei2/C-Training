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

// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] array = new int[8];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
   array[i] = rand.Next(0,2);
   Console.Write(array[i]);
}
