// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void Print2Array(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(Math.Round(array[i, j], 2));

            Console.Write("  ");
        }
        Console.WriteLine();
    }
}

double[,] FillArray(int n, int m)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 10) + new Random().NextDouble();
        }
    }
    return array;
}


Console.Write("Введите количество строк m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] newArray = FillArray(m, n);
Print2Array(newArray);