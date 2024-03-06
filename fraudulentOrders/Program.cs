// See https://aka.ms/new-console-template for more information
// dotnet --version 8.0.201

/***Use the following dotnet command to create your new folder directory:

        dotnet new console -o ./nameOfFolder/

    Use the following dotnet commands to build and run your application: 
    
        dotnet build
        dotnet run
***/


/***first set of square brackets [] merely tells the compiler that the variable named fraudulentOrderIDs is an array, 
    second set of square brackets [3] indicates the number of elements that the array can hold***/

//declares a new array
//string[] fraudulentOrderIDs = new string[3];

/***accesses an element of an array, using a numeric zero-based index inside of square brackets***/

//assigns values to elements 
//fraudulentOrderIDs[0] = "A123";
//fraudulentOrderIDs[1] = "B456";
//fraudulentOrderIDs[2] = "C789";
//fraudulentOrderIDs[3] = "D000";


//updated to initialize an array
string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

//retrieves values from array and prints accordingly
Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

//reassigns the value of array
fraudulentOrderIDs[0] = "F000";

//retrieves values from array and prints accordingly
Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");
