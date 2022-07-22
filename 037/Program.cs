// Задать массив, заполнить случайными положительными трёхзначными числами. 
//Показать количество нечетных\четных чисел

int N=9;
int [] a= new int[N];
Random random = new Random();
for(int i=0;i<a.Length; i++)
    a[i]=random.Next(100,999);
int k=0;
int m=0;
for(int i=0; i<a.Length;i++)   
    if(a[i]%2==0)
    {
        k++;
    }

for(int i=0; i<a.Length;i++)   
    if(a[i]%2!=0)
    {
        m++;
    }


 for(int i=0; i<a.Length;i++)   
     Console.Write($"{a[i],4}");   
Console.WriteLine();     
Console.WriteLine($"Колличество четных чисел = {k}");     
 Console.WriteLine($"Колличество нечетных чисел = {m}");  
