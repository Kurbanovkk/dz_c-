// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
string palindrom = Console.ReadLine();

if (palindrom.Length > 5 || palindrom.Length < 0)
    System.Console.WriteLine("Ошибка!!! ВВедите пожалуйста пятизначное число");

else
    Pali(palindrom);

void Pali(string str)
{
    if (str[0] == str[4] && str[1] == str[3])
        Console.WriteLine("Ура это палиндром!!!");
    else
        Console.WriteLine("Это не палиндром");

}


