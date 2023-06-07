Console.WriteLine("Input Array length: ");
if (!(int.TryParse(Console.ReadLine(), out int N)) || N < 0)
{
    Console.WriteLine("Wrong Input\n");
    return;
}

int[] array = new int[N];

for (int i = 0; i < N; i++)
{
    Console.WriteLine("Input Array Element: ");
    if (!(int.TryParse(Console.ReadLine(), out int element)))
    {
        Console.WriteLine("Wrong Input\n");
        --i;
        continue;
    }
    array[i] = element;
}

var isSorted = false;
while (!isSorted)
{
    isSorted = true;
    for (int i = 1; i < N; i++)
    {
        if (array[i] > array[i - 1])
        {
            var temp = array[i - 1];
            array[i - 1] = array[i];
            array[i] = temp;
            isSorted = false;
        }
        

    }
    
}
for (int j = 0; j < N; j++)
{
    Console.Write(array[j] + " ");
}

