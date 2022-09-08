/* Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях. */

// Метод создает массив из N элементов, заполняя его раедомными числамии от 100 до 999
int [] RandomArray(int n)
{
    int [] array = new int [n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(10,100);        
    }
    return array;
}

//метод вывода массива в консоль
void PrintArray(int[] array)
{
    int n = array.Length;
    for (int i = 0; i < n; i++)
    {
        Console.Write(array[i]);
        if (i < n-1) Console.Write(", ");
    }
}

//метод ищет количество четных чисел в массиве
int FindSumOfUneven (int[] array)
{
    int sum = 0;
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        if ((i%2) == 0) sum = sum + array[i];
    }
    
    return sum;
}


Console.Write("Введите кол-во элементов массива: ");
int numberOfElements = Convert.ToInt32(Console.ReadLine());
int[] newArray = RandomArray(numberOfElements);
Console.Write("Массив состоит из следующих чисел: ");
PrintArray(newArray);
Console.WriteLine();
int summ = FindSumOfUneven(newArray);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {summ}");