// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// int numberA = 3;
// int numberB = 5;
// Console.WriteLine(numberA + numberB);

Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB)
{
    Console.WriteLine("Первое число больше второго числа");
}
else
{
    Console.WriteLine("Второе число больше первого числа");
}
