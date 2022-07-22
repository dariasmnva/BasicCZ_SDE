// Написать программу замены элементов массива на противоположные



int N=8;
int [] a= new int[N];
Random random = new Random();
for(int i=0;i<a.Length; i++)
    a[i]=random.Next(0,11);


int [] b=new int[N];
for(int i=0; i<a.Length;i++)
    if (a[i]>0) b[i]=-a[i];



 for(int i=0; i<a.Length;i++)   
     Console.Write($"{a[i],4}");   
Console.WriteLine();     
 for(int i=0; i<b.Length;i++)   
     Console.Write($"{b[i],4}"); 

