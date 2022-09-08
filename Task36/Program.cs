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
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

//метод ищет количество четных чисел в массиве
int FindSumOfOddNumbers (int[] array)
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
int sum = FindSumOfOddNumbers(newArray);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна: {sum}");