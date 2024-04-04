/*
Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.
Решение:
int M = 1;
int N = 10;

PrintNumbers(M, N);

void PrintNumbers(int M, int N)
    {
        if (M <= N)
        {
            Console.WriteLine(M); // Выводим число
            PrintNumbers(M + 1, N); // Рекурсивно вызываем функцию для следующего числа
        }
    }


Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Решение:
*/
int m = 2;
int n = 3;

int result = AckermannFunction(m, n);

Console.WriteLine($"Значение функции Аккермана для m = {m} и n = {n}: {result}");

int AckermannFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return AckermannFunction(m - 1, 1);
    }
    else
    {
        return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    }
}

/*
Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
*/
