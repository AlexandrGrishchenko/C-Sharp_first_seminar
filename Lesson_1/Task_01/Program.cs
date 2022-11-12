// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

Console.Clear();

Console.Write("Введите первое число: ");
int userNumberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int userNumberB = Convert.ToInt32(Console.ReadLine());

if (userNumberA == userNumberB * userNumberB)
{
    Console.WriteLine($"Число {userNumberA} является квадратом числу {userNumberB}");
}
else
{
    Console.WriteLine($"Число {userNumberA} не является квадратом числу {userNumberB}");
}

Console.ReadKey();