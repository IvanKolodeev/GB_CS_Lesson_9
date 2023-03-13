// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string CountDown (int n)
{
    if (n == 1) 
    {
        return "1";
    }
    string s = n.ToString() + ", " + CountDown(n-1);
    return s;
}

Console.Write("Enter value: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(CountDown(n));