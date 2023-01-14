// Программа, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);

int max = a;
int min = b;

if(max > min)
{ 
    max = a; min = b;
}
else
{
    max = b; min = a;
}

Console.Write("max = ");
Console.WriteLine(max);
Console.Write("min = ");
Console.WriteLine(min);
