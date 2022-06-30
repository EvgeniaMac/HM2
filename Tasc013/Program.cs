//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число");

int N = Convert.ToInt32(Console.ReadLine());
int result = 0;

if(result=(N%100 - N%10)/10)
{
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Нет второго числа");
}