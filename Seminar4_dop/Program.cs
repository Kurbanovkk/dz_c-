/*Задача 29: (необязательная) Напишите программу, которая создает массив из введенных через запятую цифр и выводит этот
 массив на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

System.Console.Write("Введите числа через запятую: ");
string str = Console.ReadLine();
string[] nam = str.Split(new char[] { ',' });
int[] array = new int[nam.Length];

for (int i = 0; i < nam.Length; i++)
{
    int foo = Convert.ToInt32(nam[i]);
    array[i] = foo;
}

for (int i = 0; i < array.Length; i++)
{
    if (i == array.Length - 1)
        System.Console.WriteLine(array[i]);
    else
        Console.Write(array[i] + ", ");
}



/*
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + ',');
}*/