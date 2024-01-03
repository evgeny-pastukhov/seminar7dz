// Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

int m, n;

Console.WriteLine("Введите M");
m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите N");
n = int.Parse(Console.ReadLine());


int firstElement = m;

PrintNumbers(n, firstElement);

void PrintNumbers(int endElement, int startElement)
{
    Console.WriteLine(startElement);
    if (endElement == startElement)
    {
        return;
    }
    PrintNumbers(endElement, startElement + 1);
}

