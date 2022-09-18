/*  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
 элементы каждой строки двумерного массива. */

//метод выводит матрицу на экран

void PrintMatrix(int[,] matr)
{

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine("");
    }
}

//метод создает двумерный массив из случайных чисел от 1 до 9.
void FillArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
// Метод соритует строки по убыванию в двумерном массиве
void SortRowIn2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }

}

Console.Write("Введите количество столбцов m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] newArray = new int[m, n];
FillArray(newArray);
PrintMatrix(newArray);
Console.WriteLine("Отсортированный массив: ");
SortRowIn2DArray(newArray);
PrintMatrix(newArray);