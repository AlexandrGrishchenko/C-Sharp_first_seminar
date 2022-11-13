// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();
//функция ввода случайных чисел массива
double [,] getRandomUserAray (int height,int width, int randomStart, int randomEnd)
{
    double[,] userArray = new double [height,width];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
           userArray[i,j] = Math.Round(((new Random().NextDouble()*new Random().Next(randomStart,randomEnd))),2);
        }
    }
    return userArray;
}

//функция печать двумерного массива
void PrintUserArray (double[,]userArray)
{
    System.Console.WriteLine("\t");
     for (int i = 0; i < userArray.GetLength(0); i++)
     {
        for (int j = 0; j < userArray.GetLength(1); j++)
        {
            System.Console.Write(userArray[i,j]+"\t\t");
        }
        System.Console.WriteLine();
     }

}

double [,] newUserArray = getRandomUserAray(3,4,-50,90);
PrintUserArray(newUserArray);
Console.ReadKey();