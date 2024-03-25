// See https://aka.ms/new-console-template for more information

// dotnet --version 8.0.203

/***Use the following dotnet command to create your new folder directory:

        dotnet new console -o ./nameOfFolder/

    Use the following dotnet commands to build and run your application: 
    
        dotnet build
        dotnet run
***/


/*
You're asked to build an application that will convert data in the relational 
database management system to the legacy file format. To ensure that the 
integration works correctly, the first step is to confirm the file format by 
giving the legacy system maintainers a sample of the output. Later, you build 
on this work to send hundreds or thousands of payments to be processed via an 
ASCII text file.
*/


string paymentId = "769C";
 string payeeName = "Mr. Stephen Ortega";
 string paymentAmount = "$5,000.00";

 var formattedLine = paymentId.PadRight(6);
 formattedLine += payeeName.PadRight(24);
 formattedLine += paymentAmount.PadLeft(10);

 Console.WriteLine("1234567890123456789012345678901234567890");
 Console.WriteLine(formattedLine);

/*
There's a few important takeaways from this unit.

The string data type, literal strings, and variables of type string each implement many helper methods to format, modify, and perform other operations on strings.
The PadLeft() and PadRight() methods add white space (or optionally, another character) to the total length of a string.
Use PadLeft() to right-align a string.
Some methods are overloaded, meaning they have multiple versions of the method with different arguments that affect their functionality.
The += operator concatenates a new string on the right to the existing string on the left.
*/








/*
A brief list of categories of these built-in methods so you can get an idea of what's possible.

Methods that add blank spaces for formatting purposes (PadLeft(), PadRight())
Methods that compare two strings or facilitate comparison (Trim(), TrimStart(), TrimEnd(), GetHashcode(), the Length property)
Methods that help you determine what's inside of a string, or even retrieve just a part of the string (Contains(), StartsWith(), EndsWith(), Substring())
Methods that change the content of the string by replacing, inserting, or removing parts (Replace(), Insert(), Remove())
Methods that turn a string into an array of strings or characters (Split(), ToCharArray())
*/
