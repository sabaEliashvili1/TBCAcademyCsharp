Console.WriteLine("Input Number Ammount: ");
if (!(int.TryParse(Console.ReadLine(), out int input)) || input < 1)
{
    Console.WriteLine("Wrong Input");
    return;
}

var sum = 0;
var ammount = 0;

Console.WriteLine("Input Numbers: ");
for (int i = 0; i < input;)
{
    if ((int.TryParse(Console.ReadLine(), out int num)) && num >= 0)
    {
        sum += num;
        ammount++;
        i++;
    }
    else Console.WriteLine("Wrong Input, Try Again!");
}

Console.WriteLine("Sum is: " + sum + "\nArithmetic average is: " + (double)sum/ammount);