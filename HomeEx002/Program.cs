// Console.Write("Введите трехзначное число: ");
// // int NumberArray = Convert.ToInt32(Console.ReadLine());
// int NumberArray = 546;

// int[] array = new int[546];
// Console.WriteLine(array);

// // int n = array.Length;

// // Console.WriteLine(array[1]);
// Console.Clear();
// Console.WriteLine("Задача 10 ");
// Console.Write("Введи трёхзначное число: ");
// int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
// string stringNumber = Convert.ToString(threeDigitNumber);
// Console.WriteLine("вторая цифра этого числа -> "+stringNumber[1]);

//Напишите программу, которая принимает на вход трёхзначное
// число и на выходе показывает вторую цифру этого числа.

//Метод, который показывает вторую цифру трехзначного числа

// int findSecondDigit(int threeDigitNumber)
// {
//     int secondDigit = (threeDigitNumber/10)%10;
//     return secondDigit;
// }

// Console.Write("Введите 3-значное число - ");
// int newThreeDigitNumber = Convert.ToInt32(Console.ReadLine());
// int result = findSecondDigit(newThreeDigitNumber);

// Console.WriteLine(result); 

int secondDigit (int Number)
{
    int DigitNumber2 = ((Number/10)%10);
    return DigitNumber2;
}

Console.Write("Введите трехзначное число: ");
int inputNumber = Convert.ToInt32(Console.ReadLine());
int result = secondDigit(inputNumber);

Console.WriteLine(result);
