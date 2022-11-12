// 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.Clear();

System.Console.Write("Введие день недели: ");
int number = Convert.ToInt32(Console.ReadLine());

string [] DayWeek = {"ПН","Вт","Ср","ЧТ","Пт","Сб","ВС"};

if (number >0 && number <8)
{
    System.Console.WriteLine(DayWeek[number-1]);
}
else System.Console.WriteLine("В неделе всего семь дней! Вы ошиблись");

Console.ReadKey();