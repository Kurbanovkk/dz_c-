/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9  */

System.Console.Write("Задайте количество строк: ");
int line = int.Parse(Console.ReadLine());
System.Console.Write("Задайте количество столбцов: ");
int column = int.Parse(Console.ReadLine());
double[,] array = new double[line, column];


Random random = new Random();
for (int i = 0; i < array.GetLength(0); i++)
{
    int digits = 3;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = random.NextDouble() * 100;
        double value = Math.Round(array[i, j], digits);
        System.Console.Write(value + ", ");
    }
    System.Console.WriteLine();
}

