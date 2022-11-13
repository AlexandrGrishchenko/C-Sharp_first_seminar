// Напишите программу, которая на вход принимает позицию элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
// 5 -> 9
// 2 -> 7
// 9 -> 4
// индексы:
// [0][1][2][3]
// 1 4 7 2
// [4][5][6][7]
// 5 9 2 3
// [8][9][10][11]
// 8 4 2 4

/*Замечание преподователя: Сильно неоптимальное решение 52 задачи, если просто число пользователя разделить 
на количество столбцов можно получить строку если взять остаток от деления на количество столбцов получить колонку*/

Console.Clear();
//функция ввода случайных чисел массива
int[,] getRandomUserAray(int height, int width, int randomStart, int randomEnd)
{
    int[,] userArray = new int[height, width];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            userArray[i, j] = new Random().Next(randomStart, randomEnd);
        }
    }
    return userArray;
}

//функция преобразования двумерного массива в одномерный
int[] dimensionalTransformationArrayInOne(int[,] newDimensionalUserArray,int userNumberArray)
{
    int length2=(newDimensionalUserArray.GetLength(0))*(newDimensionalUserArray.GetLength(1));
    int length = 0;
    int[] newUserArray = new int[length2];
    for (int i = 0; i < newDimensionalUserArray.GetLength(0); i++)
        for (int j = 0; j < newDimensionalUserArray.GetLength(1); j++)
        {
            newUserArray[length] = newDimensionalUserArray[i, j];
            if (length==userNumberArray)
            {
                System.Console.WriteLine($"\nМассиву с номером индекса {length} соответсует число:\t"+newUserArray[length]);
            }
            length++;
        }
        if (length<0||userNumberArray>length)
        {
            System.Console.WriteLine("\nТакого числа в массиве нет");
        }
    return newUserArray;
}

//функция печать двумерного массива
void PrintDimensionaUserArray(int[,] userArray)
{
    System.Console.WriteLine("\t");
    for (int i = 0; i < userArray.GetLength(0); i++)
    {
        for (int j = 0; j < userArray.GetLength(1); j++)
        {
            System.Console.Write(userArray[i, j] + "\t\t");
        }
        System.Console.WriteLine();
    }

}

//функция печать одномерного массива
// void PrintOnUserArray(int[] userArray)
// {
//     System.Console.WriteLine("\t");
//     for (int i = 0; i < userArray.Length; i++)
//     {
//         System.Console.Write(userArray[i] + "\t");

//     }

// }

//ввод номера строки и столбца
int ReadInt(string getStringUserArray)
{
    System.Console.WriteLine(getStringUserArray);
    return Convert.ToInt32(Console.ReadLine());
}

int height = ReadInt("Введите колличество строк: ");
int width = ReadInt("Введите колличество столбцов: ");
int[,] newDimensionalUserArray = getRandomUserAray(height, width, 0, 9);
int userNumberArray = ReadInt("Введите номер индекса: ");
int[] newOneUserArray = dimensionalTransformationArrayInOne(newDimensionalUserArray,userNumberArray);
PrintDimensionaUserArray(newDimensionalUserArray);
// PrintOnUserArray(newOneUserArray);
