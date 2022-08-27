// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.
// Console.Write("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());

// if(a > b) 
// {
//     Console.Write("Большее число:  ");
//     Console.WriteLine(a);
//     Console.Write("Меньшее число:  ");
//     Console.WriteLine(b);
// }
// else if(a < b)
// {
//     Console.Write("Большее число:  ");
//     Console.WriteLine(b);
//     Console.Write("Меньшее число:  ");
//     Console.WriteLine(a);
// }
// else
// {
// Console.WriteLine("Числа равны");
// }

// Задача 4: Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.
// Console.Write("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите третье число: ");
// int c = Convert.ToInt32(Console.ReadLine());

// int max=a;

// if(b > max) max =b;
// if(c > max) max =c;

// Console.WriteLine("Максимальное число: ");
// Console.WriteLine(max);

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());

// if(a%2==0)
// {
//    Console.Write("Это четное число"); 
// }
// else
// {
//     Console.Write("Это не четное число"); 
// }

// Напишите программу, которая на вход принимает число (N), а на выходе показывает 
// все чётные числа от 1 до N.
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
Console.Write("Все четные числа от 1 до N: ");
while(i < N)
{
    if(i % 2 == 0)
    {
       Console.Write(i + " ");
    }
    i++; 
}