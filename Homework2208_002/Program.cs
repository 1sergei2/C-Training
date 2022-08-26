void PrintThirdNumber()
{
    Console.Write("Введите число: ");
    int x = Convert.ToInt32(Console.ReadLine());
    string x1 = Convert.ToString(x);
    if (x1.Length > 2)
    {
        Console.WriteLine("Третья цифра " + x1[2]);
    }
    else
    {
        Console.WriteLine("Третьей цифры нет");
    }
}
PrintThirdNumber();

// Программа, которая выводит третью цифру заданного числа
// или сообщает, что такого числа нет.

// void PrintThirdnum()
// {
// int a = 0;
// Console.WriteLine("Ведите целое число");
// int x = Convert.ToInt32(Console.ReadLine());
// if (x < -99) {a = -1*x;} else {a = x;}
// if (a > 99) 
//     { 
//         while (a > 999) {a = a/10;}
//         Console.WriteLine("Третья цифра в числе " + x + "  равна " + a%10);
//     }
// else {Console.WriteLine("Нет третьей цифры слева. Введенное число НЕ является трехзначным");}

// return;
// }
// PrintThirdnum();