﻿/* напишите программу , которая будет выдавать день недели по заданному номеру
3 -> среда
5 -> пятница*/

Console.WriteLine("Введите число от 1 до 7: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a == 1)
{
     Console.WriteLine("Да это же понедельник");
}
else if (a == 2)
{
     Console.WriteLine("Вторник!");
}
else if (a == 3)
{
     Console.WriteLine("Среда!");
}
else if (a == 4)
{
     Console.WriteLine("Четверг!");
}
else if (a == 5)
{
     Console.WriteLine("Пятничка!");
}
else if (a == 6)
{
     Console.WriteLine("Суббота!");
}
else if (a == 7)
{
     Console.WriteLine("Воскресенье!");
}
else
{
     Console.WriteLine("Внимательнее!!!");
}


