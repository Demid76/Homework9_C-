Console.Write("Введите любое число N больше 1:");
int N = int.Parse(Console.ReadLine());

void NumberCounter (int N)
{
    if (N < 0) Console.Write($"{N} неверный ввод числа ");
    if (N == 0) return;
    Console.Write("{0,4}", N);
    NumberCounter (N - 1);
}

NumberCounter(N);
