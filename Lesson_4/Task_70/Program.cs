// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

/*Замечание преподователя: задаче нужно было найти максимальную сумму строки, а не элемент*/


Console.Clear();

int[,] array2D = new int[4, 4];
FillArray(array2D);
PrintIndex(array2D);
maxNumberOfArray(array2D);


// Функция вывода индекса элементов 2D массива
void PrintIndex(int[,] arr)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            Console.Write($"{array2D[i, j]}({i},{j}) \t");

        }
        System.Console.WriteLine();

    }

}

// Функция заполнения 2D массива не повторяющимеся числами
void FillArray(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            long time = DateTime.Now.Ticks;
            String fileName = Convert.ToString(time % 100);
            int timeRandonNumber = int.Parse(fileName);
            arr[i, j] = timeRandonNumber;

        }
    }
}
//функция нахождения максимального числа в массиве
void maxNumberOfArray(int[,] array2D)
{

    int max = int.MinValue;
    int maxHightgArray = 0;
    int maxWeigthAraay = 0;
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            if (array2D[i, j] > max)
            {
                max = (array2D[i, j]);
                maxHightgArray = i;
                maxWeigthAraay = j;
            }
        }

    }
    Console.Write($"\nМаксимальное число находится на {maxHightgArray} строчке,{maxWeigthAraay} столбца ");
    System.Console.WriteLine("\nMax number:\t" + max);
}
Console.ReadKey();