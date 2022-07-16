// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
string palindrom = Console.ReadLine();

/*if (palindrom[0] == palindrom[4] && palindrom[1] == palindrom[3])
    Console.WriteLine("Ура это палиндром");
else
    System.Console.WriteLine("Это не палиндром");*/


void Pali(string str)
{
    if (str[0] == str[4] && str[1] == str[3])
        Console.WriteLine("Ура это палиндром!!!");
    else
        Console.WriteLine("Это не палиндром");

}

Pali(palindrom);