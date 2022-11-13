//  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

int size = 20;
//функция генерирования массива случайными числами
int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}

void PrintArray(int[] arr)
{
    int sum = 0;
    System.Console.WriteLine();
    for (int i = 0; i < size; i++)
    {
        System.Console.Write(arr[i] + " ");
        if (i % 2 > 0) sum += arr[i];
    }
    System.Console.WriteLine();
    System.Console.WriteLine($"Сумма чисел, стоящих на нечетной позиции, соcтаваляет {sum} ");
    System.Console.WriteLine();
}

PrintArray(FillArray(size));