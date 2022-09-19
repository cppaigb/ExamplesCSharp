/* Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
 */

// int[,,] array3D = new int[2, 2, 2];
// FillArray(array3D);
// PrintIndex(array3D);


// Метод вывода индекса элементов 3D массива
void PrintIndex(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}

// Метод заполнения 3D массива не повторяющимеся числами
void FillArray(int[,,] array)
{
    int count = 10;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[k, i, j] += count;
                count += 3;
            }
        }
    }
}

Console.Write("Введите количество столбцов m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество слоев i: ");
int i = Convert.ToInt32(Console.ReadLine());

if (n * m * i > 89) { Console.WriteLine("Вы вышли за предел чисел"); }
else
{
int[,,] newArray = new int[m, n, i];
FillArray(newArray);
PrintIndex(newArray);
}