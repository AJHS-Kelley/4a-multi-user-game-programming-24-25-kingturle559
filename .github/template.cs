using System;
class Template {
  static void Main() {
    
 int PlayerLevel = 3;
 int PlayerScore = Convert.ToInt32(Console.ReadLine());
  if ( PlayerScore <= 10000)
  {
    PlayerLevel--;
  } 
  else if (PlayerScore <= 10001)
  {
    PlayerLevel++;
  }
  else if (PlayerScore > 100000)
  {
    PlayerLevel+=2;
  }
    Console.WriteLine (PlayerLevel);
  }
  
}