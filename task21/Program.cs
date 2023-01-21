/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

void findDistance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double distance = Math.Sqrt(
        Math.Pow(x2 - x1, 2) +
        Math.Pow(y2 - y1, 2) +
        Math.Pow(z2 - z1, 2)
        );
    Console.WriteLine(Math.Round(distance, 2));
}

static (int x, int y, int z) GetNum(string text)
{
    Console.WriteLine(text);
    char[] sep = { ',', ',', ';', ' ' };
    string[] arr = Console.ReadLine().Split(sep);
    int x = int.Parse(arr[0]);
    int y = int.Parse(arr[1]);
    int z = int.Parse(arr[2]);
    return (x, y, z);
}

// ввод данных от пользователя 
// для удобства пользователя одной строчкой

var xyz1 = GetNum("1я точка (цифры через ',' или ' '): ");
var xyz2 = GetNum("2я точка (цифры через ',' или ' '): ");
Console.Write("Расстояние между этими точками: ");

// запуск метода
findDistance(xyz1.x, xyz1.y, xyz1.z, xyz2.x, xyz2.y, xyz2.z);
