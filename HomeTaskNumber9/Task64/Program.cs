// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"Натуральные числа в промежутке от M до N равна: ");
NumbersFromMToN(m, n);

// функция поиска натуральных чисел от M до N
void NumbersFromMToN(int m, int n)
{

    if (m > n)
    {
        return;
    }
    else
    {

        NumbersFromMToN(m, n - 1);
        Console.Write($"{n}, ");
    }
}


