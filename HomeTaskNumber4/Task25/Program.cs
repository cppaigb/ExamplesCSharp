// Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.



//Метод возведения числа A в натуральную степень B

int AToBPower(int A, int B)
{
    int result = A;

    for (int i = 1; i < B; i++)
    {
        result = result * A;
    }
    return result;
}

Console.Write("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int res = AToBPower(numberA, numberB);
Console.WriteLine(res);
