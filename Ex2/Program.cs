/* Напишите программу, которая принимает
на вход три числа и проверяет, может ли
существовать треугольник с сторонами такой длины.
*/

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

bool Triangle(int a, int b, int c)
{
    if (a + b > c && b + c > a && a + c > b)
        return true;
    return false;
}

int A = InputNum("Введите первое число: ");
int B = InputNum("Введите второе число: ");
int C = InputNum("Введите третье число: ");

bool check = Triangle(A, B, C);
Console.WriteLine(check);
