// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.Write("Введите пятизначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// string num1 = num.ToString();
// if (num1[0]==num1[4] && num1[1]==num1[3])
// {
//     Console.WriteLine("Введенное число является палиндромом");
// }
// else Console.WriteLine("Введенное число не является палиндромом");

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите координаты точки А (x, y, z):");
// double Ax = Convert.ToDouble(Console.ReadLine());
// double Ay = Convert.ToDouble(Console.ReadLine());
// double Az = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите координаты точки B (x, y, z):");
// double Bx = Convert.ToDouble(Console.ReadLine());
// double By = Convert.ToDouble(Console.ReadLine());
// double Bz = Convert.ToDouble(Console.ReadLine());
// double Distance;
// Distance = Math.Sqrt(((Ax - Bx) * (Ax - Bx)
//                          + (Ay - By) * (Ay - By)
//                          + (Az - Bz) * (Az - Bz)));
// Console.WriteLine("Расстояние между заданными точками " + Distance);


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число: ");
int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int count = 1;
while (count <= n)
{
    Console.Write($"{Math.Pow(count, 2)} ");
    count++;   
}
Console.WriteLine();




// Необязательная к выполнению задача (не будет влиять на итоговую оценку ДЗ)
// Дополнительная задача (задача со звёздочкой): Напишите программу, которая на вход принимает радиус круга и находит его площадь округленную
// до целого числа, необходимо вывести максимальную цифру в полученном округлённом значении площади круга
// 10 -> 4
// 20 -> 7
// 30 -> 8
