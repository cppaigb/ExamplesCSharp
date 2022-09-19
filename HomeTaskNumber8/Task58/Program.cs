//  Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


//Матрицу P можно умножить на матрицу K только в том случае, если число столбцов матрицы P 
// равняется числу строк матрицы K. Матрицы, для которых данное условие не выполняется, умножать нельзя.

//метод умножает матрицы
int[,] MultiplyMatrix(int[,] arrayA, int[,] arrayB)
{
  
    int[,] resultArray = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
      
    if (arrayA.GetLength(0) != arrayB.GetLength(1))
{
    Console.WriteLine("-=Нельзя перемножить=-");
    return resultArray;
    }
else
{
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
            resultArray[i, j] = 0;
            for (int k = 0; k < arrayA.GetLength(0); k++)
            {
                resultArray[i, j] = resultArray[i, j] + (arrayA[i, k] * arrayB[k, j]);
            }
        }
    }
    return resultArray;
}
}

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

Console.Write("Введите количество столбцов матрицы A: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество матрицы A: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы B: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество матрицы B: ");
int k = Convert.ToInt32(Console.ReadLine());
int[,] newArrayA = new int[m, n];
FillArray(newArrayA);
PrintMatrix(newArrayA);
Console.WriteLine();
int[,] newArrayB = new int[i, k];
FillArray(newArrayB);
PrintMatrix(newArrayB);
Console.WriteLine();

int[,] newArray = MultiplyMatrix(newArrayA, newArrayB);
PrintMatrix(newArray);



