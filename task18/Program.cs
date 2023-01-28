// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y)

void CheckQr(int x)
{
    if (x == 1)
    {
        Console.WriteLine("Where: x > 0 and y > 0");
    }
    if (x == 2)
    {
        Console.WriteLine("Where: x < 0 & y > 0");
    }
    if (x == 3)
    {
        Console.WriteLine("Where: x < 0 & y < 0");
    }
    if (x == 4)
    {
        Console.WriteLine("Where: x > 0 & y < 0");
    }

}

int GetNum(string text)
{
    Console.WriteLine(text);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

// ввод данных от пользователя

int x = GetNum("Input qarter: ");
Console.Write("area is: ");

// find quarter
CheckQr(x);
