// Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

int[] array = new int[10];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 10);
}

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
Console.WriteLine();

void Recurse(int i)
{
    Console.Write(array[i] + " ");
    if (i == 0)
    {
        return;
    }

    Recurse(i - 1);
}

Recurse(array.Length - 1);