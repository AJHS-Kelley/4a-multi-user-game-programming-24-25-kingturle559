using System;

class RPS {
  static void Main() {
   //Player variables
  int playerScore = 0;
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

Random rnd = new Random(); 
while (loopCount < loopReqs)
  {
    // allow CPU to select randomly.
    int cpuRand = rnd.Next(0, 3);

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
    
    int playerRand = rnd.Next(0, 3);

    if (cpuRand == 0)
    {
      playerChoice = "rock";
    }
    if (playerRand == 1)
    {
      playerChoice = "paper";
    }
    if (playerRand == 2)
    {
      playerChoice = "scissors";
    }
    else
    {
      Console.WriteLine("unable to determine CPU choice.");
    }
    Console.WriteLine("CPU Choice" + cpuChoice);
    // compare the two choicesand determine a winner.
    if (playerChoice == "rock" && cpuChoice == "paper")
    {
    
      Console.WriteLine("The CPU wins.\n");
      cpuScore = cpuScore + 1;
    }
    if (playerChoice == "rock" && cpuChoice == "scissors")
    {
    
      Console.WriteLine("you win!\n");
     playerScore = playerScore + 1;
    }
    if (playerChoice == "rock" && cpuChoice == "rock")
    {
    
      Console.WriteLine("It's a draw!");
      numDraws = numDraws + 1;
    }
    Console.WriteLine("CPU Choice" + cpuChoice);
    // paper
    if (playerChoice == "paper" && cpuChoice == "scissors")
    {
    
      Console.WriteLine("The CPU wins.\n");
      cpuScore = cpuScore + 1;
    }
    if (playerChoice == "paper" && cpuChoice == "rock")
    {
    
      Console.WriteLine("you win!\n");
     playerScore = playerScore + 1;
    }
    if (playerChoice == "paper" && cpuChoice == "paper")
    {
    
      Console.WriteLine("It's a draw!");
      numDraws = numDraws + 1;
    }
    Console.WriteLine("CPU Choice" + cpuChoice);
    // scissors
    if (playerChoice == "scissors" && cpuChoice == "rock")
    {
    
      Console.WriteLine("The CPU wins.\n");
      cpuScore = cpuScore + 1;
    }
    if (playerChoice == "scissors" && cpuChoice == "paper")
    {
    
      Console.WriteLine("you win!\n");
     playerScore = playerScore + 1;
    }
    if (playerChoice == "scissors" && cpuChoice == "scissors")
    {
    
      Console.WriteLine("It's a draw!");
      numDraws = numDraws + 1;
    }



  Console.WriteLine($"Player Score: {playerScore}\n");
  Console.WriteLine($"CPU Score: {cpuScore}\n");
  Console.WriteLine($"numDraws: {numDraws}\n");

    // Output the results to the screen.
    // Give the winner a point.}
    loopCount++;
  }
  
  
  }
}
	
  


