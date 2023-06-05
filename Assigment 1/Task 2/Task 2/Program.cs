Console.WriteLine("What is current temperature?");
int.TryParse(Console.ReadLine(),out int input);
if(input < 0)
{
    Console.WriteLine("Freezing");
}
else if(input >= 0 && input <= 30)
{
    Console.WriteLine("Good Weather");
}
else if(input > 30)
{
    Console.WriteLine("Hot");
}
else
{
    Console.WriteLine("Wrong Input!!");
}