
Console.Write("Укажите число 1 > ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Укажите число 2 > ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Укажите число 3 > ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;
if (b > max) max = b;
if (c > max) max = c;
System.Console.WriteLine("Максимальное число > " + max);