//  Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.



int[] a;
Init(out a);
int sum;
Solve(a,out sum);
Print (a);
 Console.WriteLine();    
Console.WriteLine($"Сумма элементов,стоящих на нечётных позициях:{sum}");

void Init(out int [] a,int Lenght=5, int min=0,int max=10)
{
    a=new int[Lenght];
    Random random = new Random();
    for(int i=0;i<a.Length; i++)
    a[i]=random.Next(min,max+1);
}    


void Solve(int[] a, out int sum)
{
    sum=0;
    for(int i=0; i<a.Length;i=i+2)
    {
        sum+=a[i];
    }
}



void Print(int[] a)
{
    for (int i=0; i<a.Length; i++)
    Console.Write($"{a[i],4}");
}