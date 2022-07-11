int firstArgument = Input("M: ");
int secondArgument = Input("N: ");
int summ=0;

if(firstArgument<secondArgument) 
    SummNaturalNumber(firstArgument,secondArgument,summ);
else 
    SummNaturalNumber(secondArgument,firstArgument,summ);


void SummNaturalNumber(int m,int n,int summ)
{
    if(m == n)
    {
        summ+=m;
        Console.Write($"Сумма={summ}");
    }
    else
    {
        summ+=m+n;
        SummNaturalNumber(++m,--n,summ);
    }
    
}

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}