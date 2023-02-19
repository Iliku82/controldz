//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

// Console.Write("Введите число: ");
// int N = int.Parse(Console.ReadLine()!);

// for(int i = N; i > 0; i--)
//        Console.Write(i + " * ");


//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.WriteLine("Введите число: M");
int M = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число: N");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine(PrintNumbers(N,M));

string PrintNumbers(int start, int end)
{
    if(start == end) return start.ToString();
    return(start + " " + PrintNumbers(start + 1, end));
}