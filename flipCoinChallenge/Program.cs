// See https://aka.ms/new-console-template for more information

// dotnet --version 8.0.201

/*Use the following dotnet command to create your new folder directory:

        dotnet new console -o ./nameOfFolder/

    Use the following dotnet commands to build and run your application: 
    
        dotnet build
        dotnet run
*/

/*
This code logic implement a conditional operator to simulate a "coin flip". 
The resulting decision logic will display either heads or tails.
*/

Random coin = new Random();
int flip = coin.Next(0, 2);
Console.WriteLine((flip == 0) ? "heads" : "tails");
