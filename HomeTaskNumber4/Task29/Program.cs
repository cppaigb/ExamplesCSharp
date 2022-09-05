// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// Метод создает массив из n элементов и заполняет его случайными числами от 1 до 9.
int[] Array(int n)
{
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
    return array;
}


//метод вывода массива на экран

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int n = 8; //Задается массив из 8 элементов
int[] newArray = Array(n);
PrintArray(newArray);