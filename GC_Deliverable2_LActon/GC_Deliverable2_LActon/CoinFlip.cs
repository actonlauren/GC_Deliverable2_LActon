// See https://aka.ms/new-console-template for more information

int playersScore = 0;
Random random = new Random();

Console.WriteLine("What is your name?");
string usersName = Console.ReadLine();
Console.WriteLine($"Welcome {usersName} would you like to do the coin flip challenge? Y/N");
string usersAnswer = Console.ReadLine();

if (usersAnswer == "N" || usersAnswer == "n")
{
    Console.WriteLine($"You are a coward {usersName}");
}
if (usersAnswer == "Y" || usersAnswer == "y")
{
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine("Heads or Tails?");
        string playersAnswer = Console.ReadLine();
        int coinFlip = random.Next(0, 2);
        if (coinFlip == 0)
        {
            if (playersAnswer == "Heads" || playersAnswer == "heads")
            {
                Console.WriteLine("Correct!");
                playersScore += 1;
            }
            if (playersAnswer == "Tails" || playersAnswer == "tails")
            {
                Console.WriteLine("Wrong!");
            }
        }
        if (coinFlip == 1)
        {
            if (playersAnswer == "Heads" || playersAnswer == "heads")
            {
                Console.WriteLine("Wrong!");
            }
            if (playersAnswer == "Tails" || playersAnswer == "tails")
            {
                Console.WriteLine("Correct!");
                playersScore += 1;
            }
        }

    }
    Console.WriteLine($"Thank you for playing {usersName} you scored {playersScore} out of 5 possible points.");
}