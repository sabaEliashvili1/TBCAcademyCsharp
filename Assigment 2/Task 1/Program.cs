Console.WriteLine("Input Number: ");
if(!(int.TryParse(Console.ReadLine(),out int input)) || input < 1)
{
    Console.WriteLine("Wrong Input");
    return;
}

var Dividers = 0;
for (int i = 1; i <= input; i++)
{
    if(input % i == 0 ) Dividers++;
}

if(Dividers == 2)
{
    Console.WriteLine("Prime");
}
else
{
    Console.WriteLine("Not Prime");
}