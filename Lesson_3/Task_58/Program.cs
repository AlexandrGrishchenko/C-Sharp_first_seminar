// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


//функция создания двумерного массива
int[,] generateDeventionArray(int height, int width, int randomnumber)
{
    int[,] randomNumberArray = new int[height, width];
    for (int i = 0; i < randomNumberArray.GetLength(0); i++)
    {
        for (int j = 0; j < randomNumberArray.GetLength(1); j++)
        {
            randomNumberArray[i, j] = new Random().Next(-randomnumber, randomnumber);
        }

    }
    return randomNumberArray;
}

// Функция сортировки элементов в строке двумерного массива, по убыванию
void SortToLower(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

//функция ввода данных
int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

//функция печать двумерного массива
void PrintDeventionArray(int[,] userArray)
{
    for (int i = 0; i < userArray.GetLength(0); i++)
    {
        for (int j = 0; j < userArray.GetLength(1); j++)
        {
            System.Console.Write(userArray[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int userHeight = ReadInt("\nВведите высоту массива:\t");
int userWidth = ReadInt("\nВведите длинну массива:\t");
int userNumber = ReadInt("\nВведите предел генерации случайных чисел:\t");
System.Console.WriteLine("\nМассив сгенерирован:");
int[,] newUserArray = generateDeventionArray(userHeight, userWidth, userNumber);
PrintDeventionArray(newUserArray);
System.Console.WriteLine("\nСоритровка массива:");
SortToLower(newUserArray);
PrintDeventionArray(newUserArray);
