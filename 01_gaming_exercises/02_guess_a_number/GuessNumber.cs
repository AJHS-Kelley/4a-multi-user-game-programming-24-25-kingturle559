using System;
class GuessNumber {
  static void Main() {
    int numGuess = 0;
    int maxGuess = 5;
    int guess; 
    //Generate the secret number here. 
    Random rnd = new Random(); // Create an object named 'rnd' that is a copy of the random() class.
    int secretNumber = rnd.Next(100); // Generate from 0 to 99
    //Console.WriteLine(secretNumber); // COMMENT OUT AFTER TESTING
    // int secretNumber = rnd.Next(25, 1000); // Generate from 25 to 999
    
    while(numGuess < maxGuess)
    {
      Console.WriteLine("Secret Number" + secretNumber);
      Console.WriteLine("Please guess an integer betwwen X and Y .\n");
      guess = Convert.ToInt32(Console.ReadLine());
      // Console.WriteLine(guess);
      Console.WriteLine("Guess" + guess);
      numGuess++;
      if (guess < secretNumber)
      {
        Console.WriteLine("Your guess is too low.\n");
      }
      else if(guess > secretNumber)
      {
        Console.WriteLine("Your guess is too high.\n");
      }
      else
      {
        Console.WriteLine("Your guessed correctly!\n");
        break; // Keyword to immediately exit a loop.
      }

      if (numGuess >= maxGuess)
      {
        Console.WriteLine("You have lost the game.\n");
      }

    }
     

  }
}