Console.WriteLine("Введите первое число");
string num0 = Console.ReadLine() ??"";

Console.WriteLine("Введите второе число");
string num1 = Console.ReadLine() ??"";

int number0 = Convert.ToInt32(num0);
int number1 = Convert.ToInt32(num1);

if (number0 > number1)
{
    Console.Write($"Число {number0} больше, числа {number1}");
}
else
{
    Console.Write($"Число {number1} больше, число {number0}");
}