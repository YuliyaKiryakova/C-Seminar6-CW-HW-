/* Напишите программу, которая будет
преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10
*/

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] Division(int num)
{
    int temp = num;
    int index = 0;
    int res = num;
    while (temp != 0)
    {
        temp = temp / 2;
        index++;
    }
    int[] array = new int[index];
    for (int i = 0; i < index; i++)
    {
        res = num % 2;
        num = num / 2;
        array[i] = res;
    }
    return array;
}

void ReverseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++) //
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
    }
    Console.WriteLine();
}

int number = InputNum("Введите число: ");
int[] myArray = Division(number);
PrintArray(myArray);
ReverseArray(myArray);
PrintArray(myArray);

// Осман код
// Console.Clear();
// System.Console.Write("число: ");
// int num = int.Parse(Console.ReadLine()!);
// string count = "";

// while (num != 0)
// {
// 	count = num % 2 + count;
// 	num = num / 2;
// }
// System.Console.WriteLine(count);