// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

void Distance(double x, double y, double x2, double y2)
{
    double dis = Math.Pow(Math.Pow(x-x2, 2) + Math.Pow(y-y2, 2), 0.5);
    Console.Write(dis);
}


int GetNum(string text)
{
    Console.WriteLine(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}


// ввод данных от пользователя

double x = GetNum("Input value X");
double x2 = GetNum("Input value X2");
double y = GetNum("Input value Y");
double y2 = GetNum("Input value Y2");
Console.Write("Distance is: ");

// find 
Distance(x, y, x2, y2);
