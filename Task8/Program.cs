// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите целое число: ");
int N = int.Parse(Console.ReadLine());
int A = 1;
while (A <= N)
{
    int div = A % 2;
    if (div == 0)
    {
        Console.WriteLine(A);
    }
    A += 1;
}