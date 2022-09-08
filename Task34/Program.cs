/* Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
 */
// Метод создает массив из N элементов, заполняя его раедомными числамии от 100 до 999
int [] RandomArray(int n)
{
    int [] array = new int [n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(100,999);        
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
    //Console.WriteLine();
}

//метод ищет количество четных чисел в массиве
int FindNumberEvenNumbersInArray (int[] array)
{
    int even = 0;
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        if ((array[i]%2) == 0) even++;
    }
    
    return even;
}


Console.Write("Введите кол-во элементов массива: ");
int numberOfElements = Convert.ToInt32(Console.ReadLine());

int[] newArray = RandomArray(numberOfElements);
Console.Write("Массив состоит из следующих чисел: ");
PrintArray(newArray);
Console.WriteLine();

int even = FindNumberEvenNumbersInArray(newArray);
Console.WriteLine($"Количество четных элементов в массиве: {even}");
