/*  Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

System.Console.Write("Эта программа для нахождения суммы всех натуральных чисел от m до n, введите значание m: ");
int value1 = int.Parse(Console.ReadLine());
System.Console.Write("Введите значение n: ");
int value2 = int.Parse(Console.ReadLine());

int Conclusion(int value1, int value2)
{
    if (value1 > value2) return 0;

    return Conclusion(value1, value2 - 1) + value2;
}
System.Console.WriteLine(Conclusion(value1, value2));