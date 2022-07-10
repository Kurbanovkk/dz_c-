
/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

System.Console.WriteLine("Здравствуйте, данная программа позволяет найти максимальное и минимальное число, из двух введенных");
System.Console.WriteLine("Введите первое число: ");
int value1 = int.Parse(Console.ReadLine());
System.Console.WriteLine("теперь введите второе число: ");
int value2 = int.Parse(Console.ReadLine());

if (value1 > value2)
{
    System.Console.Write($"Максимальное число: " + value1);
    System.Console.Write($", а минимальное: " + value2);
}
else
{
    System.Console.Write($"Максимальное число " + value2);
    System.Console.Write($", а минимальное: " + value1);
}
