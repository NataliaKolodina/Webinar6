// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

Console.Write($"{num} -> {BinarySystem(num)}");

string BinarySystem(int number)
{
    string result = "";
    while (number > 0)
    {
        result = Convert.ToString(number % 2) + result;
        number = number / 2;
    }
    return result;
}
