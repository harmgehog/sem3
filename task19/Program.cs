// Задача 19

// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

/* палиндромы рекомендуется проверять строкой и без дублирования!!! 
Так как при больших последовательностях будут проблемы и с памятью и с вычислениями.
Плюс можно не искать середину и не высчитывать в цикле */

void CheckPalindrome(string x)
{
    int rightIndex = x.Length - 1;  // при неизвестной длине задаем конечный 
    int leftIndex = 0;              // и начальный индексы
    string output = "ДА";
    while (leftIndex < rightIndex)  // сравниваем чары пока левый не превысит правый
    {
        if (x[leftIndex] != x[rightIndex])
        {
            output = "НЕТ";
            break;                  // брейкаем чтобы не лопатить впустую
        }
        leftIndex++;
        rightIndex--;

    }
    Console.WriteLine(output);
}

string GetText(string text)
{
    Console.WriteLine(text);
    return Console.ReadLine();
}

string x = GetText("Input value to check for palindrome: ");

// 
CheckPalindrome(x);
