//  Напишите программу вычисления 
//  функции Аккермана с помощью рекурсии. 
//  Даны два неотрицательных числа m и n.

static int A(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return A(n - 1, 1);
    else
        return A(n - 1, A(n, m - 1));
}

int res;
res = A(1, 2); // res = 4
Console.WriteLine(res);
res = A(0, 1); // res = 2
Console.WriteLine(res);
res = A(0, 0); // res = 1
Console.WriteLine(res);
res = A(2, 2); // res = 7
Console.WriteLine(res);