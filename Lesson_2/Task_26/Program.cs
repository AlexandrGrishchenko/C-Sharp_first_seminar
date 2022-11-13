// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.WriteLine();

Console.Write("Введите число : ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень преобразования числа : ");
int Z = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"N = {N}^{Z}");

int getCubeUserNumber(int N)
{
    int cube = 0;
    int degree = Z;
    int number = N;
    cube = Convert.ToInt32(Math.Pow(number, degree));
    return cube;
}
System.Console.Write("N = ");
Console.WriteLine(getCubeUserNumber(N));