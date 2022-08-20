Console.Write("Введите  M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите  N: ");
int N = Convert.ToInt32(Console.ReadLine());

if (M < 0 || N < 0)
{
    Console.Write("Введите числа >=0 ");
}
else
{
    int result = AkermanFunction(M, N);
    Console.Write(result);
}

int AkermanFunction(int M, int N)
{
    if (M == 0) return N + 1;

    else if (N == 0) return AkermanFunction(M - 1, 1);

    return AkermanFunction(M - 1, AkermanFunction(M, N - 1));
}

