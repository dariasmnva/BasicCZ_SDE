// С клавиатуры вводится строка разделенная точкой. 
//Подсчитать количество символов до точки.


using System;
string str=Console.ReadLine();
int countBefore = str.IndexOf('.');
Console.WriteLine($"Количество символов до точки = {countBefore}");