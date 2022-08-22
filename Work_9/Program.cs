//Task 1
/*
void ShowNumbers(int m, int n)
{
    if(n != m) ShowNumbers(m, n - 1);

    Console.Write(n + " ");
}
Console.Write("Input number M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number N: ");
int n = Convert.ToInt32(Console.ReadLine());

ShowNumbers(m, n);
*/

//Task 2 
/*
int SumOfElements(int M, int N)
{
    if(M < N) return M + SumOfElements(M + 1, N);
    if(M > N) return M + SumOfElements(M - 1, N);
    return N;
}
Console.Write("Input number M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number N: ");
int n = Convert.ToInt32(Console.ReadLine());

int sum = SumOfElements(m, n);
Console.WriteLine($"Summa elements from M until N = {sum}");
*/

//Task 3

int SumOfAkkermanFunkcion(int m, int n)
{
    if(m == 0) return n + 1;
    if(n == 0) return SumOfAkkermanFunkcion(m - 1, 1);
    if(m != 0 && n != 0) return SumOfAkkermanFunkcion(m - 1, SumOfAkkermanFunkcion(m, n - 1));
    
    return 0;
}
Console.Write("Input number M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number N: ");
int n = Convert.ToInt32(Console.ReadLine());
while(m < 0 || n < 0)
{
    Console.WriteLine("Enter non-negative M and N values:");
    Console.Write("Input number M: ");
    m = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input number N: ");
    n = Convert.ToInt32(Console.ReadLine());
}
int sum = SumOfAkkermanFunkcion(m, n);
Console.Write($"A({m},{n}) = {sum}");