// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();

Console.Write("Напишите три любых числа: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());
int numberC = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB)
{
    Console.Write("Первое число максимальное");
}
else if (numberB > numberC)
{
    Console.Write("Второе число максимальное");
}
else if (numberC > numberA)
{
    Console.Write("Третье число максимальное");
}