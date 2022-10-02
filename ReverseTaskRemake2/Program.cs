Console.WriteLine("Введите число, дабы познать палиндром ли: ");
int num=Convert.ToInt32(Console.ReadLine());
int counter=1;
int Quantity(int number)

{
    while (number/10>0)
    {
        number=number/10;
        counter++;
    }
    return counter;
}

int quantity=Quantity(num);
int[] arr = new int[quantity];
int[] arr2= new int[quantity];
int count=1;
int n=quantity;
for(int i=0;i<quantity;i++)

{
    arr[i]=(num/count)%10;
    count*=10;
}
for(int i=0;i<quantity;i++)
{
    arr2[n-1]=arr[i];
    n--;
}

if(arr.SequenceEqual(arr2)) Console.WriteLine("Палиндром детектед");
else Console.WriteLine("Не палиндром");