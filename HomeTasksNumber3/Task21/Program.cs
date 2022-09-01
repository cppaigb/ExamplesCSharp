/* Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 3D пространстве.
 */

// Метод расчета расстояния между двумя точками в 3D.

double FindDistance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double result = Math.Pow(Math.Pow(x2 - x1, 2) +
    Math.Pow(y2 - y1, 2) +
    Math.Pow(z2 - z1, 2), 0.5);
    return result;
}

Console.Write("Введите координату X первой точки: ");
double firtstPointX = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y первой точки: ");
double firtstPointY = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z первой точки: ");
double firtstPointZ = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату X второй точки: ");
double secondtPointX = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y второй точки: ");
double secondtPointY = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z второй точки: ");
double secondtPointZ = Convert.ToDouble(Console.ReadLine());

double distance = FindDistance(firtstPointX, firtstPointY, firtstPointZ, secondtPointX, secondtPointY, secondtPointZ);
Console.Write($"Расстояние между двумя точкам: {distance}");

