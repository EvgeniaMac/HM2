// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

Console.WriteLine("Введите номер дня недели");
int dayNumber = Convert.ToInt32(Console.ReadLine());

if (dayNumber <=7 && dayNumber>=1)
{
    if (dayNumber == 6)
    {
        Console.WriteLine("Это выходной день");
    }
    if (dayNumber == 7)
    {
        Console.WriteLine("Это выходной день");
    }
    if (dayNumber <=5 && dayNumber>=1)
    {
        Console.WriteLine("Это рабочий день");
    }
}
else
 {
    Console.WriteLine("Error");
 }   