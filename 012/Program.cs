//Дано число из  диапозона  [10, 99]. Показать наибольшую цифру числа
int a=89;
int m;
m=a%10;
a=a/10;
while(a>0)
{
    if(a%10>m)
    m=a%10;
    a=a/10;
}
Console.WriteLine(m);