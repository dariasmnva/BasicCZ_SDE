// С клавиатуры вводится число N. 
//Затем вводятся N чисел. 
//Определить сколько чисел больше 0 введено с клавиатуры.


Console.ReadLine();
string s=Console.ReadLine();
string[] ss=s.Split(' ',StringSplitOptions.RemoveEmptyEntries);
int[] a=Array.ConvertAll<string,int>(ss,int.Parse);
int k;
Solve(a, out k);
Print(a);
Console.WriteLine();
Console.WriteLine($"Количество чисел больше 0:{k}");


void Solve(int[] a,out int k)
{
    k=0;
    for(int i=0;i<a.Length;i++)
    if (a[i]>0)
    {
        k++;
    }
    
}
void Init(out int[] a,int Length=10,int min=0,int max=10)
{
    a=new int[Length];
    Random random=new Random();
    for(int i=0;i<a.Length;i++)
            a[i]=random.Next(min,max+1);
}


void Print(int[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i],4}");
}