// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

System.Console.WriteLine("Здравствуйте, данная программа позволяет найти максимальное из трех введенных");
System.Console.WriteLine("Введите первое число: ");
int value1 = int.Parse(Console.ReadLine());
System.Console.WriteLine("теперь введите второе число: ");
int value2 = int.Parse(Console.ReadLine());
System.Console.WriteLine("а теперь введите третье число: ");
int value3 = int.Parse(Console.ReadLine());

int max = value1;

if (value1 > max) max = value1;
if (value2 > max) max = value2;
if (value3 > max) max = value3;

System.Console.WriteLine($"Максимальное значение: " + max);