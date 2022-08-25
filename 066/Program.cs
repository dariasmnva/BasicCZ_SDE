// Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.


Console.Write("Введите M: ");
int M = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите N: ");
int N = Convert.ToInt16(Console.ReadLine());
Console.WriteLine($"N={N}, M={M}");
int Sum(int i,int N)
 {
    if (i<=N) return Sum(i+1,N)+i;
    else
     return 0;
 }
 
Console.WriteLine(Sum(M,N));

