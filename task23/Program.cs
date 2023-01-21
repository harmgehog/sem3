// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void RowOfCubes(int x)
{
    for (int i = 1; i < x; i++)
    {
        Console.Write(Math.Pow(i, 3) + ", ");
    }
    Console.Write(Math.Pow(x, 3));
}

int GetNum(string text)
{
    Console.Write(text);
    int x = int.Parse(Console.ReadLine());
    return (x);
}

// ввод данных от пользователя 

int x = GetNum("Введите число: ");
Console.Write($"{x} -> ");

// запуск метода
RowOfCubes(x);
