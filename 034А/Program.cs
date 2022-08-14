// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.


int [] a;
Init(out a);
int k;
Solve(a, out k);
Print(a);
Console.WriteLine();     
Console.WriteLine($"Колличество четных чисел = {k}");     


void Init(out int [] a,int Lenght=4, int min=100,int max=999)
{
    a=new int[Lenght];
    Random random = new Random();
    for(int i=0;i<a.Length; i++)
    a[i]=random.Next(min,max+1);
}    


void Solve(int[] a, out int k)
{
    k=0;
    for(int i=0; i<a.Length;i++)
    {
        if(a[i]%2==0)
    {
        k++;
    }
    }
}



void Print(int[] a)
{
    for (int i=0; i<a.Length; i++)
    Console.Write($"{a[i],4}");
}
