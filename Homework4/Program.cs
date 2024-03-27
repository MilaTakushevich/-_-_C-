Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.
Решение:
ComplianceTesting();

void ComplianceTesting()
{
    while (true)
    {
        Console.WriteLine("Введите целое число или 'q' для выхода:");
        string input = Console.ReadLine();
        if (input == "q")
        {
            Console.WriteLine("Программа завершена.");
            break;
        }
        else
        {
            // выполняем проверку того, удалось ли успешно преобразовать введенную строку input в целое число
            if (int.TryParse(input, out int number))
            {
                if (IsSumOfDigitsEven(number))
                {
                    Console.WriteLine($"Сумма цифр числа {number} четная. Программа завершена.");
                    break;
                }

            }
            else
            {
                System.Console.WriteLine("Введено некорректное значение");
            }
        }
    }
}
bool IsSumOfDigitsEven(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    return sum % 2 == 0;
}

Задача 2: Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
Решение:

int[] arrayThreeDigit = FillArrayThreeDigit(); // Заполняем массив трехзначными числами
PrintArray(arrayThreeDigit); // Выводим содержимое массива на экран
int count = CountThreeDigit(arrayThreeDigit);
Console.WriteLine("Количество четных чисел: " + count); // Выводим количество четных чисел

int[] FillArrayThreeDigit() // Заполняем массив рандомными трехзначными числами
{
    Random random = new Random();
    int[] arrayThreeDigit = new int[10]; // размер массива 10 чисел

    // Заполняем массив случайными трехзначными числами
    for (int i = 0; i < arrayThreeDigit.Length; i++)
    {
        // Генерируем случайное трехзначное число от 100 до 999
        arrayThreeDigit[i] = random.Next(100, 1000);
    }

    return arrayThreeDigit; // Возвращаем заполненный массив
}
void PrintArray(int[] array) // Вывод содержимого массива на экран
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}
int CountThreeDigit(int[] arrayThreeDigit)
{
    int count = 0;
    for (int i = 0; i < arrayThreeDigit.Length; i++)
    {
        if (arrayThreeDigit[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

Задача 3: Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)
Решение:

int[] array = FillArray(); // Заполняем массив числами
PrintArray(array); // Выводим содержимое массива на экран
ReverseArray(array); // Переворачиваем массив
PrintArray(array); // Выводим содержимое массива на экран

int[] FillArray() // Заполняем массив рандомными числами
{
    Random random = new Random();
    int[] array = new int[11]; // размер массива 10 чисел

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(1, 1000);
    }

    return array; // Возвращаем заполненный массив
}
void PrintArray(int[] array) // Вывод содержимого массива на экран
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}
void ReverseArray(int[] array) // Переворачиваем массив
{
    for (int i = 0; i < array.Length/2; i++)
    {
    int box = array[i];
    array[i] = array[array.Length - 1 - i];
    array[array.Length - 1 - i] = box;
    }
   
}

