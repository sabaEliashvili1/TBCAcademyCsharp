while (true)
{
    Console.WriteLine("Input Min Ammount: ");
    if (!(int.TryParse(Console.ReadLine(), out int min)))
    {
        Console.WriteLine("Wrong Input\n");
        continue;
    }
    Console.WriteLine("Input Max Ammount: ");
    if (!(int.TryParse(Console.ReadLine(), out int max)) || max <= min)
    {
        Console.WriteLine("Wrong Input\n");
        continue;
    } 
    var rand = new Random().Next(min,max+1);
    var tries = 1;
    Console.WriteLine("Now Guess:");
    while (true)
    {
        if (!(int.TryParse(Console.ReadLine(), out int input)))
        {
            Console.WriteLine("Wrong Input");
            continue;
        }
        if(input == rand)
        {
            Console.WriteLine("You won in " + tries + " try");
            break;
        }
        else
        {
            ++tries;
            Console.WriteLine("Wrong, Try Again!");
        }
    }
    var cont = "";
    while (true)
    {
        Console.WriteLine("Do you wish to continue? (Yes/No)");
        cont = Console.ReadLine(); 
        if(cont != "Yes" && cont != "No")
        {
            Console.WriteLine("Wrong Input");
        }
        else
        {
            break;
        }
    }
    if(cont == "Yes") { continue; }
    else if(cont == "No") { break; }
}