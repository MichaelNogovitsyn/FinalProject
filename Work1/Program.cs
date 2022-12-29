
string[] InitArray = { "Hello", "2", "world", ":-)" };

int CountSynbolArray(string[] array, int numSymb)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= numSymb)
            count++;
    }
    return count;
}

void defineArray(string[] array, string[] newArray, int numSymb)
{
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (array[i].Length <= numSymb)
        {
            newArray[j] = InitArray[i];
            j++;
        }
    }
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}
int CountArr = CountSynbolArray(InitArray, 3);
string[] ResultArray = new string[CountArr];
defineArray(InitArray, ResultArray, 3);
PrintArray(ResultArray);
