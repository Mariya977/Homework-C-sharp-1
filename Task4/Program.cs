// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

Console.Clear();

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int numberA = 0;
while (numberA < N-1)
{
    numberA = numberA + 2;
    Console.WriteLine(numberA);
}