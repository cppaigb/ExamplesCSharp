// Программа, которая выводит случайное число из отрезка [10,99] и
// показывет наибольшую цифру.

// Random random = new Random(); //для генерации рандомных чисел

// int randomNumber = random.Next(10, 100);
// Console.WriteLine("Случайное число: " + randomNumber);

// int lastNumber = randomNumber % 10; //остаток после запятой
// int firstNumber = randomNumber / 10;

// if(lastNumber > firstNumber)
// {
//     Console.Write($"Наибольшая цифра числа: {lastNumber}"); //интерполяция${} 
// }
// else
// {
//     Console.Write("Наибольшая цифра числа: " + firstNumber);
// }

/* Программа, которая выводит случайное трехзначное число и 
   удаляет вторую цифру */


// Random random = new Random(); //для генерации рандомных чисел

// int randomNumber = random.Next(100, 1000);
// Console.WriteLine("Случайное число: " + randomNumber);

// int numberThree = randomNumber % 10;
// Console.WriteLine($"Третье число: {numberThree}");
// int numberOne = randomNumber / 100;
// Console.WriteLine($"Первое число: {numberOne}");

// // Console.Write(numberOne);
// // Console.Write(numberThree);

// int newNumber = (numberOne * 10) + numberThree;
// Console.WriteLine($"Новое число: {newNumber}");

/* Программа, которая принимает на вход два числа и выводит,
является ли второе число кратным первому. Если число 2 не 
кратно числу 1, то программа выводит остаток от деления. */

Console.Write("Введите первое число: ");
int inputNumberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int inputNumberTwo = Convert.ToInt32(Console.ReadLine());

int result = inputNumberOne % inputNumberTwo;
Console.WriteLine(result);

// if (result == 0)
// {
//     Console.WriteLine($"Число {inputNumberOne} кратно {inputNumberTwo}");
// }
// else
// {
//     Console.WriteLine($"Число {inputNumberOne} не кратно {inputNumberTwo}, остаток от деления равен: {result}");
// }