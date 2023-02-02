// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


void PrintArr(double[] array)
{
    Console.WriteLine($"Нам дан массив из {array.Length} элементов:");

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }

    Console.WriteLine();
}

int max = 0;
int min = 0;

double[] arr = { 1.5, 8.6, 0.3, 6.2, 1.1, 3.2, 8.3, 5.2 };

PrintArr(arr);

for (int i = 1; i < arr.Length; i++)
{
    if(arr[i] < arr[min]) min = i;
    if(arr[i] > arr[max]) max = i;
}

 Console.WriteLine($"В указанном массиве вещественных чисел разница между максимальным ({arr[max]}) и минимальным ({arr[min]}) элементом равна: " + (arr[max] - arr[min]));