/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет 
количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2  */
System.Console.Write("Введите размер массива: ");
int value = int.Parse(Console.ReadLine());
int[] array = new int[value];
int count = 0;

int Foo(int[] array, int count)
{
    for (int i = 0; i < array.Length; i++)
    {
        Random random = new Random();
        array[i] = random.Next(99, 1000);
        System.Console.Write(array[i] + "\t");
        if (array[i] % 2 == 0)
        {
            count++;

        }

    }
    return count;
}

int res = Foo(array, count);
System.Console.WriteLine("\n" + res);