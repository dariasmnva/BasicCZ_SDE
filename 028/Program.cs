// Определить количество цифр в числе. Сделать подпрограмму.

Console.WriteLine(CountDigits(0));




int CountDigits(int N)
{
    if(N==0) return 1;
    int k=0;
    while(N!=0)
    {
        k++;
        N/=10;
    }
    return k;
}

