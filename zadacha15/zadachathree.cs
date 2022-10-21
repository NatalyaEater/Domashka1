// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//Данный код был сдан к предыдущему семинару.
Console.Clear();
Console.WriteLine("Введите номер недели от 1 до 7: ");
int number = int.Parse(Console.ReadLine());
if (number>0 && number<8)
{
    if (number<6 && number>0)
{
    Console.WriteLine("Будний день");
}
    if (number==6 || number==7)
{
    Console.WriteLine("Сегодня выходной");
}
}
else
{
Console.WriteLine("Число не соответствует условию ");
}