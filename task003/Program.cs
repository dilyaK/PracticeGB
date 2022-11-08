// Напишите программу, которая на вход принимает число и выдает, 
// является ли число четным (делится ли оно без остатка).

Console.WriteLine("Enter num: ");

i = int.Parsel(Console.Read());

if (i % 2==0)
{
    Console.WriteLine("The number is EVEN");
}
else 
{
    Console.WriteLine("The number is ODD");
}
