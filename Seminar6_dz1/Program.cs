/*  Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

System.Console.WriteLine("Введите числа через запятую");
string str = Console.ReadLine();
string[] nam = str.Split(new char[] { ',' });
int[] array = new int[nam.Length];

for (int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToInt32(nam[i]);
}

int Foo(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            count++;
    }
    return count;
}

int res = Foo(array);
System.Console.WriteLine(res);