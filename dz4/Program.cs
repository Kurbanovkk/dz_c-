/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.*/

System.Console.WriteLine("Эта программа позволяет находить четные числа от 1 до введенного, введем N: ");
int value = int.Parse(Console.ReadLine());
int count = 1;

while (value >= count)
{
    if (count % 2 == 0)
    {
        System.Console.WriteLine($"Четное число: " + count);
    }

    else
    {
        System.Console.WriteLine($"Нечетное число: " + count);
    }
    count++;
}

// сделал еще и нечетные, но не смог упорядочить
