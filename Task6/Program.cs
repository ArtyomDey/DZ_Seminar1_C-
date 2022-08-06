// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите целое число: ");
int number = int.Parse(Console.ReadLine());
int div = number % 2;
if (div == 0)
{
    Console.Write("Это чётное число!");
}
else
{
    Console.Write("Это нечётное число!");
}