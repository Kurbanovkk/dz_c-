
/*  Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой 
элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

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

int res = 0;
string str = string.Empty;
for (int i = 0; i < line; i++)
{
    for (int j = 0; j < column; j++)
    {
        res += array[i, j];
    }
    str = str + res;
    if (i < line - 1)
    {
        str = str + ", ";
    }
    res = 0;
}
string[] nam = str.Split(new char[] { ',' });
int[] myArray = new int[nam.Length];
for (int i = 0; i < line; i++)
{
    myArray[i] = Convert.ToInt32(nam[i]);
}

int minLine = 0;
for (int i = 0; i < myArray.Length - 1; i++)
{
    if (myArray[i] > myArray[i + 1])
    {
        minLine = i;
    }
}

System.Console.WriteLine("Строка с наименьшей суммой элементов: " + minLine);