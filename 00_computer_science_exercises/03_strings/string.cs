using System;
class String {
  static void Main() {
  //in C# ALL STRINGS MUST USE DOUBLE-QUOTES "  "
  string greeting = "HOW YOU DOIN?\n";
  string goodbye = "adios amigo\n";

  // In C# strings are treated like a n OBJECT that has properties and methods.
  //PROPERTIES -- things that describe the object such as length, values, data type, ect.
  //METHODS -- built in functions related to the object

  // Length is an important property fopr stings
  Console.WriteLine (greeting.Length);
  Console.WriteLine (goodbye.Length);

  if(greeting.Length > goodbye.Length)
  {
    Console.WriteLine("The greeting is longer than the goodbye.\n");
  }

  //useful sting Methods

  Console.WriteLine(greeting.ToUpper());// Make entire string UPPERCASE
  Console.WriteLine(greeting.ToUpper());// Make entire string lowercase

  //Sting Concatenation "con-cat-Uh-Nation"
  string comboString = greeting + goodbye;
  Console.WriteLine(comboString);

  //String concatenation Method #2
  string comboString2 = string.Concat(greeting, goodbye);
  Console.WriteLine(comboString2);

  //string interpolation -- substitution variables into strings.
  string comboString3 = $"My greeting is {greeting} and my goodbye is {goodbye}.\n";
  Console.WriteLine(comboString3);

  // Substituting variables into strings method 2
  Console.WriteLine("My greeeting is " + greeting + " and my goodbye is " + goodbye + "\n.");

  // Accessing Parts of Strings
  // index is a specific location of a character in a string
  // ALL string indexes start at 0
  Console.WriteLine(goodbye[0]); // Print the character at index0.
  Console.WriteLine(goodbye[4]); // Replace x wiht what to print the 5th character?
  // Where is it in my string?
  Console.WriteLine(greeting.IndexOf("y"));




  }
}