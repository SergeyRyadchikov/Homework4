// дан массив , найти срзнач, медиану, сравнить их


int[] CreatingArrayFromString(string EnteringArray, char value)
{
    int count = 1;
    for (int iStr = 0; iStr < EnteringArray.Length; iStr++)
    {
        if (EnteringArray[iStr] == value)
        {
            count++;
        }
    }

    Console.Write("Размерность массива: \t" + (count));
    Console.WriteLine();

    int[] arr = new int[count];
    int iArr = 0;
    string save = string.Empty;

    for (int iStr = 0; iStr < EnteringArray.Length; iStr++)
    {
        if (iStr != EnteringArray.Length - 1)
        {
            while (EnteringArray[iStr] != value)
            {
                save = save + $"{EnteringArray[iStr]}";
                iStr++;
                if (iStr == EnteringArray.Length) break;
            }
            arr[iArr] = int.Parse(save);
            iArr++;
            save = string.Empty;
        }
        else
        {
            save = save + $"{EnteringArray[iStr]}";
            arr[iArr] = int.Parse(save);
        }
    }
    return arr;
}

void PrintArray(int[] coll)
{
    int i_col = 0;
    while (i_col < coll.Length)
    {
        if (i_col != coll.Length - 1)
        {
            Console.Write(coll[i_col] + ", ");
        }
        else Console.Write(coll[i_col]);
        i_col++;
    }
    Console.WriteLine();
}

void SelectionSortMin(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temporarray = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporarray;

    }
}

double Avarage(int[] arr)
{
    double res = 0;
    for (int indexStart = 0; indexStart < arr.Length; indexStart++)
    {
        res = res + arr[indexStart];
    }
    res = res / arr.Length;
    return res;
}

double Median(int[] coll)
{
    int parity = coll.Length % 2;
    int res = 0;
    double med = 0;
    if (parity == 0)
    {
        res = coll.Length / 2;
        med = (coll[res] + coll[res - 1]) / 2.00;
    }
    else
    {
        res = coll.Length / 2;
        med = coll[res];
    }
    return med;
}

void CompareAvarMed(double avar, double med)
{
    if (avar < med) Console.WriteLine("Медиана больше, чем среднее арифметическое");
    else if (avar == med) Console.WriteLine("Медиана и среднее арифметическое равны");
    else Console.WriteLine("Среднее арифметическое больше медианы");
}

Console.Write("Введите массив: ");
string Entering = Console.ReadLine();
int[] mass = CreatingArrayFromString(Entering, ' ');
PrintArray(mass);
SelectionSortMin(mass);
Console.WriteLine("Среднее арифметическое: " + (Avarage(mass)));
Console.WriteLine("Медиана: " + Median(mass));
CompareAvarMed(Avarage(mass), Median(mass));


