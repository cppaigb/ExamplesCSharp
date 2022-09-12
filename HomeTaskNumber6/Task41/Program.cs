// Пользователь вводит с клавиатуры m чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//Метод создает массив из М чисел и заполняется вручную
int[] CreateManualArray(int m)
{
    int[] array = new int[m];
    for (int i = 0; i < m; i++)
    {
        Console.Write($"Введите {i + 1} элемент массива: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int CountPositiveNumbers(int[] array)
{
    int positive=0;
    for(int i =0; i<array.Length; i++)
    {
        if (array[i]>0) {positive++;}
     }
     return positive;
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

Console.Write("Сколько чисел необходимо ввести: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] newArray = CreateManualArray(m);
Console.Write("Введенные числа: ");
PrintArray(newArray);
int resultPositive=CountPositiveNumbers(newArray);
Console.Write($"Количество введенных чисел больше 0, равно: {resultPositive}");
