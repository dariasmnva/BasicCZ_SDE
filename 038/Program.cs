// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

 
 
int [] a;
Init(out a);
int k;
Solve(a,out k);
Print(a);
Console.WriteLine();  
Console.WriteLine($"Количество элементов из отрезка [10,99]={k}"); 

void Init(out int [] a,int Lenght=50, int min=10,int max=999)
{
    a=new int[Lenght];
    Random random = new Random();
    for(int i=0;i<a.Length; i++)
    a[i]=random.Next(min,max+1);
}    


void Solve(int [] a, out int k)
{
    k=0;
    for(int i=0; i<a.Length;i++)
    if(a[i]>11 && a[i]<100)
    {
        k++;
    }
}

void Print(int[] a)
{
    for (int i=0; i<a.Length; i++)
    Console.Write($"{a[i],4}");
}