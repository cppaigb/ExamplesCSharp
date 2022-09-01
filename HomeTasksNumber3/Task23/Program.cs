// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// Math.Pow(in,2) - возведение в степент

//Метод принимает на вход число N и выдает таблицу кубов чисел от 1 до N.
int[] GetCubeNumbers(int n)
{
    int i = 1;
    int [] result = new int[n];
    while (i <= n)
    {
        result[i - 1] = (int)Math.Pow(i, 3);
        i++;
    }
    return result;
}

//Метод вывода массива на экран

void PrintArray(int[] array, int n)
{
    int i = 0;

    while (i < n)
    {
        Console.Write(array[i] + " ");
        i++;
    }
}

Console.Write("Введите число N: ");
bool isNumberN= int.TryParse(Console.ReadLine(), out int inputN);

if (isNumberN != true)
{
    Console.WriteLine("Вы ввели не число");
    return;
}

int[] newArray = GetCubeNumbers(inputN);
PrintArray(newArray, inputN);
