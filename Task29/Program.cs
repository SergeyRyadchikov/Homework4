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


Console.Write("Введите массив: ");
string Entering = Console.ReadLine();
int[] mass = CreatingArrayFromString(Entering, ' ');
PrintArray(mass);