// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("введите трехзначное число");
string number = Console.ReadLine();

while (number.Length != 3)
{
    Console.WriteLine("введите трехзначное число"); 
    number = Console.ReadLine();
}

Console.WriteLine(number[1]);
