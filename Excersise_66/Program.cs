// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumBetween (int m, int n)
{
    if (n==m) return n;
    int sum = n + SumBetween(m, n-1);
    return sum;
}

Console.Write("Enter value M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Enter value N: ");
int n = int.Parse(Console.ReadLine()!);

if (m >= n)
{
    Console.WriteLine("Can not continue: number M >= number N");
    return;
}

int sum = SumBetween(m, n);
Console.WriteLine($"Sum of numbes between {m} and {n} is {sum}");