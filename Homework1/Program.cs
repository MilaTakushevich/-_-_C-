﻿// напишите метод CompareNumbers, который на вход принимает два числа и выводит, какое число большее, а какое меньшее.

// Введите свое решение ниже

if (firstNumber < secondNumber)
{
Console.WriteLine("второе число больше");
}
else if (firstNumber > secondNumber)
{
Console.WriteLine("первое число больше");
}
else
{
Console.WriteLine("числа равны");
}


// напишите метод FindMax, который принимает на вход три числа и выдаёт максимальное из этих чисел.

// Введите свое решение ниже 

 int max = a; 
        
 if (b > max)
 {
   max = b;
 }

 if (c > max)
 {
   max = c;
 }

 return max;


// напишите метод CheckIfEven, который на вход принимает число number и выводит, является ли число чётным (делится ли оно на два без остатка).

 // Введите свое решение ниже
if (number % 2 == 0)
    {
        Console.WriteLine("четное");
    }
    else
    {
        Console.WriteLine("нечетное");
    }

// напишите метод PrintEvenNumbers, которая на вход принимает число (number), а на выходе выводит все чётные числа от 1 до number (включительно), после каждого числа должен быть знак пробела.

// Введите свое решение ниже
for (int i = 2; i <= number; i += 2)
        {
            Console.Write(i + " ");

    }


