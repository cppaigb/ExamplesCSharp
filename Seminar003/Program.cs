// Выдает третий символ числа, проверяет на длину.
/* 
string input = Console.ReadLine();

bool ValidateInput(string input)
{
    bool isNumber = int.TryParse(input, out int number); //Преобразует строковое представление числа в эквивалентное ему 32-битовое целое 
                                                         //число со знаком. Возвращает значение, указывающее, успешно ли выполнена операция.
                                                         // if(!isNumber)

    if (number < 100 && number > -100)
    {
        return false;
    }

    if (input.Length != 3) //Рассчитывает длину вводимого текста. != //обозначает НЕ РАВНО!!
    {
        return false;
    }
    return true;
}

char GetThirdNumber(string number)
{
    return number[2];
}

bool isValid = ValidateInput(input);

if (!isValid) //! принимает false, переворачивает символ.
{
    Console.WriteLine($"No valid number {input}");
    return;
}

char result = GetThirdNumber(input);
Console.WriteLine(result); */


/////////////////////////
// Напишите программу, которая на вход принимает число (N), а на выходе показывает 
// все чётные числа от 1 до N.

// Math.Pow(in,2) - возведение в степент
//Метод вывода массива на экран
int array = Convert.ToInt32(Console.ReadLine());
void PrintArray(int[] array)
{
    int i = 0;
    int lenght=array.Length;

    while(i<lenght)
    {
        Console.Write(array[i] + " ");
        i++;
    }
}

Math.Pow