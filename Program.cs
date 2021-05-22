using System;

int player = 0;
int computer = 0;

Game();

void Game()
{

    Random r = new Random();

    if (player == 3)
    {
        Console.WriteLine("You Win!");
    }
    else if (computer == 3)
    {
        Console.WriteLine("You lose. Computer Wins!");
    }




    Console.WriteLine("-----------------------------");
    Console.WriteLine($"| Player: {player}  |  Computer: {computer} |");
    Console.WriteLine("-----------------------------");
    Console.WriteLine("What would you like to throw?");
    Console.WriteLine("1) Rock");
    Console.WriteLine("2) Paper");
    Console.WriteLine("3) Scissors");

    string playInputString = Console.ReadLine();
    if (String.IsNullOrEmpty(playInputString))
    {

    }
    int playInputInt = Int32.Parse(playInputString);

    int computerRandom = r.Next(1, 3);

    if (playInputInt == computerRandom)
    {
        Game();
    }

    if (playInputInt == 1)
    {
        if (computerRandom == 2)
        {
            computer++;
            Rock();
            Console.WriteLine("VS");
            Paper();
            Console.WriteLine("Paper Covers Rock");
            Game();
        }
        else if (computerRandom == 3)
        {
            player++;
            Rock();
            Console.WriteLine("VS");
            Scissors();
            Console.WriteLine("Rock Breaks Scissors");
            Game();
        }
    }
    else if (playInputInt == 2)
    {
        if (computerRandom == 1)
        {
            player++;
            Paper();
            Console.WriteLine("VS");
            Rock();
            Console.WriteLine("Paper Covers Rock");
            Game();
        }
        else if (computerRandom == 3)
        {
            computer++;
            Paper();
            Console.WriteLine("VS");
            Scissors();
            Console.WriteLine("Scissors cut Paper");
            Game();
        }
    }
    else if (playInputInt == 3)
    {
        if (computerRandom == 1)
        {
            computer++;
            Scissors();
            Console.WriteLine("VS");
            Rock();
            Console.WriteLine("Rock Breaks Scissors");
            Game();
        }
        else if (computerRandom == 2)
        {
            player++;
            Scissors();
            Console.WriteLine("VS");
            Paper();
            Console.WriteLine("Scissors cut Paper");
            Game();
        }
    }


}



//Rock
void Rock()
{
    Console.WriteLine(@"
    _______
---'   ____)
      (_____)
      (_____)
      (____)
-- -.__(___)
");
}

// Paper
void Paper()
{
    Console.WriteLine(@"
     _______
---'    ____)____
           ______)
          _______)
         _______)
---.__________)
");
}

//Scissors
void Scissors()
{
    Console.WriteLine(@"
    _______
---'   ____)____
          ______)
       __________)
      (____)
-- -.__(___)
");
}