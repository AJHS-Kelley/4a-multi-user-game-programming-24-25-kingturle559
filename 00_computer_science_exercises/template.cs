using System;
class Template {
  static void Main() {
   
   string playerName = "TestPlayer";
  int PlayerScore = 0;
  string playerChoice;

  int cpuScore = 0;
  string cpuChoice;

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
  if (cpuRand == 0)
  {
    cpuChoice = "paper";
  }
  if (cpuRand == 0)
  {
    cpuChoice = "scissors";
  }
  
  // ompare the two choicesand determine a winner.
  // Output the results to the screen=.
  // ivethe winner a point.


}

