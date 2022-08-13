Console.WriteLine("Напишите целое число:");
string? numberstring = Console.ReadLine();
int number = int.Parse(numberstring!);
int thirdDigit = 0;
int count = 100;
if (number / 100 == 0) Console.WriteLine("Третьей цифры нет.");
else
{
    while (number / count != 0) count *= 10;
    thirdDigit = number / (count / 1000) % 10;
    if (thirdDigit < 0) thirdDigit *= -1;
    Console.WriteLine("Третья цифра этого числа " + thirdDigit + ".");    
}