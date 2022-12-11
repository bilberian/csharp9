// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.WriteLine("введите число N: ");
int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int endNum = 1;

string getDigits(int number, int endNumber)
{
    return number >= endNumber ? $"{number} " + getDigits(number - 1, endNumber) : String.Empty;
}

Console.WriteLine(getDigits(num, endNum));