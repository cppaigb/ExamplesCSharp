// /* Задайте двумерный массив из целых чисел. 
//    Найдите среднее арифметическое элементов в каждом столбце. 
// */

// void PrintMatrix(int[,] matr)
// {

//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine("");
//     }
// }

// //метод создает двумерный массив из случайных чисел от 1 до 9.
// double[,] FillArray(int m, int n)
// {
// double[,] array = new double[m, n];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
//     return array;
// }
// // метод ищет среднее арифметическое каждого столбца
// double[] AverageNumbersOfEveryColumn(double[,] array)
// {
// double[] avgNumbers = new double[array.GetLength(1)];

// for (int i = 0; i < array.GetLength(1); i++)
// {
//     double result = 0.0;
//     for (int j = 0; j < array.GetLength(0); j++)
//     {
//         result += array[j, i];
//     }
//     avgNumbers[i] = result / array.GetLength(0);
// }
// return avgNumbers;
// }

// // Функция вывода массива в терминал 
// void PrintArray(double[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i]);
//         if (i == array.Length -1) Console.Write(".");
//         else Console.Write("; ");
//     }
//    }


// Console.Write("Введите количество столбцов m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество строк n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// double[,] newArray = FillArray(n, m);
// FillArray(newArray);
// PrintMatrix(newArray);

// double[] resaultAverage = AverageNumbersOfEveryColumn(newArray);
// PrintArray(resaultAverage);

// int rows = 3;
// int colums = 4;
// int[,] numbers = new int[rows, colums];
// FillArray2D(numbers);
// PrintArray2D(numbers);


// Заполнение массива рандомными вещественными числами
void FillArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

//  Функция вывода двумерного массива в терминал
void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Функция вывода массива в терминал 
void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.Write("Введите количество столбцов m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[m, n];
FillArray2D(numbers);
PrintArray2D(numbers);
void AvgArray(double[,] array)
{
double[] avgNumbers = new double[numbers.GetLength(1)];

for (int i = 0; i < numbers.GetLength(1); i++)
{
    double result = 0.0;
    for (int j = 0; j < numbers.GetLength(0); j++)
    {
        result += numbers[j, i];
    }
    avgNumbers[i] = result / numbers.GetLength(0);
}
}
AvgArray(numbers);
PrintArray(avgNumbers);

