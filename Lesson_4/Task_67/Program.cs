// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
//рекурсия последовательного вывода чисел в обратном порядке
void PrintRange (int number)
{
    if (number==0)
    {
        return ;
    }
    System.Console.Write(number+", ");
    PrintRange(number-1);
}

Console.WriteLine("Введите число N");
int startUserNumber = Convert.ToInt32(Console.ReadLine());
PrintRange(startUserNumber);
Console.ReadKey();