Console.Write("Input N: ");
if (!(int.TryParse(Console.ReadLine(), out int N)))
{
    Console.WriteLine("Wrong Input\n");
    return;
}
Console.Write("Input M: ");
if (!(int.TryParse(Console.ReadLine(), out int M)))
{
    Console.WriteLine("Wrong Input\n");
    return;
}
Console.Write("Input K: ");
if (!(int.TryParse(Console.ReadLine(), out int K)))
{
    Console.WriteLine("Wrong Input\n");
    return;
}

var length = 0;
if (N == 1) length = 2;
else length = 3;



int[,] array1 = new int[N, M];
int[,] array2 = new int[M, K];
int[,] mult = new int[N, K];
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < M; j++)
    {
        while (true)
        {
            Console.Write("[" + i + "]" + "[" + j + "]: ");
            if (!(int.TryParse(Console.ReadLine(), out int temp)))
            {
                Console.WriteLine("Wrong Input");
                continue;
            }
            else
            {
                array1[i, j] = temp;
                break;
            }
        }
    }
}
Console.WriteLine("Array 2:");
for (int i = 0; i < M; i++)
{
    for (int j = 0; j < K; j++)
    {
        while (true)
        {
            Console.Write("[" + i + "]" + "[" + j + "]: ");
            if (!(int.TryParse(Console.ReadLine(), out int temp)))
            {
                Console.WriteLine("Wrong Input");
                continue;
            }
            else
            {
                array2[i, j] = temp;
                break;
            }
        }
    }
}

for (int i = 0; i < N; i++)
{
    for (int j = 0; j < K; j++)
    {
        var element = 0;

        for (int t = 0; t < M; t++)
        {
            element += array1[i, t] * array2[t, j]; 
        }


        mult[i, j] = element;
    }
}

for (int i = 0; i < N; i++)
{
    for (int j = 0; j < K; j++)
    {
        Console.Write(mult[i,j]+ " ");
    }
    Console.WriteLine();
}