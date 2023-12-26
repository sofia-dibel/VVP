// 13. Функция расчёта факториала итерационным и рекурсивным методами.


// итерационный

static long FactIter(long n)
{
    var y = (long)1;
    for(var i = 2; i <= n; i++)
    {
        y *= i;
    }
    return y;
}

Console.WriteLine(FactIter(5));


// рекурсивный

static long FactRecursion(long n)
{
    if (n == 0)
    {
        return 1;
    }
    return n * FactRecursion(n - 1);
}

Console.WriteLine(FactRecursion(5));



