// collectoins example, Charles Massey, v0.0
using System;
using System.Linq;
using System.Collections;

class Collections {
    static void Main() {

        /*
        In c# a collection is known as an ARRAY.
        -- Each itam in the array is an element
        -- number of elements in the array cannot be changed.
        -- Contents of each element can change
        -- array are ordered, meaning each itam has a fixed position
        -- position of the element is the index
        -- first elemenet index is 0.
        */

        // declaring and defining an array
       /* string[] breakfastFoods = {"Bacon", "Eggs", "Grits", "bizkit", "pancakes"};
        int[] testScore = {0, 25, 15, 75, 100};
        double[] GPA = {0.45d, 4.0d, 2.69d, 1.05d, 3.45d};

        // print array contents -- all elements on single line
        //Console.WriteLine ("The elements of each array are:\n");
       // Console.WriteLine("breakfastFoods: \n" + string.Join(", ", breakfastFoods));
       // Console.WriteLine("testScore: \n" + string.Join(", ", testScore));
       // Console.WriteLine("GPA: \n" + string.Join(", ", GPA));
       // Console.WriteLine(); //PRINT AN EMPTY LINE TO THE SCREEN

        //seperat lines display
         Console.WriteLine ("The elements of each array are:\n");
        Console.WriteLine("breakfastFoods: \n" + string.Join("\n ", breakfastFoods));
        Console.WriteLine("testScore: \n" + string.Join("\n ", testScore));
        Console.WriteLine("GPA: \n" + string.Join("\n ", GPA));
        Console.WriteLine(); //PRINT AN EMPTY LINE TO THE SCREEN

        // determining array length
        Console.WriteLine("The length of the breakfastFoods array is: " + breakfastFoods.Length);
        // . Length is known as property of the array.
        Console.WriteLine("The length of the testScore array is: " + testScore.Length);
        Console.WriteLine("The length of the GPA array is: " + GPA.Length);

        // accessing elements in the array with the index.
        Console.WriteLine("The first element in breakfastFoods array is: " + breakfastFoods[0]);
        Console.WriteLine("The second element in breakfastFoods array is: " + testScore[0]);
        Console.WriteLine("The third element in breakfastFoods array is: " + GPA[0]);
        */ 
        
        // ArrayList --> Basically an array you can add/remove elements from.
        var exampleArrList = new ArrayList(); // Creat a new ArrayList. 
        // Adding elements to an ArrayList use .Add()
        // .Add() puts 
        exampleArrList.Add(5);
        exampleArrList.Add("finding nemo");
        exampleArrList.Add(false);
        exampleArrList.Add(1.25D);

        // Creat ArrayList with Values
        var exampleArrList2 = new ArrayList()
            {
                -10, "Last Name", "purple", false, 25.25D, 195000, 0.0D
            };
        //Console.WriteLine(exampleArrList[2]);
       // Console.WriteLine(exampleArrList[5]);

       // INserting to a specific position in the arratlaist
       // use .Insert(index, value)
       //exampleArrList.Insert(3, "Ogres are like onions.\n");
       //exampleArrList.Insert(0, -99);

       // .Remove(value) removes the FIRST OCCURENCE or the item from the ArrayList.
       var newList = new ArrayList()
            {
                -10, 10, 15, -25, -10, 25, 33, -25, 40
            };
        //Console.WriteLine(newList[0]);
        //newList.Remove(-10);
        //Console.WriteLine(newList[0]);

        //Deleting based on indes number.
        //RemoveAt(value) --> deletes the item at the specified index
        //new.List.RemoveAt(4);

        //Delete the first Item
        //newList.RemoveAt(0);

        //Delete the Last Item
        //newList.RemoveAt(newList.Length - 1);

        // Remove an entire range of elements.
        // .RemoveRange(firstIndexToDelete, LastIndexToDelete)
        //newList.RemoveRange(3, 8);

        //Shortcut to delete from one item through end of list.
        //newList.RemoveRange(4, newList.Length - 1);

        // does the ArrayList contain a certain value.
        // .Contains(value) returns true if the list has that value, false otherwise.
        var playerInventory = new ArrayList();
            {
                "sword", "shield", "bazooka", "1-up power-up", "death notebook", "potato"
            };

        Console.WriteLine(playerInventory.Contains("fishing pole"));
        Console.WriteLine(playerInventory.Contains("sword"));

        if (playerInventory.Contains("blue key"));
        {
            // do something
        }
    }
} 
//index count always starts with count 0