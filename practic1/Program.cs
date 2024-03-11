﻿// Задача вывести на экран последную цифру в трехзначном числе

// Проверка, что число находится в диапазоне
//if (number <1000 && number > 99)
//{ 
// Получение последней цифры числа
//int lastDigit = number % 10;
// Вывод последней цифры на консоль
//Console.WriteLine(lastDigit);
//}
//else
//{
// Вывод сообщения об ошибке, если число не удовлетворяет условию
//Console.WriteLine("Число должно быть в диапазоне");
//}


// Задача найти все числа от -х до х
// Выводим приглашение для ввода числа
//Console.WriteLine("Введите число: ");
// Считываем введенное пользователем число и преобразуем его в целочисленный тип
//int number = Convert.ToInt32(Console.ReadLine());

// Инициализируем переменную для отслеживания текущего значения
//int i = -number;

// Используем цикл while для вывода чисел от -number до number
//while (i <= number)
//{
// Выводим текущее значение i на консоль с пробелом
//Console.Write(i + " ");
// Увеличиваем значение i на 1
//i = i + 1;
//}

// Написать программу, которая будет отображать день недели по заданному номеру
// Выводим приглашение для ввода числа
Console.WriteLine("Введите числовой номер дня недели: ");
// Считываем введенное пользователем значение и преобразуем его в символьный тип
int num_day = Convert.ToInt32(Console.ReadLine());

// Проверяем, введен ли символ '1'
if (num_day == 1) // Заменена операция присваивания '=' на операцию сравнения '=='
{
    // Выводим название дня недели на консоль
    Console.WriteLine("Понедельник");
}
if (num_day == 2) // Заменена операция присваивания '=' на операцию сравнения '=='
{
    // Выводим название дня недели на консоль
    Console.WriteLine("Вторник");
}
if (num_day == 3) // Заменена операция присваивания '=' на операцию сравнения '=='
{
    // Выводим название дня недели на консоль
    Console.WriteLine("Среда");
}
if (num_day == 4) // Заменена операция присваивания '=' на операцию сравнения '=='
{
    // Выводим название дня недели на консоль
    Console.WriteLine("Четверг");
}
if (num_day == 5) // Заменена операция присваивания '=' на операцию сравнения '=='
{
    // Выводим название дня недели на консоль
    Console.WriteLine("Пятница");
}
if (num_day == 6) // Заменена операция присваивания '=' на операцию сравнения '=='
{
    // Выводим название дня недели на консоль
    Console.WriteLine("Суббота");
}
if (num_day == 7) // Заменена операция присваивания '=' на операцию сравнения '=='
{
    // Выводим название дня недели на консоль
    Console.WriteLine("Воскресенье");
}
else

    // Выводим название дня недели на консоль
    Console.WriteLine("Нет такого дня недели");


// Альтернативное (лучшее) решение. В прошлом выходит каждый раз елз и не отрабатывает более одного символа на ввод
//Console.WriteLine("Введите числовой номер дня недели: ");
//int num_day; // Используем числовой тип данных для хранения введенного значения
             //
             // Пытаемся преобразовать введенную строку в число
             //        if (int.TryParse(Console.ReadLine(), out num_day))
             //        {
             // Проверяем, что введенное число находится в диапазоне от 1 до 7
             //            if (num_day >= 1 && num_day <= 7)
             //            {
             // Определяем день недели в зависимости от введенного числа
             //                switch (num_day)
             //                {
             //                    case 1:
             //                        Console.WriteLine("Понедельник");
             //                        break;
             //                    case 2:
             //                        Console.WriteLine("Вторник");
             //                        break;
             //                    case 3:
             //                        Console.WriteLine("Среда");
             //                        break;
             //                    case 4:
             //                        Console.WriteLine("Четверг");
             //                        break;
             //                    case 5:
             //                        Console.WriteLine("Пятница");
             //                        break;
             //                    case 6:
             //                        Console.WriteLine("Суббота");
             //                        break;
             //                    case 7:
             //                        Console.WriteLine("Воскресенье");
             //                        break;
             //                }
             //            }
             //            else
             //            {
             //                Console.WriteLine("Нет такого дня недели");
             //            }
             //        }
             //        else
             //        {
             // Выводим сообщение об ошибке, если введенное значение не удалось преобразовать в число
             //            Console.WriteLine("Ошибка ввода. Пожалуйста, введите числовой номер дня недели.");
             //        }


// Проверить является ли второе число квадратом первого
//Console.WriteLine("Введите число: ");
// Преобразование введенной строки в целочисленное значение
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите второе число: ");
// Преобразование введенной строки в целочисленное значение
//int b = Convert.ToInt32(Console.ReadLine());

//if (b == a * a)
//{
//    Console.WriteLine(b);
//}
//else
//{
//   Console.WriteLine("Второе число не является квадратом первого"); 
//}


// Напишите программу, которая принимает на вход трёхзначное целое число и на выходе показывает сумму первой и последней цифры этого числа.
//Console.WriteLine("Введите число: ");
// Преобразование введенной строки в целочисленное значение
//int num = Convert.ToInt32(Console.ReadLine());

//if (num < 1000 && num > 99)
//{
//    int num2 = (num - num % 100) / 100;
//    int num3 = num % 10;
//    int num4 = num2 + num3;

//    Console.WriteLine(num4);
//}
//else
//{
//    Console.WriteLine("Введите трехзначное число");
//}