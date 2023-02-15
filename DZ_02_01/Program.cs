/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает
 вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/


System.Console.WriteLine("введите трёх-значное число: ");
int Namber1 = Convert.ToInt32(Console.ReadLine());
if (Namber1 > 99 && Namber1 < 1000)
{
    Namber1 = (Namber1 % 100) / 10;
    System.Console.WriteLine(Namber1);
}
else
{
    System.Console.WriteLine("Вы ввели не трёхзначное число!!!!!!");
}



