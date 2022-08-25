//  Задайте значения M и N. 
//Напишите программу, которая выведет все натуральные числа в промежутке от M до N.


Console.Write("Введите M: ");
int M = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите N: ");
int N = Convert.ToInt16(Console.ReadLine());
Console.WriteLine($"N={N}, M={M}");
Loop(M,N);
void Loop(int i,int N)
{
    System.Console.Write($" {i}");
    if (i<N) Loop(i+1,N);
}