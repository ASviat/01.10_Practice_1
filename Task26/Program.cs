Console.WriteLine("Введите число: ");
int num=Convert.ToInt32(Console.ReadLine());

int NumQuant(int n1)
{
    int count=1;
    while(n1/10!=0)
    {
        n1=n1/10;
        count++;
    }
    return count;
}
int numQuant=NumQuant(num);
Console.WriteLine(numQuant);