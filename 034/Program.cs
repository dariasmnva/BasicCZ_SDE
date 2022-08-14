// Задать массив из 12 элементов, заполненных числами из [-9, 9]. 
// Найти сумму положительных/отрицательных элементов массива


int N=3;
int[] a;
Init(out a,12,-9,9);
int sumNegativ,sumPositive;
Solve(a,out sumPositive,out sumNegativ);
Print (a);
 Console.WriteLine($"\nСумма положительных:{sumPositive}");    
Console.WriteLine($"Сумма отрицательных:{sumNegativ}");

void Init(out int [] a,int Lenght=10, int min=0,int max=10)
{
    a=new int[Lenght];
    Random random = new Random();
    for(int i=0;i<a.Length; i++)
    a[i]=random.Next(min,max+1);
}    


void Solve(int[] a, out int sumPositive, out int sumNegativ)
{
    sumPositive =0;
    sumNegativ =0;
    for(int i=0; i<a.Length;i++)
    {
        if (a[i]>0)
        {
            sumPositive=sumPositive+a[i];
        }
        if (a[i]<0)
        {
            sumNegativ+=a[i];
        }
    }
}



void Print(int[] a)
{
    for (int i=0; i<a.Length; i++)
    Console.Write($"{a[i],4}");
}