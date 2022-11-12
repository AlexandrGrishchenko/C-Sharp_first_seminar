// Задача 0 Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.Clear();

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int summ=number*number;
System.Console.WriteLine($"Квадратом числа {number} является: {summ}");

Console.ReadKey();
