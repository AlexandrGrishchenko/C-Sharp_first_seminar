// 5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

Console.Clear();

System.Console.Write("Введите число:   ");
string writeNumber = System.Console.ReadLine();

int endNumber = Convert.ToInt32(writeNumber);
int Number = endNumber * (-1);
System.Console.Write($"{Number}  ");

while (Number < endNumber)
{
    Number++;
    System.Console.Write($"{Number} ");
}
System.Console.WriteLine();
Console.ReadKey();