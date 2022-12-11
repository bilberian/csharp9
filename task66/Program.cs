// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

Console.WriteLine("введите натуральное число M: ");
int numberM = Math.Abs(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine("введите натуральное число N: ");
int numberN = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int sum = 0;

if (numberM == numberN) Console.WriteLine($"Сумма натуральных элементов в промежутке M-N: {sum}");
else
{
    int showSum(int m, int n)
    {
        if (m < n) return sum += m + showSum(m + 1, n);
        if (n < m) return sum += n + showSum(m, n + 1);
        else return sum += m; 
    }
    Console.WriteLine($"Сумма натуральных элементов в промежутке M-N: {showSum(numberM, numberN)}");
}
