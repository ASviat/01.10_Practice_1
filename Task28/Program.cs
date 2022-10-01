Console.WriteLine("Введите число: ");
int num=Convert.ToInt32(Console.ReadLine());

int Sum(int n1)
{
    int counter=1;
    int fin=1;
    while(counter<=n1)
    {
        fin=fin*counter;
        counter++;
    }
    return fin;
}
int sum=Sum(Math.Abs(num));
Console.WriteLine(sum);