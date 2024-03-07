// See https://aka.ms/new-console-template for more information

// dotnet --version 8.0.201

/*Use the following dotnet command to create your new folder directory:

        dotnet new console -o ./nameOfFolder/

    Use the following dotnet commands to build and run your application: 
    
        dotnet build
        dotnet run
*/

/*
This variable scope challenge is to update code blocks and variable scopes to fix a poorly written code sample.
Complete code updates required in adjusting variable scopes as needed, and with Console.WriteLine() statements 
to produce the desired output, while also optimizing the code for readability. You should have around 17 lines
of code depending on condensing whitespace and other factors.

The biggest changes to the problematic code included:

    Moving the declaration of the total and found variables outside of the foreach statement.
    Initializing both the total and found variables with sensible default values.
    Removing the code blocks (curly braces) from the if statements.
*/

int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;
bool found = false;

foreach (int number in numbers)
{
    total += number;
    if (number == 42)
        found = true;
}

if (found)
    Console.WriteLine("Set contains 42");

Console.WriteLine($"Total: {total}");
