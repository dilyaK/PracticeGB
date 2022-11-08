// Напишите программу которая принимает на вход три числа и выдает максимальное из этих чисел.

Console.WriteLine ("Enter num a: ");
int a = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine ("Enter num b: ");
int b = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine ("Enter num c: ");
int c = Convert.ToInt32(Console.ReadLine()); 

int max = a ;
 
if ( b > max )
{
        max =  b;
}
if  ( c > max)
{
    max = c;

}
Console.WriteLine(max);

        

