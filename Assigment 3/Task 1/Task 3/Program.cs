Console.WriteLine("Input Array length: ");
if (!(int.TryParse(Console.ReadLine(), out int N)) || N < 0)
{
    Console.WriteLine("Wrong Input\n");
    return;
}

int[] array1 = new int[N];
int[] array2 = new int[N];
int[] sum = new int[N];


for (int i = 0; i < N; i++)
{
    Console.WriteLine("Input Array Element: ");
    if (!(int.TryParse(Console.ReadLine(), out int element)))
    {
        Console.WriteLine("Wrong Input\n");
        --i;
        continue;
    }
    array1[i] = element;
}
for (int i = 0; i < N; i++)
{
    Console.WriteLine("Input Seond Array Element: ");
    if (!(int.TryParse(Console.ReadLine(), out int element)))
    {
        Console.WriteLine("Wrong Input\n");
        --i;
        continue;
    }
    array2[i] = element;
}
Console.WriteLine("Input Order(ASC/DESC): ");
var input = "";
while (true)
{
    input = Console.ReadLine();
    if (input != "ASC" && input != "DESC")
    {
        Console.WriteLine("Wrong Input\n");
        continue;
    }
    else break;
}
var isASC = (input == "ASC");
for (int i = 0; i < N; i++)
{
    sum[i] = array1[i] + array2[i];
}




var isSorted = false;
while (!isSorted)
{
    isSorted = true;
    for (int i = 1; i < N; i++)
    {
        if (isASC ? sum[i] < sum[i - 1] : sum[i] > sum[i - 1])
        {
            var temp = sum[i - 1];
            sum[i - 1] = sum[i];
            sum[i] = temp;
            isSorted = false;
        }


    }

}
for (int j = 0; j < N; j++)
{
    Console.Write(sum[j] + " ");
}

