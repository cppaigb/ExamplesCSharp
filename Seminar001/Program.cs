// Программа, которая выводит случайное число из отрезка [10,99] и
// показывет наибольшую цифру.

Random random = new Random(); //для генерации рандомных чисел

int randomNumber = random.Next(10, 100);
Console.WriteLine("Случайное число: " + randomNumber);

int lastNumber = randomNumber % 10; //остаток после запятой
int firstNumber = randomNumber / 10;

if(lastNumber > firstNumber)
{
    Console.Write($"Наибольшая цифра числа: {lastNumber}"); //интерполяция${} 
}
else
{
    Console.Write("Наибольшая цифра числа: " + firstNumber);
}

//Программа, которая выводит случайное трехзначное число и 
//удаляет вторую цифру