Console.WriteLine("Input Array length: ");
if (!(int.TryParse(Console.ReadLine(), out int N)) || N < 0)
{
    Console.WriteLine("Wrong Input\n");
    return;
}

string[] array1 = new string[N];
int[] array2 = new int[N];  
string[] combinedArray = new string[N];
var element = "";

for (int i = 0; i < N; i++)
{
    Console.WriteLine("Input Array1 Element: ");
    element = Console.ReadLine();
    array1[i] = element;
}

for (int i = 0; i < N; i++)
{
    Console.WriteLine("Input Array2 Element: ");
    if (!(int.TryParse(Console.ReadLine(), out int intElement)))
    {
        Console.WriteLine("Wrong Input\n");
        --i;
        continue;
    }
    array2[i] = intElement;
}

for (int i = 0; i < N; i++)
{
    combinedArray[i] = array1[i] +" " + array2[i];
}

for (int j = 0; j < N; j++)
{
    Console.Write(combinedArray[j] + ", ");
}