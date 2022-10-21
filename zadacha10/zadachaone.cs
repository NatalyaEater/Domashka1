// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();
Console.WriteLine("Ввведите трехзначное число ");
int numberA = int.Parse(Console.ReadLine());
int numberB=(numberA/10)%10;

if (numberA>-999 && numberA<999)
{
    Console.WriteLine($"{numberB},");
}
else 
{
Console.WriteLine("Данное число не соответствует условию");
}