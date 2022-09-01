/* Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом. */

Console.Write("Введите пятизначное число: ");
int inpNumber = Convert.ToInt32(Console.ReadLine());

// Метод проверки ввода числа, является ли оно пятизначным.
int CheckInput(int inpNumber)
{
    while (inpNumber < 10000 || inpNumber > 99999)
    {
        Console.WriteLine("Вы ввели не пятизначное число, попробуйте ввести число еще раз:");
        Console.Write("Введите пятизначное число: ");
        inpNumber = Convert.ToInt32(Console.ReadLine());
    }
    return inpNumber;
}
int checkNumber = CheckInput(inpNumber);

string inputNumber = inpNumber.ToString();

// Метод, разворачивающий число.
string ReverseNumber(string inputNumber)
{
    string output = "";
    for (int i = inputNumber.Length - 1; i >= 0; i--)
    {
        output = output + inputNumber[i];
    }
    return output;
}

//Метод проверки является ли число палиндром.

bool CheckPalindrome(string checkNumber, string revNumber)
{
    if (inputNumber == revNumber)
    {
        Console.WriteLine($"Число {checkNumber} является полиндромом");
        return true;
    }
    Console.WriteLine($"Число {checkNumber} не является полиндромом");
    return false;

}

string revNumber = ReverseNumber(inputNumber);
Console.WriteLine($"Реверс введенного числа равен: {revNumber}");
bool checkP = CheckPalindrome(inputNumber, revNumber);


