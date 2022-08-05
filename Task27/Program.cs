int SumOfDigits(int a)
{
    int res = 0;
    while (a != 0)
    {
        res = res + a % 10;
        a = a / 10;
    }
    return res;
}

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write(SumOfDigits(num));