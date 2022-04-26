Console.WriteLine("введите два числа: ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

if (a>b)
{
    int result = a;
    Console.Write("Большее число: ");
    Console.WriteLine (result);
}
else
{
    int result = b;
    Console.Write("Большее число: ");
    Console.WriteLine (result);
}

