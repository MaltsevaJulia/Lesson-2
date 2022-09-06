// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет

Console.WriteLine("введите число");
string number = Console.ReadLine();
int number2 = Convert.ToInt32(number);

if (number2 >=1 && number2 <=99)
{
    Console.WriteLine("третьей цифры нет");      
}

if (number2 >=100)
{
    Console.WriteLine(number[2]);      
}



