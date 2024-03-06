// See https://aka.ms/new-console-template for more information

// dotnet --version 8.0.201

/***Use the following dotnet command to create your new folder directory:

        dotnet new console -o ./nameOfFolder/

    Use the following dotnet commands to build and run your application: 
    
        dotnet build
        dotnet run
***/

/*
creates and initializes an array that stores the number of 
finished products in each bin
*/
int[] inventory = { 200, 450, 700, 175, 250 };

//sums the value of each element in the array
int sum = 0;
//stores the number of the bin whose inventory is currently being processed
int bin = 0;

/*
added foreach to iterate through array that temporarily assigns 
the value of the current array element to an int variable named 
items
*/
foreach (int items in inventory)
{
    //adds the current value stored in items to the sum variable
    sum += items;
    //increments the value of the variable by 1
    bin++;
    //reports the current state of the inventory using the counter variable bin, the temporary foreach variable items, and the sum variable
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}
//reports the final sum of items in the inventory
Console.WriteLine($"We have {sum} items in inventory.");
