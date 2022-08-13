Console.WriteLine("Напишите целое число от 1 до 7:");
string? numberstring = Console.ReadLine();
int number = int.Parse(numberstring!);
if (number > 7 || number < 1) Console.WriteLine("Вы неправильно ввели число.");
else if (number >= 1 && number <= 5) Console.WriteLine("День не является выходным.");
else Console.WriteLine("Ура! Выходной!");