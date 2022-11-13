// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.WriteLine();

Console.Write("Введите число:   ");
string writeN = Console.ReadLine();
int N = Convert.ToInt32(writeN);


int[] GetCubeTable(int N)
{
    int[] cubs = new int[N];
    int number = 1;
    for (int i = 0; i < N; i++)
    {
        cubs[i] = number * number * number;
        number++;
    }
    return cubs;
}

void PrintCubs(int[] array)
{
    int number = 1;
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{number} ^ 3 = ");
        Console.WriteLine(array[i]);
        number++;
    }
}

int[] CubeTable = GetCubeTable(N);
PrintCubs(CubeTable);