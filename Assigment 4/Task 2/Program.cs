var array = InputArray();
var charater = "";
while (true)
{
    Console.Write("Input symbol: ");
    charater = Console.ReadLine();
    if (charater == "" || charater.Length > 1)
    {
        Console.WriteLine("Wrong Input");
    }
    else
    {
        break;
    }
}
charNum(array, charater[0]);



char[] InputArray()
{
    
    var N = 0;
    while (true)
    {
        Console.Write("Input Length: ");
        if (!(int.TryParse(Console.ReadLine(), out N)))
        {
            Console.WriteLine("Wrong Input\n");
        }
        else
        {
            break;
        }
    }

    char[] array1 = new char[N];
    for (int i = 0; i < N; i++)
    {
        while (true)
        {
            Console.Write("[" + i + "]");
            var temp = Console.ReadLine();
            if (temp == "" || temp.Length > 1)
            {
                Console.WriteLine("Wrong Input");
            }
            else
            {
                array1[i] = temp[0];
                break;
            }
        }
    }
    return array1;
}

void charNum(char[] arr, char symbol)
{
    var ammount = 0;
    foreach (var item in arr)
    {
        if(item == symbol)
        {
            ++ammount;
        }
    }
    Console.WriteLine("Symbol \"" + symbol + "\" appears " + ammount + " Times in array");
}
