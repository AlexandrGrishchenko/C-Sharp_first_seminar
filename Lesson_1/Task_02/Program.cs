// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();

Console.Write("Введите число: ");
int usernumberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int usernumberB = Convert.ToInt32(Console.ReadLine());

if (usernumberA == usernumberB)
{
    Console.WriteLine($"Число {usernumberA} равно числу {usernumberB}");
    Console.WriteLine("Оба числа равны");
}
else if (usernumberA > usernumberB)
{
    Console.WriteLine($"Число {usernumberA} больше {usernumberB}");
    Console.WriteLine($"Максимальное число: {usernumberA} ");
}

else 
{
    Console.WriteLine($"Число {usernumberB} больше {usernumberA}");
    Console.WriteLine($"Максимальное число: {usernumberB} ");
}