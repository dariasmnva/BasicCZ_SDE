// Задать массив, заполнить случайными положительными трёхзначными числами. 
//Показать количество нечетных\четных чисел

int [] a;
Init(out a);
int k,m;
Solve(a, out k, out m);
Print(a);
Console.WriteLine();     
Console.WriteLine($"Колличество четных чисел = {k}");     
Console.WriteLine($"Колличество нечетных чисел = {m}");

void Init(out int [] a,int Lenght=10, int min=100,int max=999)
{
    a=new int[Lenght];
    Random random = new Random();
    for(int i=0;i<a.Length; i++)
    a[i]=random.Next(min,max+1);
}    


void Solve(int[] a, out int k, out int m)
{
    k =0;
    m =0;
    for(int i=0; i<a.Length;i++)
    {
        if(a[i]%2==0)
    {
        k++;
    }
        if(a[i]%2!=0)
    {
        m++;
    }   
    }
}



void Print(int[] a)
{
    for (int i=0; i<a.Length; i++)
    Console.Write($"{a[i],4}");
}