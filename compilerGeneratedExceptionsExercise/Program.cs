// See https://aka.ms/new-console-template for more information

// dotnet --version 8.0.203

/***Use the following dotnet command to create your new folder directory:

        dotnet new console -o ./nameOfFolder/

    Use the following dotnet commands to build and run your application: 
    
        dotnet build
        dotnet run
***/

/*Compiler-generated exceptions
  The .NET runtime throws exceptions when basic operations fail. Here's a short list of runtime exceptions and their error conditions:

    ArrayTypeMismatchException: Thrown when an array can't store a given element because the actual type of the element is 
    incompatible with the actual type of the array.
    DivideByZeroException: Thrown when an attempt is made to divide an integral value by zero.
    FormatException: Thrown when the format of an argument is invalid.
    IndexOutOfRangeException: Thrown when an attempt is made to index an array when the index is less than zero or outside 
    the bounds of the array.
    InvalidCastException: Thrown when an explicit conversion from a base type to an interface or to a derived type fails 
    at runtime.
    NullReferenceException: Thrown when an attempt is made to reference an object whose value is null.
    OverflowException: Thrown when an arithmetic operation in a checked context overflows.
*/


string[] names = { "Dog", "Cat", "Fish" };
Object[] objs = (Object[])names;

Object obj = (Object)13;
objs[2] = obj; // ArrayTypeMismatchException occurs


int number1 = 3000;
int number2 = 0;
Console.WriteLine(number1 / number2); // DivideByZeroException occurs


int valueEntered;
string userValue = "two";
valueEntered = int.Parse(userValue); // FormatException occurs


int[] values1 = { 3, 6, 9, 12, 15, 18, 21 };
int[] values2 = new int[6];

values2[values1.Length - 1] = values1[values1.Length - 1]; // IndexOutOfRangeException occurs


object obj = "This is a string";
int num = (int)obj; // InvalidCastException occurs


int[] values = null; // NullReferenceException occurs
for (int i = 0; i <= 9; i++)
    values[i] = i * 2; 


string? lowCaseString = null; // NullReferenceException occur
Console.WriteLine(lowCaseString.ToUpper());


decimal x = 400;
byte i;

i = (byte)x; // OverflowException occurs
Console.WriteLine(i);



