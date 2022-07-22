// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]


int N=123;
int [] a= new int[N];
Random random = new Random();
for(int i=0;i<a.Length; i++)
    a[i]=random.Next(10,999);

int k=0;

for(int i=0; i<a.Length;i++)   
    if(a[i]>11 && a[i]<100)
    {
        k++;
    }


 for(int i=0; i<a.Length;i++)   
     Console.Write($"{a[i],4}");   
Console.WriteLine();  
Console.WriteLine($"Количество элементов из отрезка [10,99]={k}");   
 
