// Программа, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int result = numberB * numberB;

if (result == numberA)
{
Console.WriteLine("Первое число является квадратом второго");
}
else
{
Console.WriteLine("Первое число не является квадратом второго");
}