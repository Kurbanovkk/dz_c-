/*  Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29
*/

System.Console.Write("Эта программа для вычисления функции Аккермана, даны два неотриц числа: m и n, введите значание m: ");
uint value1 = uint.Parse(Console.ReadLine());
System.Console.Write("Введите значение n: ");
uint value2 = uint.Parse(Console.ReadLine());

uint Conclusion(uint m, uint n)
{
    if (m == 0)
        return n + 1;

    else if ((m > 0) && (n == 0))
        return Conclusion(m - 1, 1);

    else
        return Conclusion(m - 1, Conclusion(m, n - 1));
}
System.Console.WriteLine(Conclusion(value1, value2));