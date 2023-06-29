/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
// вариант с циклом
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int M = InputNum("Введите количество чисел: ");
int col = 0;

for (int i = 0; i < M; i++)
    if (InputNum("Введите число: ") > 0) col = col + 1;

Console.WriteLine($"Количество положительных элементов равно {col}");


// вариант с массивом
// int InputNum(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }

// int[] CreateArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//         array[i] = InputNum($"Введите {i + 1}-е число: ");
//     return array;
// }

// int CountPosNums(int[] array)
// {
//     int index = 0;
//     for (int i = 0; i < array.Length; i++)
//         if (array[i] > 0) index++;
//     return index;
// }

// int M = InputNum("Введите количество чисел: ");
// int[] myArray = CreateArray(M);

// int count = CountPosNums(myArray);
// Console.WriteLine($"Количество положительных элементов равно {count}");
