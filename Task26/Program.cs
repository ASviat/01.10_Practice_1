Console.WriteLine("Введите число: ");
int num=Convert.ToInt32(Console.ReadLine());

int NumQuant(int n1)
{
    int count=default;
    while(n1>0)
    {
        n1=n1/10;
        count++;
    }
    return count;
}
int numQuant=NumQuant(num);
Console.WriteLine(numQuant);