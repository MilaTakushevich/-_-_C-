/* Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

Console.WriteLine("Ведите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number %7 == 0 && number %23 == 0)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}

// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

Console.WriteLine("Ведите координату х (х не равно 0): ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ведите координату у (у не равно 0): ");
int y = Convert.ToInt32(Console.ReadLine());

if(x > 0 && y > 0)
{
    Console.WriteLine("Первый номер координатной четверти плоскости");
}
else if(x < 0 && y > 0)
{
    Console.WriteLine("Второй номер координатной четверти плоскости");
}
else if(x < 0 && y < 0)
{
    Console.WriteLine("Третий номер координатной четверти плоскости");
}
else if(x > 0 && y < 0)
{
    Console.WriteLine("Четвертый номер координатной четверти плоскости");
}
else 
    Console.WriteLine("Точка находится на оси координат");


// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.
 Выводим приглашение для ввода двузначного числа
Console.WriteLine("Введите двузначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
        
// Проверяем, является ли введенное число двузначным
if (number > 10 && number < 100)
    {
// Разбиваем число на десятки и единицы
        int dec = number / 10; // десятки
        int ed = number % 10;  // единицы
            
// Проверяем, какая цифра больше и выводим ее
        if (dec > ed)
            {
                Console.WriteLine(dec);
            }
            else
            {
                Console.WriteLine(ed);
            }
    }
else
    {
// Если число не двузначное, выводим сообщение об ошибке
        Console.WriteLine("Ваше число не двузначное");
    }

вариант 2(как в автоответах)

Console.Write("Введите число из отрезка [10, 99]: "); 
int number = Convert.ToInt32(Console.ReadLine()); 

int firstDigit = number / 10; 
int secondDigit = number % 10; 

int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit; 
условие ? значение_если_истина : значение_если_ложь;
Console.WriteLine(maxDigit);

// Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.    


Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
        string numberStr = number.ToString();
        Console.Write(numberStr[0]);
        for (int i = 1; i < numberStr.Length; i++)
        {
            Console.Write(", " + numberStr[i]);
        }

*/

Console.Write("Введите натуральное число N: "); 
int N = Convert.ToInt32(Console.ReadLine()); 

 
    while (N > 0) 
    { 
        int currentDigit = N % 10; 
        N /= 10; 
        if (N > 0) 
{  
    Console.Write(currentDigit + ","); 
}
else 
{
    Console.WriteLine(currentDigit); 
}
    }
