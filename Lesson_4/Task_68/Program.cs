// Задайте значения M и N. Напишите программу рекурсией, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
//функция ввода числовых данных через терминал
int ReadInt (string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// // рекурсия нахождения суммы натуральных элементов в промежутке от M до N
int SumNumber(int Number, int Degrees)
{

    if (Degrees == Number)
        {
        return Number;
    }
    return Degrees + SumNumber(Number, --Degrees);

}

int userNumber = ReadInt("Введите 1 число :");
int userDegrees = ReadInt("Введите 2 число: ");
int resultPow = SumNumber(userNumber,userDegrees);
System.Console.WriteLine(resultPow);
Console.ReadKey();