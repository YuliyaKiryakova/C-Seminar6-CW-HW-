/* Не используя рекурсию, выведите первые N чисел
Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

// наша группа
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

void Fibonacci(int num)
{
    int first = 0;
    int second = 1;
    int res = 0;
    if (num == 1) Console.Write(first);
    else Console.Write(first);
        for (int i = 0; i < num-1; i++)
        {
            res = second;
            second = first + second;
            first = res;
            Console.Write(" "+res);
        }
    }

int number = InputNum("Введите целое число: ");
Fibonacci(number);

// Другая группа
// int InputNum(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }

// void Fibonacci(int num)
// {
//     if (num == 1)
//         Console.Write("0");
//     else
//         Console.Write("0 1");
//     int a = 0;
//     int b = 1;
//     for (int i = 2; i < num; i++)
//     {
//         int temp = b;
//         b = a + b;
//         a = temp;
//         Console.Write(" " + b);
//     }
// }
// int num = InputNum("");
// Fibonacci(num);
