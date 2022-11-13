// Напишите программу, в которой пользователь задает длину массива, элементы которого задаются в диапазоне [1,99] и выводит на экран .
// 5 -> [1, 2, 5, 7, 19]
// 3 -> [6, 1, 33]

Console.Clear();
Console.Write("Задайте длинну массива : ");
int N = Convert.ToInt32(Console.ReadLine());

int[] SetArray(int x)
{
    int[] arr = new int[x];
    for (int i = 0; i < x; i++)
    {
        arr[i] = new Random().Next(1, 100);
    }
    return arr;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        System.Console.Write($"{array[i]} ");
}

PrintArray(SetArray(N));