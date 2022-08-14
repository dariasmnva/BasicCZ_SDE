// Написать программу замены элементов массива на противоположные


int [] a;
Init(out a);
PrintPos(a);
Console.WriteLine();
PrintNeg(a);


void Init(out int [] a,int Lenght=8, int min=0,int max=10)
{
    a=new int[Lenght];
    Random random = new Random();
    for(int i=0;i<a.Length; i++)
    a[i]=random.Next(min,max+1);
}    



void PrintPos(int[] a)
{
    for (int i=0; i<a.Length; i++)
    Console.Write($"{a[i],4}");
    
}
void PrintNeg(int[] a)
{
    for (int i=0; i<a.Length; i++)
    Console.Write($"{-a[i],4}");
    
}

