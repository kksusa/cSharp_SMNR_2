Console.WriteLine("Напишите трёхзначное число:");
string? numberstring = Console.ReadLine();
int number = int.Parse(numberstring!);
int secondDigit = number / 10 % 10;
if (secondDigit < 0) secondDigit *= -1;
Console.WriteLine("Вторая цифра этого числа " + secondDigit + ".");