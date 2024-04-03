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

Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные.

string inputString = "HowareYOU";
string resultString = ConvertToLowerCase(inputString);

Console.WriteLine("Исходная строка: " + inputString);
Console.WriteLine("Строка с замененными заглавными буквами на строчные: " + resultString);
    
string ConvertToLowerCase(string input)
{
    string result = "";

    foreach (char c in input)
    {
        if (char.IsUpper(c))
        {
            result += char.ToLower(c);
        }
        else
        {
            result += c;
        }
    }

    return result;
}

Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.
*/
string inputString = "rada";
        bool isPalindrome = IsPalindrome(inputString);
        PrintResult(inputString, isPalindrome);
    

bool IsPalindrome(string input)
    {
        string reversedString = ""; 

        for (int i = input.Length - 1; i >= 0; i--) 
        {
            reversedString += input[i];
        }
        return input == reversedString;  
    }   

void PrintResult(string input, bool isPalindrome)
    {
        if (isPalindrome)
        {
            Console.WriteLine("Строка \"" + input + "\" является палиндромом.");
        }
        else
        {
            Console.WriteLine("Строка \"" + input + "\" не является палиндромом.");
        }
    }
/*
Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. Сформировать строку, в которой слова расположены в обратном порядке. В полученной строке слова должны быть также разделены пробелами.
*/