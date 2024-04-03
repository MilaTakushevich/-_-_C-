/*Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

char[,] charArray = {
        {'C', ' ', 'п', 'е', 'р', 'в', 'ы', 'м'},
        {' ', 'а', 'п', 'р', 'е', 'л', 'я', '!'}
        };

string resultString = GetStringFromArray(charArray);

Console.WriteLine("Строка, созданная из символов массива:");
Console.WriteLine(resultString);

string GetStringFromArray(char[,] array)
{
    string result = ""; // Создаем пустую строку

    for (int i = 0; i < array.GetLength(0); i++) // Проходим по всем элементам массива
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result += array[i, j];
        }
    }

    return result;
}

