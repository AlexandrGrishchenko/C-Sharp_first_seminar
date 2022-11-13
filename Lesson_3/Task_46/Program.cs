// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Clear();

// Ввод данных массив
int[] randomNumberArray(int length, int fromNumber, int toNumber)
{
    int[] arrayUser = new int[length];
    for (int i = 0; i < arrayUser.Length; i++)
    {
        arrayUser[i] = new Random().Next(fromNumber, toNumber);
    }
    return arrayUser;
}

// вывод цельного массива в консоль
void PrintUserArray (int[]userArray)
{
   System.Console.Write($"INT: [");
   for (int i = 0; i < userArray.Length; i++)
   {
    System.Console.Write(userArray[i]);
    if (i < userArray.Length-1)
    {
        System.Console.Write(", ");
    }
   }
   System.Console.Write("]");
}

//Вывод значений массива в консоль
void PrintResult(int[] arrayUser)
{
    int even = 0;
    int uneven = 0;
    int positivNumber =0;
    int negativNumber =0;

    for (int i = 0; i < arrayUser.Length; i++)
    {
        if (arrayUser[i] > 0) 
        {
            even = even + arrayUser[i];
            positivNumber++;
        }
        else 
            uneven = uneven + arrayUser[i];
        if (arrayUser[i] <0)
        {
            negativNumber++;

        }
    }
    System.Console.WriteLine("\nКол-во положительных чисел: " + positivNumber);
    System.Console.WriteLine("Кол-во отрицательных чисел: " + negativNumber);
    System.Console.WriteLine("\nСумма положительных чисел: " + even);
    System.Console.WriteLine("Сумма отрицательных чисел: " + uneven);
}

System.Console.Write("Введите длинну массива:\t");
int length = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите отрицательное число начала чисел массива:\t");
int fromNumber = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите полжительное число пердел чисел массива:\t");
int toNumber = Convert.ToInt32(Console.ReadLine());

int[] myArray = randomNumberArray(length, fromNumber, toNumber);
PrintUserArray(myArray);
PrintResult(myArray);