string[] FillArrayMasiv()
{
    Console.Write("Enter length massiv: ");
    int size = Convert.ToInt32(Console.ReadLine());
    string[] str = new string[size];
    for (int i = 0; i < size; i++)
        {   
            Console.Write("Enter strings: ");
            str[i] = Console.ReadLine();
        }
    Console.WriteLine($"You write massiv [{string.Join(", ", str)}]");
    return str;
}

void CoppyArrayMAssiv(string[] arr_first, string[] arr_second)
{
    int count = 0;
    Console.WriteLine("Elements with 3 characters will be selected in the array.");
    Console.WriteLine("If yes, press - 1, no - 2 ");
    int number = Convert.ToInt32(Console.ReadLine());
    if(number ==1)
    {
        for (int i = 0; i < arr_first.Length; i++)
        {
            if(arr_first[i].Length <= 3)
            {
                arr_second[count] = arr_first[i];
                count++;
            }
        }
        Console.Write("Modified array ");
    }
    else
    {
        Console.WriteLine("The program has ended. Bye bye");
    }
}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

string[] arr_first = FillArrayMasiv();
string[] arr_second = new string[arr_first.Length];
CoppyArrayMAssiv(arr_first, arr_second);
PrintArray(arr_second);