/* Задайте двумерный массив из целых чисел. 
   Найдите среднее арифметическое элементов в каждом столбце. 
*/
Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

int[,] mas = new int[m, n];

void PrintArray(int[,] ma)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            Console.Write($"{ma[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] FillArray(int[,] ma)
{
    int[,] mass = ma;
    Random rnd = new Random();
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            mass[i, j] = rnd.Next(1, 30);
        }
    }
    return mass;

}

FillArray(mas);
PrintArray(mas);

Console.WriteLine("Введите число из массива:"); 
int guessNumber = Convert.ToInt32(Console.ReadLine());
string GuessArrayNumber(int[,] array,int number)
{
string some = "";
    string someString = "";
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            
            if (number == array[i, j])
            {  
                someString = some;
                some= $"{i}, {j}";
            }
            else{
                Console.WriteLine("Такого числа нет");
            }
           
        }          
        
    }
    return someString;
}

Console.WriteLine(GuessArrayNumber(mas, guessNumber));
