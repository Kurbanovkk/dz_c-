/*  Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на 
нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0  */

System.Console.Write("Введите размер массива: ");
int value = int.Parse(Console.ReadLine());
int[] array = new int[value];
int count = 0;

int Bar(int[] array, int count)
{
    for (int i = 0; i < array.Length; i++)
    {
        Random random = new Random();
        array[i] = random.Next(1, 100);
        System.Console.Write(array[i] + "\t");
        if (i % 2 > 0)
            count += array[i];

    }
    return count;
}
int res = Bar(array, count);
System.Console.WriteLine("\n" + res);
