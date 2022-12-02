Console.WriteLine("Введите число N");
string nfirst = Console.ReadLine() ??"";

int n = Convert.ToInt32(nfirst);

for (int i = (1); i <= n; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
    }
}