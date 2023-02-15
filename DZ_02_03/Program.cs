/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является 
ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

System.Console.WriteLine("введите номер дня недели: ");
int Namber1 = Convert.ToInt32(Console.ReadLine());
if (Namber1 <= 5 && 1 <= Namber1)
{
    System.Console.WriteLine("нет");
}
else if (Namber1 > 5 && 8 > Namber1)
{
    System.Console.WriteLine("да");
}
else if (Namber1 > 7 || Namber1 < 1)
{
    System.Console.WriteLine("такого номера дня недели нет");
}
