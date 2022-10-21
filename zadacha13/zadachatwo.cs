//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();
Console.WriteLine("Ввведите число ");
int number = int.Parse(Console.ReadLine()??"0");

while(number>1000||number<-1000)
{
    number=number/10;
}
if (number>99||number<-99)
{
    int count=(number%10);
    Console.WriteLine(count);
}
else 
{
   Console.WriteLine("Третьею цифру невозможно определить "); 
}
