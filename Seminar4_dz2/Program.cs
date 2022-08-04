/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

System.Console.Write(" Введите число: ");
int value = int.Parse(Console.ReadLine());

int Foo(int value)
{
    int result = 0;

    while (value > 0)
    {
        result += value % 10;
        value = value / 10;
    }
    return result;
}

int result2 = Foo(value);
System.Console.WriteLine(result2);