// See https://aka.ms/new-console-template for more information

// dotnet --version 8.0.201

/***This code simulates a dice roll using the Random.Next() method to generate a number, 
    and the Console.WriteLine() method to display the value.
   
    Use the following dotnet commands to build and run your application: 
    
        dotnet build
        dotnet run
***/

//Random dice = new Random();
//int roll = dice.Next(1, 7);
//Console.WriteLine(roll);
//Console.WriteLine(dice.Next(1, 7));

//int number = 7;
//string text = "seven";
//Console.WriteLine(number);
//Console.WriteLine();
//Console.WriteLine(text);

Random dice = new Random();
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");

