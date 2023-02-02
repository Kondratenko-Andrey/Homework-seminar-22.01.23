/* Дан список некоторых целых чисел, найдите значение 20 в нем и, если оно присутствует, замените его на 200. Обновите список только при первом вхождении числа 20. (можно использовать List<integer> )
[21, 53,20, 56, 45,20] -> [21, 53,200, 56, 45,20] */

void FillArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(15, 21);
    }

}

void PrintArr(int[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }

    Console.WriteLine();
}

int[] array = new int[10];

FillArr(array);

Console.WriteLine($"Нам дан массив из {array.Length} элементов:");

PrintArr(array);

for (int i = 0; i < array.Length; i++)
{
    if (array[i] == 20)
    {
        array[i] = 200;
        break;
    }
}

Console.WriteLine("Массив после проведения операции по поиску и замене 20:");
PrintArr(array);
