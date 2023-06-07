Console.WriteLine("Choose matrix size:\n 1. 2 X 2 \n 2. 3 X 3");

if (!(int.TryParse(Console.ReadLine(), out int N)) || (N != 1 && N!=2))
{
    Console.WriteLine("Wrong Input\n");
    return;
}

var length = 0;
if (N == 1) length = 2;
else length = 3;



int[,] array1 = new int[3, 3];
for (int i = 0; i < length; i++)
{
    for (int j = 0; j < length; j++)
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
var determinant = 0;
if (N == 1)
{
    determinant = array1[0, 0] * array1[1, 1] - array1[1, 0] * array1[0, 1];
}
else
{
    determinant = array1[0, 0] * (array1[1, 1] * array1[2, 2] - array1[1, 2] * array1[2, 1]) - array1[0, 1] * (array1[1, 0] * array1[2, 2] - array1[1, 2] * array1[2, 0]) + array1[0, 2] * (array1[1, 0] * array1[2, 1] - array1[1, 1] * array1[2, 0]);
}  


for (int i = 0; i < length; i++)
{
    for (int j = 0; j < length; j++)
    {
        Console.Write(array1[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("determinant is: " + determinant);
