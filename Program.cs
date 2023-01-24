int CountLess(string[] input, int n)
{
    int count = 0;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i].Length <= n)
        {
            count++;
        }
    }
    return count;
}

string[] GetNewArray(string[] array, int m)
{
    string[] newArray = new string[CountLess(array, m)];
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (array[i].Length <= m)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

string[] array1 = {"Hello", "2", "world", ":-)"};
string[] array2 = GetNewArray(array1, 3);
Console.WriteLine($"[{string.Join(", ", array1)}] -> [{string.Join(", ", array2)}]");

