/* Напишите программу, которая перевернёт
одномерный массив (последний элемент будет
на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
*/

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] CreateArray(int size)
{
    return new int[size];
}

void FillArray(int[] array, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
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

int size = InputNum("Введите размер массива: ");
int minV = InputNum("Введите мин: ");
int maxV = InputNum("Введите макс: ");

int[] myArray = CreateArray(size);
FillArray(myArray, minV, maxV);
PrintArray(myArray);
Console.WriteLine();
ReverseArray(myArray);
PrintArray(myArray);
