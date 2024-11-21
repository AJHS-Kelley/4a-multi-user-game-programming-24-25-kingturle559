//Data Types Operators, Charles Massey, v0.0
using System;

class DataTypesOperators {
  static void Main() {
// this is a comment, it gets ignored

/*
this is still a comment
*/

//DATA TYPES
//c# is statically typed-- once a variable has a data type, it cannot change

//float - float-- decimal numbers, +/- including 0.0

// Double - couble -- decimal numbers, +/-, including 0.0 <-- most commonly used decimal

// Integers - int -- whole numbers, +/-, including 0

// VARIABLES ARE 'BUCKETS' WITH A NAME TO STORE DATA INSIDE

//DECLARING (CREATING VARIABLES)
//METHOD #1 -- Declared but not assign
//dataType variableName;

int myInteger;
double myDouble;

// method #2 -- declare and assign
int myInteger2 = 1;
double myDouble2 = 2.05D;

//strings -- collections of letters, numbers, special characters.
string mystring ="this is my string";

//boolean -- bool - True or False
bool mybool = true;
bool fireResistance = true;
bool hasPurpleKey = false;

//character --char -- a single character.
char myChar = 'A';

//ASSIGNING VALUES AFTER DECLARATION

int myInteger = 5;
bool myBool = 69;
double myDouble = 74;
string string = 87;

//PRINTING VARIABLES TO THE CONSOLE TERMINAL
Console.WriteLine(myinteger);
Console.WriteLine(myDouble);
//PRINTING VARIABLES TO THE CONSOLE TERMINAL
Console.WriteLine( myinteger -25);
Console.WriteLine(myDouble + 2.5);
//PRINTING VARIABLES TO THE CONSOLE TERMINAL
Console.WriteLine(myinteger);
Console.WriteLine(myDouble);

//operators -- arithmetic

int myNewInt = myInteger + myinteger2;
double myNewDouble = myDouble + myDouble2;

double myNewNumber = myInteger + myDouble;

//addition
int myNewInt = myInteger + myinteger2;

//subtraction
myNewNumber = myDouble - myInteger;

//division
myNewNumber = myDouble / myInteger;

//MULTIPLICATION
myNewNumber = myDouble * myInteger;

//Modulus -- Divides, then returns the remainder
//most commonly used t odetermine even or odd
myNewNumber = myDouble % 2;

int students = 6;
int numslices = 35;
int leftovers;

leftovers = numslices % students;

//Increment / Decrement -- most frequently used in loops
int x = 0;
x++; // what is x equal to now
//Increment ++ adds 1 to the current value and puts the new value into the bucket
x-- ;
//Decrement -- subtracts 1 from the current value and puts the new value into the bucket

//special assignment operators
x += 1;
x *= 1;
x /= 1;
x -= 1;
x %= 1;
// take current value, perform the calculation, put new value into bucket

//comparison operators
//evalutate the expression, return true or false
int y = 5;
int z = 3;

//is-equal -to == si the value on the left equal to the right

//logical not ! -- Returns the opposite value of the expression. 
console.WriteLine(b > -1);
//is-equal -to == si the value on the left equal to the right
console.WriteLine(y == z);
//not-equal-to != is the value on the left not equal to the right?
console.WriteLine(y != z);

//greater than >
console.WriteLine(y > z);
//less than <
console.WriteLine(y < z);
//greater than-or-equal-to >=
console.WriteLine(y >= z);
//less than-or-equal-to <=
console.WriteLine(y <= z);


//// logical not ! -- returns the oppostite value of the expression.
console.WriteLine(b > -1);
console.WriteLine(!(b > -1)); // flase
  }