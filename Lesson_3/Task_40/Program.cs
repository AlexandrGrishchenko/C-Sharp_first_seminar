// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

/*Замечание преподователя: задаче правильнее было бы не выводить в самой функции результат, а просто получить на выход это*/

Console.Clear();
System.Console.WriteLine();

int size = new Random().Next(1, 11);

System.Console.WriteLine($"Количетсов элементов массива: {size}");

int[] FillSourceArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1,100) ;
    }
    return array;
}

void PrintDiffMinMax(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]+" ");
    }
    double difference = arr.Max() - arr.Min();
    System.Console.WriteLine();
    System.Console.WriteLine($"Минимальное значение массива {arr.Min()}, максимальное значение массива {arr.Max()}");
    System.Console.WriteLine($"Разница между минимальным и максимальным значениями массива составляет {difference}");
    System.Console.WriteLine();
}

PrintDiffMinMax(FillSourceArray(size));
System.Console.WriteLine();