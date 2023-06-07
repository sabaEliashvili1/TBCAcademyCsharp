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

int startIndex = 0;
int maxLength = 0;
int currentIndex = 0;
int currentLength = 1;

for (int i = 1; i < N; i++)
{
    if (array[i] > array[i - 1])
    {
        currentLength++;
        if (currentLength > maxLength)
        {
            maxLength = currentLength;
            startIndex = currentIndex;
        }
    }
    else
    {
        currentIndex = i;
        currentLength = 1;
    }
}

Console.WriteLine("Longest ascending sequence:");
for (int i = startIndex; i < startIndex + maxLength; i++)
{
    Console.Write(array[i] + " ");
}
Console.WriteLine();
Console.WriteLine("Starting index: " + startIndex);