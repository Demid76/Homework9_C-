Console.Write("Введите  M:");
int M = int.Parse(Console.ReadLine());

Console.Write("Введите  N:");
int N = int.Parse(Console.ReadLine());

void GapNumberSum (int M, int N, int sum)
{
    if (M > N) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (M++);
    GapNumberSum(M, N, sum);
}

GapNumberSum(M, N, 0);
