/*Задача
Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [10,90].


int[] array = {1, 5, 10, 20, 30, 40, 99, 4, 90, 3}; 
int numbers = 0;
foreach (int e in array)
{
    if (e >= 10 && e <= 90)
    {
        numbers = numbers + 1;
    }
}
 Console.WriteLine (numbers);
 
 //  Ответ автотеста. Исправлен код



 Задача 2
 Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.

int[] array = {2, 5, 2, 3, 6, 3, 7, 8, 2, 4};
int CountEvenItems(int[] array)
    {
        int i = 0;
        int count = 0;
        while(i < array.Length)
        {
          if(array[i] % 2 == 0)
          {
            count++;
          }
          i++;
        }
      return count;
    }
void PrintCount(int count)
    {
        Console.WriteLine( + count);
    }

int count = CountEvenItems(array);
PrintCount(count);


Задача 3
Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.

*/

double[] array = {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01}; // Создание массива
// Разница между максимальным и минимальным элементами массива 
  
  double FindMin(double[] array) // Нахождение минимума массива
    {
      double min = array[0];
      for (int i = 0; i < array.Length; i++)
      {
        if(array[i] < min)
        {
          min = array[i];
        }
      }
      return min;
    }
    
  
  double FindMax(double[] array) // Нахождение максимума массива
    {
      double max = array[0];
      for (int i = 0; i < array.Length; i++)
      {
        if(array[i] > max)
        {
          max = array[i];
        }
      }
      return max;
    }
    System.Console.WriteLine(FindMin(array)); 
    System.Console.WriteLine(FindMax(array));
    
    void PrintResult(double[] array)
    {
      double result = FindMax(array) - FindMin(array);
      System.Console.WriteLine(result);
    }

    PrintResult(array);

