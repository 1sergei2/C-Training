Console.WriteLine("Введите цифру, согласно дню недели: ");
int x = Convert.ToInt32(Console.ReadLine());
void WhatDayIsIt(int x)
{
    if (x == 6 || x == 7)
    {
        Console.WriteLine("Это выходной день");
    }
    else if (x < 1 || x > 7)
    {
        Console.WriteLine("Это не день недели, балбес");
    }
    else Console.WriteLine("Это будний день");
}
WhatDayIsIt(x);