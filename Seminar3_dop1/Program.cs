System.Console.Write("Введите значение: ");
int value = int.Parse(Console.ReadLine());
int square = value * value;
int begin = 1;

double[,] array = new double[value, value];

for (int i = 0; i < value; i++)
{
    array[0, i] = begin;
    begin++;
}
for (int x = 1; x < value; x++)
{
    array[x, value - 1] = begin;
    begin++;
}
for (int y = value - 2; y >= 0; y--)
{
    array[value - 1, y] = begin;
    begin++;
}
for (int z = value - 2; z > 0; z--)
{
    array[z, 0] = begin;
    begin++;
}

int count1 = 1;
int count2 = 1;

while (begin < square)
{
    while (array[count1, count2 + 1] == 0)
    {
        array[count1, count2] = begin;
        begin++;
        count2++;
    }

    while (array[count1 + 1, count2] == 0)
    {
        array[count1, count2] = begin;
        begin++;
        count1++;
    }

    while (array[count1, count2 - 1] == 0)
    {
        array[count1, count2] = begin;
        begin++;
        count2--;
    }

    while (array[count1 - 1, count2] == 0)
    {
        array[count1, count2] = begin;
        begin++;
        count1--;
    }
}
for (int x = 0; x < value; x++)
{
    for (int y = 0; y < value; y++)
    {
        if (array[x, y] == 0)
        {
            array[x, y] = begin;
        }
    }
}

for (int k = 0; k < value; k++)
{
    for (int l = 0; l < value; l++)
    {
        if (array[k, l] < value)
            System.Console.Write(array[k, l] + "  ");
        else
            System.Console.Write(array[k, l] + " ");
    }
    System.Console.WriteLine(" ");
}

