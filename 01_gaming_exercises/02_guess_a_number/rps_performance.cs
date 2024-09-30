using System;

class RPS {
  static void Main() {
   //Player variables
  int PlayerScore = 0;
  string playerChoice = "";
  int numDraws = 0;

  //CPU variables
  int cpuScore = 0;
  string cpuChoice = "";

  // Testing game loop
  int loopCount = 0;
  int loopReqs = 0; // Req / Reqs is universal abbrv. for REQUEST / REQUESTS
  Console.WriteLine("How many loops do you need?\nType an INTERGER and press ENTER\n");
  loopReqs= Convert.ToInt32(Console.ReadLine());

while (PlayerScore < 5 && cpuScore < 5)

  // allow CPU to select randomly.
  Random rnd = new Random(); 
  int cpuRand = rnd.Next(0, 2);

  if (cpuRand == 0)
  {
    cpuChoice = "rock";
  }
  if (cpuRand == 1)
  {
    cpuChoice = "paper";
  }
  if (cpuRand == 2)
  {
    cpuChoice = "scissors";
  }
  else
  {
    Console.WriteLine("unable to determine CPU choice.");
  }
  Console.WriteLine("CPU Choice" + cpuChoice);
  // compare the two choicesand determine a winner.
  if (playerChoice == "rock" && cpuChoice == "paper")
  {
    Console.WriteLine($"you chose {playerChoice} and the CPU chose {cpuChoice}.\n");
    Console.WriteLine("The CPU wins.\n");
    cpuScore++;
  }
   if (playerChoice == "rock" && cpuChoice == "scissors")
  {
    Console.WriteLine($"you chose {playerChoice} and the CPU chose {cpuChoice}.\n");
    Console.WriteLine("you win!\n");
    PlayerScore++;
  }
   if (playerChoice == "rock" && cpuChoice == "rock")
  {
    Console.WriteLine($"you chose {playerChoice} and the CPU chose {cpuChoice}.\n");
    Console.WriteLine("It's a draw!");
  }
   Console.WriteLine("CPU Choice" + cpuChoice);
  // paper
  if (playerChoice == "paper" && cpuChoice == "scissors")
  {
    Console.WriteLine($"you chose {playerChoice} and the CPU chose {cpuChoice}.\n");
    Console.WriteLine("The CPU wins.\n");
    cpuScore++;
  }
   if (playerChoice == "paper" && cpuChoice == "rock")
  {
    Console.WriteLine($"you chose {playerChoice} and the CPU chose {cpuChoice}.\n");
    Console.WriteLine("you win!\n");
    PlayerScore++;
  }
   if (playerChoice == "paper" && cpuChoice == "paper")
  {
    Console.WriteLine($"you chose {playerChoice} and the CPU chose {cpuChoice}.\n");
    Console.WriteLine("It's a draw!");
  }
   Console.WriteLine("CPU Choice" + cpuChoice);
  // scissors
  if (playerChoice == "scissors" && cpuChoice == "rock")
  {
    Console.WriteLine($"you chose {playerChoice} and the CPU chose {cpuChoice}.\n");
    Console.WriteLine("The CPU wins.\n");
    cpuScore++;
  }
   if (playerChoice == "scissors" && cpuChoice == "paper")
  {
    Console.WriteLine($"you chose {playerChoice} and the CPU chose {cpuChoice}.\n");
    Console.WriteLine("you win!\n");
    PlayerScore++;
  }
   if (playerChoice == "scissors" && cpuChoice == "scissors")
  {
    Console.WriteLine($"you chose {playerChoice} and the CPU chose {cpuChoice}.\n");
    Console.WriteLine("It's a draw!");
  }

if (PlayerScore == 5 )
{
  Console.WriteLine("congrats you won!!!");

}

if (cpuScore == 5 )
{
  Console.WriteLine("you have been defeated.");
}
  // Output the results to the screen.
  // ivethe winner a point.

}
}
}
