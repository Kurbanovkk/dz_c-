/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

System.Console.Write("Задайте количество строк: ");
int line = int.Parse(Console.ReadLine());
System.Console.Write("Задайте количество столбцов: ");
int column = int.Parse(Console.ReadLine());
int[,] array = new int[line, column];

void PrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
            System.Console.Write(array[i, j] + ", ");
        }
        System.Console.WriteLine();
    }
}
PrintArray();

double res = 0;
string str = string.Empty;
for (int j = 0; j < column; j++)

{
    for (int i = 0; i < line; i++)
    {
        res += array[i, j];
    }
    str = str + " " + res / line;
    res = 0;
}
System.Console.Write(" Среднее арифметическое столбца: " + str);