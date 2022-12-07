// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("введите число");
int number1 = Convert.ToInt32(Console.ReadLine());
int num = 2;
Console.Write("Все чётные числа: ");
while (num <= number1)
{
Console.Write(num + " ");
num = num + 2;
}

