/* Напишите программу, которая принимает на вход трёхзначное
число и на выходе показывает вторую цифру этого числа. */

//Метод, который показывает вторую цифру трехзначного числа

int secondDigit(int inputNumber)
{
    int DigitNumberTwo = ((inputNumber / 10) % 10);
    return DigitNumberTwo;
}

Console.Write("Введите трехзначное число: ");
int inputNumber = Convert.ToInt32(Console.ReadLine());
int result = secondDigit(inputNumber);

while((inputNumber < 100) ^ (inputNumber > 999))
{
    Console.WriteLine("Вы ввели не трехзначное число, попробуйте ввести число еще раз:");
    Console.Write("Введите трехзначное число: ");
    inputNumber = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"Вторая цифра трехзначного числа: {result}");



//===================================================================\\
/*  Напишите программу, которая выводит третью цифру заданного числа 
    или сообщает, что третьей цифры нет. */

// int findThirdNumber(int number)
// {
//     while (number > 999)
//     {
//         number = number / 10;
//     }
//     int thirdNumber = number % 10;
//     return thirdNumber;
// }
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int result = findThirdNumber(number);

// if (number > 99)
// {
//     Console.WriteLine($"Третья цифра заданного числа: {result}");
// }
// else
// {
//     Console.WriteLine("В заданном числе нет третьей цифры!");
// }

//=========================================================================\\

/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным. */

// bool checkWeekend(int dayOfWeek)
// {
//     bool weekend = false;
//     if (dayOfWeek > 5)
//     {
//         weekend = true;
//         return weekend;
//     }
//     else
//     {
//         weekend = false;
//         return weekend;
//     }

// }

// Console.Write("Введите день недели: ");
// int inputDay = Convert.ToInt32(Console.ReadLine());
// bool result = checkWeekend(inputDay);

// if ((inputDay < 1) ^ (inputDay > 7))
// {
//     Console.WriteLine("Такого дня недели не существует");
// }
// else
// {
//     Console.WriteLine(result);
// }


