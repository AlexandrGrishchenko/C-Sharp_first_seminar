// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
//функция ввода числовых данных через терминал
int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

//функция Аккермана через рекурсию
int AckermannFunction(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    if (n != 0 && m == 0)
    {
        return AckermannFunction(n - 1, 1);
    }
    if (n > 0 && m > 0)
    {
        return AckermannFunction(n - 1, AckermannFunction(n, m - 1));
    }
    return AckermannFunction(n, m);
}


int firstUserNumber = ReadInt("Введите 1 число :");
int secondUserNumber = ReadInt("Введите 2 число: ");
System.Console.WriteLine(AckermannFunction(firstUserNumber, secondUserNumber)); 
Console.ReadKey();