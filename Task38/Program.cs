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
    double n = array.Length;
    for (int i = 0; i < n; i++)
    {
        Console.Write(Math.Round(array[i],1));
        if (i < n-1) Console.Write("   ");
    }
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

//Задаем кол-во элементов массива
Console.Write("Введите кол-во элементов массива - ");
int numberOfElements = Convert.ToInt32(Console.ReadLine());
//Выводим рандомный массив
double[] newArray = RandomArray(numberOfElements);
Console.Write("Массив состоит из следующих чисел: ");
PrintArray(newArray);
Console.WriteLine();
//Ищем разницу
double res = FindDifferenceMaxAndMin(newArray);
Console.WriteLine(Math.Round(res,1));
