using System;
using System.Linq;
using System.Collections;

class MoreArrays { 
    static void Main() {

        /*string[] colors = {"gold", "purple", "teal", "fuschia"};
        // looping through arrays -- the old way.
        for (int i = 0; i < colors.Length; i++)
        {
            Console.WriteLine(colors[i]);  
        }

        //looping through arrays -- the new way
        foreach (string i in colors)
        {
            Console.WriteLine(i);
        }

        // looping through array practice
        int[] numbers = {17, 45, 37, 29 ,85, 3467, -976, 1567, 8975, -934};
         foreach (int i in numbers)
        {
            Console.WriteLine(i);
            if (i % 2 == 0) //modulus divides and returns the remainder.
            {
                Console.WriteLine("this number is even.\n");
            }
            else
            {
                Console.WriteLine("this number is odd.\n");
            }
        }
        


*/



        // multidimensional arrays
        int[,] nums = { {2, 4, 6}, {-1, 0, 1} };

        // accessing elements in 2d arrays
        Console.WriteLine(nums[0, 1]);
        Console.WriteLine(nums[1, 1]);

        // changing elements in 2d arrays
        nums[1, 2] = 9001;
        //change any element from the first array
        nums[0, 2] = 502;


        //loopin through 2d arrays
        foreach (int i in nums)
        {
            Console.WriteLine(i);
        }

        // 
        for (int i = 0; i < nums.GetLength(0); i++)
        {
            for (int j = 0; j < nums.GetLength(1); j++)
            {
                Console.WriteLine(nums[i, j]);
            }
        }






    }

} 