/* Напишите программу, которая на вход принимает два числа и проверяет, является
ли первое число квадратом второго.
a = 5, b = 25 -> да
a = 2, b = 10 -> нет */

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b =Convert.ToInt32(Console.ReadLine());

if (a * a == b)
{
    Console.WriteLine("первое число является корнем для второго числа");
}

else

{
    Console.WriteLine("первое число не является корнем для второго числа");
};


