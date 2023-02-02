/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

void FillArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(10);
    }

}

void PrintArr(int[] arr)
{
    Console.WriteLine($"Нам дан массив из {arr.Length} элементов:");

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }

    Console.WriteLine();
}

int[] array = new int[9];

FillArr(array);
PrintArr(array);

int result = 0;

for (int i = 0; i < array.Length; i++)
{
    if (i % 2 == 1) result = result + array[i];
}

Console.Write($"Cумма элементов, стоящих на нечётных позициях равна: {result}");