// See https://aka.ms/new-console-template for more information

// dotnet --version 8.0.203

/***Use the following dotnet command to create your new folder directory:

        dotnet new console -o ./nameOfFolder/

    Use the following dotnet commands to build and run your application: 
    
        dotnet build
        dotnet run
***/


/**

//--Attempts to add an int and a 
    string and save the result in an int--//
int first = 2;
string second = "4";
int result = first + second;
Console.WriteLine(result);


//--Attempts to change the value's data 
    type without a loss of information--//
int myInt = 3;
Console.WriteLine($"int: {myInt}");

decimal myDecimal = myInt;
Console.WriteLine($"decimal: {myDecimal}");


//--Performs a cast--//
decimal myDecimal = 3.14m;
Console.WriteLine($"decimal: {myDecimal}");

int myInt = (int)myDecimal;
Console.WriteLine($"int: {myInt}");


//--Attempts to convert a value from a data 
    type that can hold more information to 
    a data type that can hold less information--//
decimal myDecimal = 1.23456789m;
float myFloat = (float)myDecimal;

Console.WriteLine($"Decimal: {myDecimal}");
Console.WriteLine($"Float  : {myFloat}");


//--Uses ToString() to convert a number to a
                                            string--//
int first = 5;
int second = 7;
string message = first.ToString() + second.ToString();
Console.WriteLine(message);


//--Uses Parse() helper method to convert a
                                           string to an int--//
string first = "5";
string second = "7";
int sum = int.Parse(first) + int.Parse(second);
Console.WriteLine(sum);


//--Uses Convert class to convert a string to a int--//
string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result);

//--

**/


//--casting and converting a decimal into an int--//
int value = (int)1.5m; // casting truncates
Console.WriteLine(value);

int value2 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value2);
