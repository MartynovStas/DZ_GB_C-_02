/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6*/

System.Console.WriteLine("Введите число: ");
int Namber1 = Convert.ToInt32(Console.ReadLine());
int i = 10;
if (Namber1 > 99 && Namber1 < 1000)
{
    Namber1 = Namber1 % i;
    System.Console.WriteLine(Namber1);
}
else if (Namber1 > 999 && Namber1 < 10000)
{
    i = i * 10;
    Namber1 = (Namber1 % i) / 10;
    System.Console.WriteLine(Namber1);
}
else if (Namber1 > 9999 && Namber1 < 100000)
{
    i = i * 100;
    Namber1 = (Namber1 % i) / 100;
    System.Console.WriteLine(Namber1);
}
else if (Namber1 > 99999 && Namber1 < 1000000)
{
    i = i * 1000;
    Namber1 = (Namber1 % i) / 1000;
    System.Console.WriteLine(Namber1);
}
else if (Namber1 > 999999 && Namber1 < 10000000)
{
    i = i * 10000;
    Namber1 = (Namber1 % i) / 10000;
    System.Console.WriteLine(Namber1);
}
else
{
    System.Console.WriteLine("третей цифры нету");
}


