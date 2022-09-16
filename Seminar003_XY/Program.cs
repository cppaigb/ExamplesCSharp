// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Введите x: ");
// bool isNumberX = int.TryParse(Console.ReadLine(), out int x);

// Console.WriteLine("Введите y: ");
// bool isNumberY = int.TryParse(Console.ReadLine(), out int y);

// if (isNumberX != true || isNumberY != true)
// {
//     Console.WriteLine("Числа введены не правильно");
//     return;
// }

// bool Validate(int x, int y)
// {
//     if (x == 0 || y == 0)
//     {
//         return false;
//     }
//     return true;
// }

// bool isValid = Validate(x, y);
// if (isValid == false)
// {
//     Console.WriteLine("Какое то число равно 0...");
//     return;
// }

// int result = GetPosition(x, y);
// Console.WriteLine($"Номер четверти: {result}");

// int GetPosition(int x, int y)
// {
//     if (x > 0 && y > 0)
//     {
//         return 1;
//     }

//     if (x < 0 && y > 0)
//     {
//         return 2;
//     }

//     if (x < 0 && y < 0)
//     {
//         return 3;
//     }

//     if (x > 0 && y < 0)
//     {
//         return 4;
//     }

//     return -1;
// }

string input = "hello world";
string output = "";
for (int i = input.Length - 1; i >= 0; i--)
{
    output = output + input[i];
}

Console.WriteLine(output);