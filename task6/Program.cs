Console.WriteLine("Введите число");
string num0 = Console.ReadLine() ??"";

int number0 = Convert.ToInt32(num0);

if (number0 % 2 == 0)
{
    Console.Write($"Число {number0}, чётное");
}
else
{
    Console.Write($"Число {number0}, нечётное");
}