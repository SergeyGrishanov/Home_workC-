// Программа, которая на вход принимает три числа и выдаёт, какое число большее, а какое меньшее
Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число: ");
int c = int.Parse(Console.ReadLine()!);

int max = a;

if(b > max)
{ 
    max = b;
}
if(c > max)
{
   max = c; 
}

Console.Write("max = ");
Console.WriteLine(max);