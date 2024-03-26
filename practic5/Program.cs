int[] test = {10, 5, 2, 15,25};
int num = 15;
for (int i = 0; i < test.Length; i++)
{
   if(test[i] == num) 
   {System.Console.WriteLine("yes");}
   else if(i == test.Length - 1)
   {System.Console.WriteLine("no");}
}
/*
void PrintArray(int[] arrayToPrint)
{
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i != arrayToPrint.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
    Console.WriteLine();
}

Задаем массив рандомом
void FillArray (int start, int end, int[] arr)
{
for (int i = 0; i < arr.Length ; i++)
{
    arr[i] = new Random().Next (start, end);
 }    
}
System.Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt(Console.ReadLine());
int[] user_arr = new int [size];

Задаем массив от пользователя

void FillArray (int[] arr)
{
System.Console.WriteLine("Заполните массив");
for (int i = 0; i < arr.Length ; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
 }    
}
System.Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int [] user_arr = new int [size];

// метод вывода на экран
void print2DArray(int[,] arrayToPrint)
{
    Console.Write($"[ ]\t");
    const int startIndex = 0;
    for (var i = startIndex + 0; i < startIndex + arrayToPrint.GetLength(1); i++)
    {
        Console.Write($"[{(i)}]\t");
    }
    Console.WriteLine();
    for (var i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        Console.Write($"[" + i + "]\t");

        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

1. Задайте двумерный массив. Найдите элементы, у которых оба
индекса чётные, и замените эти элементы на их квадраты.


int[,] Fill2Array (int row, int colum)  //рандом 2-массива
{
    Random rnd = new Random();
    int[,] arr = new int[row,colum];

    for (int i = 0; i < arr.GetLength(0) ; i++)
    {
        for (int j = 0; j < arr.GetLength(1) ; j++)
        {
            arr[i,j]= rnd.Next(1,11);
        } 
    }
    return arr;
}

void Print2DArray_New(int[,] arrayToPrint)  // 
{
    Console.Write($"[ ]\t");
    const int startIndex = 0;
    for (var i = startIndex + 0; i < startIndex + arrayToPrint.GetLength(1); i++)
    {
        Console.Write($"[{(i)}]\t");
    }
    Console.WriteLine();
    for (var i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        Console.Write($"[" + i + "]\t");

        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {   
            if (i % 2 == 0 && j % 2 == 0)
            {
            Console.Write(Convert.ToInt32(Math.Pow(arrayToPrint[i, j],2)) + "\t");
            }
            else 
            {
            Console.Write(arrayToPrint[i, j] + "\t");
            }
        }
        Console.WriteLine();
    }
}

void Print2DArray(int[,] arrayToPrint)
{
    Console.Write($"[ ]\t");
    const int startIndex = 0;
    for (var i = startIndex + 0; i < startIndex + arrayToPrint.GetLength(1); i++)
    {
        Console.Write($"[{(i)}]\t");
    }
    Console.WriteLine();
    for (var i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        Console.Write($"[" + i + "]\t");

        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] arr = Fill2Array(3,5);
Print2DArray(arr);
System.Console.WriteLine();
Print2DArray_New(arr);

Задача 2
Задайте двумерный массив. Найдите сумму элементов,
находящихся на главной диагонали (с индексами (0,0); (1;1) и
т.д.


Задайте двумерный массив из целых чисел. Сформируйте новый
одномерный массив, состоящий из средних арифметических
значений по строкам двумерного массива.
int SumDiagonal (int[,] arr)  // сумма диагонали
{
    int sum = 0 ;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == j)
            {sum = sum + arr[i,j];}   
        }
    }
    return sum;
}

int[,] arr = Fill2Array(3,5);
Print2DArray(arr);
System.Console.WriteLine();
int sum = SumDiagonal(arr);
System.Console.WriteLine(sum);

Задача3
Задайте двумерный массив из целых чисел. Сформируйте новый
одномерный массив, состоящий из средних арифметических
значений по строкам двумерного массива.


int[,] Fill2Array (int row, int colum)  //рандом 2-массива
{
    Random rnd = new Random();
    int[,] arr = new int[row,colum];

    for (int i = 0; i < arr.GetLength(0) ; i++)
    {
        for (int j = 0; j < arr.GetLength(1) ; j++)
        {
            arr[i,j]= rnd.Next(1,11);
        } 
    }
    return arr;
}

void Print2DArray(int[,] arrayToPrint)
{
    Console.Write($"[ ]\t");
    const int startIndex = 0;
    for (var i = startIndex + 0; i < startIndex + arrayToPrint.GetLength(1); i++)
    {
        Console.Write($"[{(i)}]\t");
    }
    Console.WriteLine();
    for (var i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        Console.Write($"[" + i + "]\t");

        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void PrintArray(int[,] arrayToPrint) //1д массив
{   
    double[] array = new double [arrayToPrint.GetLength(0)];
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {   
        double sum = 0;
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            sum = sum + arrayToPrint[i,j];
        }
        sum = sum / arrayToPrint.GetLength(1);
        array[i] = sum;
        Console.Write(array[i]);
        if (i != array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
    Console.WriteLine();
}

int[,] arr = Fill2Array(3,5);
Print2DArray(arr);
System.Console.WriteLine();
PrintArray(arr);

Задача 4
задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива. Под удалением понимается создание нового двумерного массива без строки и столбца

*/
Console.Clear();
int[,] Get2DArray(int row, int column)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

(int, int) FiendMinIndex (int[,] array)  //индексы минимального значения
{
    int minRow = 0;
    int minCol = 0;
    int min = array[0,0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
          if (array[i,j] < min)
          {
            minRow = i;
            minCol = j;
            min = array[i,j];
          }   
        }
    }
    return (minRow, minCol);
}

int[,] DeleteMinColumnRow(int[,] array, int row, int column)
{
    int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int x = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i == row)
        {
            row = -1;
            continue;
        }
        int y = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == column) continue;
            result[x, y] = array[i, j];
            y++;
        }
        x++;
    }
    return result;
}

int[,] userArray = Get2DArray(4,4);
Print2DArray(userArray);
(int minRow, int minCol) = FiendMinIndex(userArray);
System.Console.WriteLine($"{minRow}  {minCol}");
int[,] newArray = DeleteMinColumnRow(userArray,minRow,minCol);
System.Console.WriteLine();
Print2DArray(newArray);