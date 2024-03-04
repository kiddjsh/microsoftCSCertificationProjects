// See https://aka.ms/new-console-template for more information

// dotnet --version 8.0.201

/***Code challenge: Implement a method of the Math class that returns the larger of two numbers***/

/***Find a method of the System.Math class that returns the larger of two numbers.

    You can use either Visual Studio Code "Intellisense" or learn.microsoft.com to 
    find the method and determine how to call it properly.

    Use the method that you found to assign a value to the variable named largerValue.

    You should be able to pass the two integer values, firstValue and secondValue, to 
    the method that you found. The method should return a value of type int that 
    represents the larger of the two arguments that you passed it.

    You can assign the return value to largerValue on a new code line or on the existing 
    code line that's used to declare largerValue.
    
    Use the following dotnet commands to build and run your application: 
    
        dotnet build
        dotnet run
***/


int firstValue = 500;
int secondValue = 600;
int largerValue;
largerValue = Math.Max(firstValue, secondValue);
Console.WriteLine(largerValue);
