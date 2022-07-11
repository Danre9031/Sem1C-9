int number = Input("Введите число: ");
int temp=1;

Console.WriteLine(NaturalNumber(number,temp));

int NaturalNumber(int numberOne,int numberTwo)
{
    if(numberOne == numberTwo)
        return numberTwo;
    else
        Console.Write($"{NaturalNumber(numberOne,numberTwo+1)}, ");
    return numberTwo;
}

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}