Console.Write("введите число a: ");
string userString = Console.ReadLine();
int a = Convert.ToInt32(userString);
Console.Write("введите число b: ");
string userString = Console.ReadLine();
int b = Convert.ToInt32(userString);

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

