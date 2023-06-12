Console.Write("Input Length: ");
if (!(int.TryParse(Console.ReadLine(), out int N)))
{
    Console.WriteLine("Wrong Input\n");
    return;
}

int[] array1 = new int[N];
for (int i = 0; i < N; i++)
{
    while (true)
    {
        Console.Write("[" + i + "]");
        if (!(int.TryParse(Console.ReadLine(), out int temp)))
        {
            Console.WriteLine("Wrong Input");
            continue;
        }
        else
        {
            array1[i] = temp;
            break;
        }
    }
}
Console.Write("Input Index: ");
if (!int.TryParse(Console.ReadLine(), out int index))
{
    Console.WriteLine("Wrong Input\n");
    return;
}
Console.WriteLine(AddNumb(array1,index));

static int AddNumb(int[] arr, int index)
{
    var ans = 0;
    var number = arr[index];

    while (number > 0)
    {
        ans += number % 10;
        number /= 10;
    }
    return ans;
}