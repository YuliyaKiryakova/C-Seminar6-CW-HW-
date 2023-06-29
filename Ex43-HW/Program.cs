/* Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
// первый вариант
// double InputNum(string message)
// {
//     Console.Write(message);
//     return double.Parse(Console.ReadLine()!);
// }

// double[] Coord(double k1, double b1, double k2, double b2)
// {
//     double[] coord = new double[2];
//     coord[0] = Math.Round((b2 - b1) / (k1 - k2), 2);
//     coord[1] = Math.Round(k1 * coord[0] + b1, 2);
//     return coord;
// }

// double k1 = InputNum("Введите коэффициент k1: ");
// double b1 = InputNum("Введите коэффициент b1: ");
// double k2 = InputNum("Введите коэффициент k2: ");
// double b2 = InputNum("Введите коэффициент b2: ");

// double[] res = Coord(k1, b1, k2, b2);
// Console.WriteLine($"Точка пересечения прямых ({res[0]}, {res[1]})");


// второй вариант
double InputNum(string message)
{
    Console.Write(message);
    return double.Parse(Console.ReadLine()!);
}

double k1 = InputNum("Введите коэффициент k1: ");
double b1 = InputNum("Введите коэффициент b1: ");
double k2 = InputNum("Введите коэффициент k2: ");
double b2 = InputNum("Введите коэффициент b2: ");

double[] Coord(double k1, double b1, double k2, double b2)
{
    double[] coord = new double[2];
    coord[0] = Math.Round((b2 - b1) / (k1 - k2), 2);
    coord[1] = Math.Round(k1 * coord[0] + b1, 2);
    return coord;
}

if (k1 == k2)
{
    if (b1 == b2)
        Console.WriteLine("Прямые совпадают");
    else
        Console.WriteLine("Прямые параллельны друг другу");
}
else
{
    double[] res = Coord(k1, b1, k2, b2);
    Console.WriteLine($"Точка пересечения прямых ({res[0]}, {res[1]})");
}
