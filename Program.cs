string[] ArrayOfShorts(string[] array)
{
    int count = 1;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            count++;
    }
    string[] shorts = new string[count];
    if (count > 1)
    {
        int j = 0;
        for (int i = 0; i < array.Length; i++) 
        {
            if (array[i].Length <= 3)
            {
                shorts[j] = array[i];
                j++;
            }
            else continue;
        }
    }

    else shorts[0] = "you've entered nothing of value, you scum! We need shoooooorties!";
    return shorts;
}

string[] CreateArray(int length)
{
    string[] myArray = new string[length];
    int i = 0;
    while (i < length)
    {
        Console.WriteLine("input array element: ");
        myArray[i] = Console.ReadLine();
        i++;
    }
    return myArray;
}

void ShowArr(string[] array)
{

    Console.Write("Your array is [ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}


Console.WriteLine("input array length: ");
int length = Convert.ToInt32(Console.ReadLine());
string[] myArray = CreateArray(length);
ShowArr(myArray);
string[] shorty = ArrayOfShorts(myArray);
Console.WriteLine();
ShowArr(shorty);
