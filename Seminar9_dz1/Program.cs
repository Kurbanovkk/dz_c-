/*  Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""

*/

System.Console.Write("Эта программа для нахождения всех натуральных чисел от m до n, введите значание m: ");
int value1 = int.Parse(Console.ReadLine());
System.Console.Write("Введите значение n: ");
int value2 = int.Parse(Console.ReadLine());

string Conclusion(int value1, int value2)
{
    if (value1 > value2) return string.Empty;

    return Conclusion(value1, value2 - 1) + $"{value2}, ";
}
System.Console.WriteLine(Conclusion(value1, value2));