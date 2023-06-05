Console.WriteLine("What is your Play?(r,p,s)");
var input = Console.ReadLine();
var rand = new Random().Next(0,3);

if (input == "r")
{
    if (rand == 0) { Console.WriteLine("Computer Played Rock! \n It's a Tie!"); }
    else if (rand == 1) { Console.WriteLine("Computer Played Paper! \n You Lose!"); }
    else if (rand == 2) { Console.WriteLine("Computer Played Scissors! \nYou Win!"); }
}
else if (input == "p")
{
    if (rand == 0) { Console.WriteLine("Computer Played Rock! \n You Win!"); }
    else if (rand == 1) { Console.WriteLine("Computer Played Paper! \n It's a Tie!"); }
    else if (rand == 2) { Console.WriteLine("Computer Played Scissors! \nYou Lose!"); }
}
else if (input == "s")
{
    if (rand == 0) { Console.WriteLine("Computer Played Rock! \n You Lose!"); }
    else if (rand == 1) { Console.WriteLine("Computer Played Paper! \n You Win!"); }
    else if (rand == 2) { Console.WriteLine("Computer Played Scissors! \n It's a Tie!"); }
}
else
{
    Console.WriteLine("Wrong Input!!");
}