// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
System.Console.WriteLine();

int size = 20;
//функция генерирования массива случайными числами
int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}
//функция печати 
void PrintResult(int[] array)
{
    int even = 0;
    int uneven = 0;
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
        if (array[i] % 2 == 0) even++;
        else uneven++;
    }
    System.Console.WriteLine();
    System.Console.WriteLine($"Количество четных чисел {even}, количество нечетных чисел {uneven}");
    System.Console.WriteLine();
}

PrintResult(FillArray(size));
Console.ReadKey();