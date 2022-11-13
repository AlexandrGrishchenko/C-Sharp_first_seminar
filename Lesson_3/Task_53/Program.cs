// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
//функция ввода случайных чисел массива
double[,] getRandomUserAray(int height, int width, int randomStart, int randomEnd)
{
    double[,] userArray = new double[height, width];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            userArray[i, j] = Math.Round(((new Random().NextDouble() * new Random().Next(randomStart, randomEnd))), 2);
        }
    }
    return userArray;
}
//функция печать двумерного массива
void PrintUserArray(double[,] userArray)
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
//функция подсчета среднеарифметического по строке
double arithmeticMean(double[,] userArray, int userString)
{
    double ithmeticResult = 0;
    double summStringArray = 0;
    int stringArray = userArray.GetLength(0);
    for (int i = 0; i < userArray.GetLength(0); i++)
    {
        summStringArray = summStringArray + userArray[i, userString];
    }
    ithmeticResult = Math.Round((summStringArray / userArray.GetLength(0)), 2);
    System.Console.WriteLine("\nКолличество строк в столбце:  " + stringArray);
    return ithmeticResult;
}
//ввод номера столбца
int ReadInt(string getStringUserArray)
{
    System.Console.WriteLine(getStringUserArray);
    return Convert.ToInt32(Console.ReadLine());
}
//функция вывода сообщения об ошибке в терминал
void errorStringUserArray(double[,] userArray, int userString)
{
    if (userString > userArray.GetLength(1) || userString <= 0)
    {
        System.Console.WriteLine("\nТакого столбца не существует!\n");
    }
}

int getStringUserArray = ReadInt("Введите номер столбца: ") - 1;
double[,] newUserArray = getRandomUserAray(4, 4, 0, 9);
PrintUserArray(newUserArray);
errorStringUserArray(newUserArray, getStringUserArray);
double resultArithmetic = arithmeticMean(newUserArray, getStringUserArray);
System.Console.WriteLine($"\nСреднеарефметическое {getStringUserArray + 1} столбца: " + resultArithmetic);