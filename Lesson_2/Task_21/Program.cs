// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

/*Замечание преподователя: Использование строки для полиндрома не верное решение*/

Console.Clear();
Console.WriteLine();

Console.Write("Введите целое число:   ");
string number = Console.ReadLine();
int length = number.Length;
string txtToCheck = number.Replace(" ","");  /// для проверки текста на палиндром

bool IsPalindrome()
{
    for (int i = 0; i < length / 2; i++)
        while (number[i] == number[length - 1])
        {
            return true;
        }
    return false;
}

Console.WriteLine("Ответ при решении первым способом:");
if (IsPalindrome()) System.Console.WriteLine($"1. Введный текст/число - {number} - является палиндромом");
else Console.WriteLine($"1. Число {number} не является палиндромом");
Console.WriteLine();