// Написать программу вывода чисел от  1 до N 
//без использования циклов и оператора goto.

void Loop(int i,int N)
{
    System.Console.WriteLine(i);
    if (i<N) Loop(i+1,N);//рекурсия
}

 int F(int n)
 {
    if (n>0) return F(n-1)*n;
    else 
        return 1;
 }

 int Sum(int i,int N)
 {
    if (i<=N) return Sum(i+1,N)+i;
    else
     return 0;
 }
 
//System.Console.WriteLine(Sum(0,4));


/*
System.Console.WriteLine(F(5));
int N=5;
int f=1;
for(int i=1;i<=N;i++)
    f=f*i;
System.Console.WriteLine(f);
*/
//Loop(1,10);









/* !!!!!!!!!DANGER!!!!!!!!!!!
int i=0;
label:
    i++;
    System.Console.Write(1);
if (i<10) goto label;//оператор безусловного перехода.
//Ctrl+C
*/
