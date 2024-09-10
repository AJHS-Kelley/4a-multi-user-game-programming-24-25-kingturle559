using System;
class Template {
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
    Console.WriteLine("The greeting is longer than the goodbye.\n")
  }

  //useful sting Methods

  Console.WriteLine(greeting.ToUpper());// Make entire string UPPERCASE
  Console.WriteLine(greeting.ToUpper());// Make entire string lowercase


  }
}