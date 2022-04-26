Console.WriteLine("введите три числа: ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

int max = a;

if (b>max) max = b;

if (c>max) max = c;

int result = max;
Console.Write("Большее число: ");
Console.WriteLine (result);

