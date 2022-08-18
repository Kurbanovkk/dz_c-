/*  Задача 50. Напишите программу, которая на вход принимает позиции элемента либо значение элемента в двумерном массиве,
 и возвращает значение либо индекс этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
4 -> такой элемент есть и его индекс 0, 1 (идеально было б найти все вхождения этого элемента)
2, 3 -> такой элемент есть и равен 4
5, 5 -> такой элемент отсутствует */


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
System.Console.Write("Введите значение элемента, либо его индекс: ");
double value = double.Parse(Console.ReadLine());

try
{
    if ((value * 2) % 1 == 0)
    {
        value = Convert.ToInt32(value);
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (value == array[i, j]) System.Console.Write($" Такой элемент есть и его индекс: {i},{j};");
            }
        }
    }
    else if ((value * 2) % 1 != 0)
    {
        int a = Convert.ToInt32(value);
        int b = Convert.ToInt32((value * 10) % 10);

        if (a < line && value < column)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i == a && j == b) System.Console.WriteLine("такой элемент есть и он равен: " + array[i, j]);
                }
            }
        }
        else System.Console.WriteLine("В данном массиве нет такого индекса");
    }
}

catch (System.Exception)
{
    System.Console.WriteLine("такого элемента или индекма нет!!!");
}
