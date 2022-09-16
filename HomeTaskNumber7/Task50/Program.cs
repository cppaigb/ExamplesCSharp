/* Напишите программу, которая на вход принимает число и ищет в двумерном массиве, 
и возвращает индексы этого элемента или же указание, что такого элемента нет. */

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

//метод ищет сколько раз встречается в массиве число в массиве
int CountNumber(int[,] array, int inputNumber)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == inputNumber) { count++; };
        }
    }
    return count;
}

//метод создает массив с координатами совпавших чисел
int[] FindNumbers(int[,] array, int count, int inputNumber)
{
    int[] resArray = new int[count * 2];
    int x = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            while (x != count * 2)
            {
                if (array[i, j] == inputNumber)
                {
                    resArray[x] = i;
                    x++;
                    resArray[x] = j;
                    x++;
                }
                break;
            }
        }
    }
    return resArray;
}

// Метод выводит координаты на экран
void PrintCordinates(int[] array)
{
    if (array.Length == 0) Console.Write("нет такого элемента");
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        count++;
        if (count % 2 == 1) Console.Write(",");
        if (count % 2 == 0) Console.Write("   ");
    }
}


Console.Write("Введите количество столбцов m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число для поиска в массиве: ");
int inputNumber = Convert.ToInt32(Console.ReadLine());
int[,] newArray = new int[n, m];
FillArray(newArray);
PrintMatrix(newArray);
int[] cordinatesLists = FindNumbers(newArray, CountNumber(newArray, inputNumber), inputNumber);
Console.WriteLine($"Число встресается {CountNumber(newArray, inputNumber)} раза и имеет следующие индексы: ");
PrintCordinates(cordinatesLists);
