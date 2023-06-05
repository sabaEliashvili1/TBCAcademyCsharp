Console.WriteLine("Input Height: ");
if (!(int.TryParse(Console.ReadLine(), out int input)) || input < 1)
{
    Console.WriteLine("Wrong Input");
    return;
}
var starAmm = 1;
for (int i = 1; i <= input; i++)
{
    for (int j = 0; j < input - i; j++)
    {
        Console.Write(" ");
    }
    for (int j = 0; j < starAmm; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
    starAmm += 2;
}