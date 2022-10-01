Console.WriteLine("Введите число: ");
int num=Convert.ToInt32(Console.ReadLine());

int Sum(int n1)
{
int sum=0;
int first=1;
while (first<=n1)
    {
    sum=sum+first;
    first++;
    }
Console.WriteLine($"Сумма чисел от 1 до {num} = {sum}");
return sum;
}

int sum=Sum(num);