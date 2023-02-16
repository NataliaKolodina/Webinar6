// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.

// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.Clear();

int num1 = InputNumber("Введите первое число: ");
int num2 = InputNumber("Введите второе число: ");
int num3 = InputNumber("Введите третье число: ");
Console.Write($"{num1}, {num2}, {num3} -> ");
CheckTriangle(num1, num2, num3);

int InputNumber(string message)
{
    Console.Write($"{message}: ");
    int res = int.Parse(Console.ReadLine()!);
    return res;
}

void CheckTriangle(int number1, int number2, int number3)
{
    if (number1 < (number2 + number3))
    {
        if (number2 < (number1 + number3))
        {
            if (number3 < (number2 + number1))
            {
                Console.Write("является трегольником");
            }
            else
            {
                Console.Write("не является трегольником");
            }
        }
        else
        {
            Console.Write("не является трегольником");
        }
    }
    else
    {
        Console.Write("не является трегольником");
    }
}
