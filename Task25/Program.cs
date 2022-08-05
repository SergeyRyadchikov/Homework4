int ExponentiationNum (int a, int b)
{
    int res = a;
    for (int count = 1; count < b; count++)
    {
        res = res*a;     
    }
    return res;
}

Console.WriteLine("Введите два числа");
int num_1 = Convert.ToInt32(Console.ReadLine());
int num_2 = Convert.ToInt32(Console.ReadLine());

Console.Write(ExponentiationNum(num_1, num_2));