/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, заданы 2 массива:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49 */

System.Console.Write("Задайте количество строк: ");
int line = int.Parse(Console.ReadLine());
System.Console.Write("Задайте количество столбцов: ");
int column = int.Parse(Console.ReadLine());
int[,] array = new int[line, column];

void PrintArray(int[,] array)
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
PrintArray(array);

int[,] myArray = new int[line, column];
System.Console.WriteLine();
PrintArray(myArray);

int[,] newArray = new int[line, column];

for (int i = 0; i < line; i++)
{
    for (int j = 0; j < column; j++)
    {
        if (true)
        {
            newArray[i, j] = array[i, j] * myArray[i, j];
        }
    }
}

void PrintArra(int[,] newArray)
{
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            System.Console.Write(newArray[i, j] + ", ");
        }
        System.Console.WriteLine();
    }
}
System.Console.WriteLine();
PrintArra(newArray);