/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

void FilArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
}

void PrintArr(int[] array)
{
    Console.WriteLine($"Нам дан массив из {array.Length} элементов:");

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }

    Console.WriteLine();
}

int[] array = new int[15];

FilArr(array);
PrintArr(array);

int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if(array[i] % 2 == 0) count++;
}

Console.Write($"Данный массив содержит {count} четных чисел");