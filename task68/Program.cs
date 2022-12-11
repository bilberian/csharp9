// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("введите натуральное число m: ");
int numM = Math.Abs(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine("введите натуральное число n: ");
int numN = Math.Abs(Convert.ToInt32(Console.ReadLine()));

int formulaAkkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return formulaAkkerman(m - 1, 1);
    return formulaAkkerman(m - 1, formulaAkkerman(m, n - 1));
}

Console.WriteLine($"Результат вычисления по функции: {formulaAkkerman(numM, numN)}");