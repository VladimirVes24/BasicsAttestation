

void PrintArray(string[] inputArray)
{
    int length = inputArray.Length;
    if (length == 0)
    {
        Console.WriteLine("Array is empty");
        return;
    } 
    Console.Write("[");
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{inputArray[i]}");
        if (i != length-1) Console.Write(", ");
    }
    Console.WriteLine("]");
    return;
}

string[] CreateShortStringArrayBasedOn(string[] inputArray, int stringLengthLimit)
{
    int inputLength = inputArray.Length;
    int resultLength = 0;

    for (int i = 0; i < inputLength; i++)
    {
        if (inputArray[i].Length <= stringLengthLimit) resultLength++;
    }
    
    string[] resultArray = new string[resultLength];
    int resultIndex = 0;

    for (int i = 0; i < inputLength; i++)
    {
        if (inputArray[i].Length <= stringLengthLimit) 
        {
            resultArray[resultIndex] = inputArray[i];
            resultIndex++;
        }
    }
    return resultArray;
}

string[] array = new string[6]{ "dsggs","12","dsa","asd","as","dsfsgsgdsdg"};
int stringLimit = 3;
string[] resultArray = CreateShortStringArrayBasedOn(array, stringLimit);
Console.Write("Resulting array: ");
PrintArray(resultArray);