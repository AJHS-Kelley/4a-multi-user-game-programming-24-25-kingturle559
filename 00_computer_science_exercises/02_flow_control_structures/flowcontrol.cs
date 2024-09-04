using System;
class Template {
    static void Main() {
         // Switch statements
      int day = 1;
      //switch (day)

       /* {    
            case 1:
                console.WriteLine("It's Monday.\n");
                break;
            case 2:
                console.WriteLine("It's Tuesday.\n");
                break;
            case 3:
                console.WriteLine("It's Wednesday.\n");
                break;
            //case 4 - 6 
            case 7: 
                Console.WriteLine("It's Sunday, go rest.\n");
                break;  
        }
        
        // REPEATING STEPS OVER, AND OVER, AND OVER AGAIN
        // LOOPS are use to repeat instructions multiple times.
        
        // while Loops are "musical chairs" in computer science.
        // use while loops if you DO NOT know how many loops are needed
        // the code will run as long as the condition is true.
        // while loop syntax:
        /* 
        
        while (CONDITIONAL_EXPRESSION)
        {
            code to loop goes here.
        }
        
        */ 
        /*
        int z = 0;
        while (z <= 100) // What do I replace CONDITIONAL_EXPRESSION WITH?
        
        
        {
            Console.WriteLine(z);
            z++;
        }
        
        int y = 100;
        while (y <= 0) // What do I replace CONDITIONAL_EXPRESSION WITH?
        
        
        {
            Console.WriteLine(y);
            y-- ;
        }
        */
        // for loops are like playing go fish.
        // you know how many cards in your hand.
        // is used when you know how many loops you need ahead of time.
        
        /*
        for (statement1; statement2; statememnt3)
        {
            code to run easch time through loop
        
        }
        
        statement1 = code to run ONE TIME before the loop starts.
        statement2 = CONDITIONAL EXPRESSION to check EACH TIME before loo runs.
        statement = code to run AFTER each loop.
        
        each 'trip' through the loop is called an ITERATION.
        */ 

//counting to 10 with for loops.
for (int i = 0; i <= 10; i++)
{
    Console.WriteLine (i);

}


}
  }