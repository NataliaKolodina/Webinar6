// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


Console.Clear();
Console.Write("Введите число: ");
int size = int.Parse(Console.ReadLine()!);
int[] array = new int[size];

for (int i = 0; i < size; i++)
{
    if (i > 1)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    else
    {
        array[i] = i;
    }
    Console.Write($"{array[i]} ");
}
