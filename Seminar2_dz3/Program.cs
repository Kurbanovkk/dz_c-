System.Console.WriteLine("Введите число от 1 до 7 включительно:  ");
var denNedeli = int.Parse(Console.ReadLine());
string day = null;
if (denNedeli < 8)
{
    if (denNedeli == 1) day = "Monday";
    if (denNedeli == 2) day = "Tuesday";
    if (denNedeli == 3) day = "Wednesday";
    if (denNedeli == 4) day = "Thursday";
    if (denNedeli == 5) day = "Friday";
    if (denNedeli == 6) day = "Saturday";
    if (denNedeli == 7) day = "Sunday";
}
else
{
    System.Console.WriteLine("Введите число в диапозоне от 1 до 7 включительно");
}


if (day == "Saturday")
{
    System.Console.Write($"Ура это выходной день ");

}

if (day == "Sunday")
{
    System.Console.Write($" Ура это выходной день " + day);
}
else
{
    System.Console.Write(day);
}