// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

//функция Аккермана
uint Akkerman(uint n, uint m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Akkerman(n - 1, 1);
    else
      return Akkerman(n - 1, Akkerman(n, m - 1));
}

Console.Write("Введите число m: ");
uint m = Convert.ToUInt32(Console.ReadLine());
Console.Write("Введите число n: ");
uint n = Convert.ToUInt32(Console.ReadLine());
uint result = Akkerman(n,m);
Console.WriteLine(result);




 