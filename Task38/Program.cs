/* Задайте массив вещественных чисел. Найдите разницу между максимальным и 
   минимальным элементов массива. */

// Метод создает массив из N элементов, заполняя его раедомными числамии от 100 до 999
double [] RandomArray(int n)
{
    double [] array = new double [n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(10 ,100) +  new Random().NextDouble();        
    }
    return array;
}

//метод вывода массива в консоль
void PrintArray(double[] array)
{
    double count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
//метод ищет разницу между максимальным и минимальным элементом массива
double FindDifferenceMaxAndMin (double[] array)
{
    double diff;
    double max = 0;
    double min = 101;
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    diff = max - min;
    return diff;
}

Console.Write("Введите кол-во элементов массива: ");
int numberOfElements = Convert.ToInt32(Console.ReadLine());

double[] newArray = RandomArray(numberOfElements);
Console.Write("Массив состоит из следующих чисел: ");
PrintArray(newArray);
double res = FindDifferenceMaxAndMin(newArray);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {Math.Round(res,4)}");

