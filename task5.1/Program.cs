// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.
// !! И перемножить эти два массива


Console.Clear();

int length = InputNumber("Введите количество элементов в массиве: ");
int min = InputNumber("Введите минимальное значение в массиве: ");
int max = InputNumber("Введите максимальное значение в массиве: ");
int[] arr = GetArray(length, min, max);
Console.WriteLine(String.Join(" ", arr));
int[] newArr = CopyArray(arr);
Console.WriteLine(String.Join(" ", newArr));
int[] resultArr = NewArray(arr, newArr);
Console.WriteLine(String.Join(" ", resultArr));

int InputNumber(string message)
{
    Console.Write($"{message}: ");
    int res = int.Parse(Console.ReadLine()!);
    return res;
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int[] CopyArray(int[] array)
{
    int[] res = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        res[i] = array[i];
    }
    return res;
}

int[] NewArray(int[] array1, int[] array2)
{
    int[] result = new int[array1.Length];
    for (int i = 0; i < array1.Length; i++)
    {
        result[i] = array1[i] * array2[i];
    }
    return result;
}
