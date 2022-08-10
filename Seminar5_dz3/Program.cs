/*  Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76  */
System.Console.Write("Введите размер массива: ");
int value = int.Parse(Console.ReadLine());
double[] array = new double[value];
double res = 0;

for (int i = 0; i < array.Length; i++)
{
    Random random = new Random();
    array[i] = random.Next(1, 100);
    System.Console.Write(array[i] + "\t");
}

double Max(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];

    }
    return max;
}

double Min(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {

        if (array[i] < min) min = array[i];
    }
    return min;
}

res = Max(array) - Min(array);
System.Console.WriteLine("\n" + res);