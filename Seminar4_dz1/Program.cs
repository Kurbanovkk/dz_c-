
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

System.Console.Write("Введите число,которое нужно возвести в степень: ");
int value = int.Parse(Console.ReadLine());
System.Console.Write("Введите степень, в которое нужно возвести число: ");
int degree = int.Parse(Console.ReadLine());
int composition = 1;

int Deg(int value, int degree, int composition)
{
    if (degree == 0)
        return 1;
    for (int i = 1; i <= degree; i++)
    {
        composition = composition * value;

    }
    return composition;
}

int result = Deg(value, degree, composition);
System.Console.WriteLine(result);