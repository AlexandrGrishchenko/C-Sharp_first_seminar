// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
/**Замечание преподователя: обе функции генерации не дают хороший результа, со временем не дает уникальность, второе уменьшает количество элементов
for (k = 0; k < n - 1; k++) array[i++, j] = value++;
for (k = 0; k < n - 1; k++) array[i, j--] = value++;
for (k = 0; k < n - 1; k++) array[i--, j] = value++;
Такой код плохо читается**/


Console.Clear();
int[,,] array3D = new int[2, 2, 2];
// Функция вывода индекса элементов 3D массива
void PrintIndex(int[,,] arr)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"{array3D[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}

// Функция заполнения 3D массива не повторяющимеся числами
void FillArray(int[,,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                long time = DateTime.Now.Ticks;
                String fileName = Convert.ToString(time % 100);
                int timeRandonNumber = int.Parse(fileName);
                arr[k, i, j] = timeRandonNumber;
            }
        }
    }
}

// // Функция заполнения 3D массива не повторяющимеся числами, второй вариант
// void FillArray(int[,,] arr)
// {
//     int count = 10;
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             for (int k = 0; k < arr.GetLength(2); k++)
//             {
//                 arr[k, i, j] += count;
//                 count += 3;
//             }
//         }
//     }
// }

FillArray(array3D);
PrintIndex(array3D);
Console.ReadKey();