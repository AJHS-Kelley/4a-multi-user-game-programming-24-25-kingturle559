using System;
class Template {
  static void Main() {
   
   string playerName = "TestPlayer";
  int PlayerScore = 0;
  string playerChoice = "";

  int cpuScore = 0;
  string cpuChoice = "";

    Console.WriteLine("To start, please enter you name and press ENTER");
    userName = Console.ReadLine();
    if (iscorrect == "yes")
  {
    Console.WriteLine($"Great! I'll call you {playerName}.\n");
  }

  else if (isCorrect == "no")
  {
    Console.WriteLine($"Please type your name and press ENTER.\n")
    playerName = Console.ReadLine();
  }

    Console.WriteLine($"hello{playername}")
    Console.WriteLine("WELCOME TO ROCK, PAPER, SCISSORS " + playerName + "!\n");
    Console.WriteLine("In this game you will be playing against the CPU.\nRock beats scissors, scissors beats paper, paper beats rock and every time you win a maatch you will gain a point.\nFirst one to 5 wins the game!");

while (playerScore < 5 $$ cpuScore < 5)
{
  // Print the scores
  Console.WriteLine($"Your Score: {playerScore}\nCPU Score: {cpuScore}\n");
  // allow player to select r, p, s.
  Console.WriteLine("Input ROCK, PAPER OR SCISSORS.");
  playerChoice = Console.ReadLine().ToLower();
  if (playerChoice != "rock" && playerChoice != "paper" && playerChoice != "scissors")
  {
    Console.WriteLine("choose Rock, Paper, or Scissors.")
     playerChoice = Console.ReadLine().ToLower();
  }
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
    Console.WriteLine("unable to determine CPU choice.")
  }
  Console.WriteLine("CPU Choice" + cpuChoice);
  // compare the two choicesand determine a winner.
  if (playerChoice == "rock" && cpuChoice == "paper")
  {
    Console.WriteLine($"you chose {playerChoice} and the CPU chose {cpuChoice}.\n");
    Console.WriteLine("The CPU wins.\n");
  }
   if (playerChoice == "rock" && cpuChoice == "scissors")
  {
    Console.WriteLine($"you chose {playerChoice} and the CPU chose {cpuChoice}.\n");
    Console.WriteLine("you win!\n");
    playerScore++;
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
  }
   if (playerChoice == "paper" && cpuChoice == "rock")
  {
    Console.WriteLine($"you chose {playerChoice} and the CPU chose {cpuChoice}.\n");
    Console.WriteLine("you win!\n");
    playerScore++;
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
  }
   if (playerChoice == "scissors" && cpuChoice == "paper")
  {
    Console.WriteLine($"you chose {playerChoice} and the CPU chose {cpuChoice}.\n");
    Console.WriteLine("you win!\n");
    playerScore++;
  }
   if (playerChoice == "scissors" && cpuChoice == "scissors")
  {
    Console.WriteLine($"you chose {playerChoice} and the CPU chose {cpuChoice}.\n");
    Console.WriteLine("It's a draw!");
  }
  // Output the results to the screen.
  // ivethe winner a point.


}

