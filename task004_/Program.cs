// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все четные числа от 1 до N.

int i = 2;

Console.WriteLine("Enter a number: ");

int N = Convert.ToInt32(Console.ReadLine()); 


while(i <= N)
{
 if(i % 2 ==0)
 
 {
  Console.WriteLine(i+" ");
}
i++;
} 


