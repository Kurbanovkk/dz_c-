
/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
на выходе показывает вторую цифру этого числа.*/

System.Console.WriteLine("Введите любое число: ");
string value1 = Console.ReadLine();
int index = value1.Length;
if (index >= 2)
{
    var value2 = value1.ToString()[1];
    System.Console.WriteLine(value2);
}
else
{
    System.Console.WriteLine("Второго числа нет");
}

