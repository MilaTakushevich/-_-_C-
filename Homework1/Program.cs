Console.WriteLine("Введите число: ");
Console.WriteLine("Введите второе число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine("Первое больше второго");
}
if (number1 > number2)
{
    Console.WriteLine("Второе больше первого");
}
else
{
    Console.WriteLine("числа равны");
}