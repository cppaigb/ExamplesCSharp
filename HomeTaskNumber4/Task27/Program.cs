// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//Метод поиска количества цифр в числе

int AmountDigitInNumber(int number)
{
    int amountDig = 1;

    while (number / 10 != 0)
    {
        amountDig++;
        number = number / 10;
    }

    return amountDig;
}


//Метод, выдает сумму цифр в числе
int SumDigits(int number, int amount)
{
    int sum = 0;
    for (int i = 0; i < amount; i++)
    {
        sum = sum + (number % 10);
        number = number / 10;
    }
    return sum;
}


Console.Write("Введите число: ");

// Проверяем введено ли число

bool isNumberN= int.TryParse(Console.ReadLine(), out int inputNumber);

if (isNumberN != true)
{
    Console.WriteLine("Вы ввели не число");
    return;
}

int amount = AmountDigitInNumber(inputNumber);
Console.WriteLine($"Количество цифр в введенном числе: {amount}");
int sumNumbers = SumDigits(inputNumber, amount);
Console.WriteLine($"Cумма цифр в введенном числе: {sumNumbers}");