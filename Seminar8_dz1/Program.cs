/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного
 массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
1 2 4 7
2 3 5 9
2 4 4 8 */

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

int temp = 0;


for (int i = 0; i < line; i++)
{
    for (int a = 0; a < column; a++)
    {

        for (int j = 0; j < column - 1; j++)
        {

            if (array[i, j] > array[i, j + 1])
            {
                temp = array[i, j];
                array[i, j] = array[i, j + 1];
                array[i, j + 1] = temp;
            }
            //System.Console.WriteLine(maxValue);
        }
    }

}

System.Console.WriteLine();

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        System.Console.Write(array[i, j] + ", ");
    }
    System.Console.WriteLine();
}