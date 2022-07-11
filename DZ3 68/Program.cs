int firstArgument = Input("M: ");
int secondArgument = Input("N: ");

if ((secondArgument < 0) && (firstArgument < 0))
    Console.Write("Одно или оба числа отрицательные, введите положительные числа");
else 
    Console.Write(FuncAck(firstArgument, secondArgument));

int FuncAck(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if ((m > 0) && (n == 0))
        return FuncAck(m - 1, 1);
    else if ((m > 0) && (n > 0))
        return FuncAck(m - 1, FuncAck(m, n - 1));
    else
        return n + 1;
}

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}