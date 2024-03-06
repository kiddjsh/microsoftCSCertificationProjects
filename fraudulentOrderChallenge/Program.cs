// See https://aka.ms/new-console-template for more information

// dotnet --version 8.0.201

/***Use the following dotnet command to create your new folder directory:

        dotnet new console -o ./nameOfFolder/

    Use the following dotnet commands to build and run your application: 
    
        dotnet build
        dotnet run
***/

/*
Your team has found a pattern. Orders that start with the letter "B" encounter fraud at a rate 25 times greater than the normal rate. 
You write new code that outputs the Order ID of new orders where the Order ID starts with the letter "B". This will be used by the 
fraud team to investigate further.
*/

string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach (string orderID in orderIDs)
{
    if (orderID.StartsWith("B"))
    {
        Console.WriteLine(orderID);
    }
}
