Console.WriteLine("Введите первое число");
string num0 = Console.ReadLine() ??"";

Console.WriteLine("Введите второе число");
string num1 = Console.ReadLine() ??"";

Console.WriteLine("Введите третье число");
string num2 = Console.ReadLine() ??"";

int number0 = Convert.ToInt32(num0);
int number1 = Convert.ToInt32(num1);
int number2 = Convert.ToInt32(num2);

if ((number0 > number1) && (number0 > number2))
{
    Console.Write($"Число {number0} больше, числа {number1}и числа {number2}");
}
if ((number1 > number0) && (number1 > number2))
{
    Console.Write($"Число {number1} больше, числел {number0} и числа {number2}");
}
else
{
    Console.Write($"Число {number2} больше, числел {number0} и числа {number1}");
}   
