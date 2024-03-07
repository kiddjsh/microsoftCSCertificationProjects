// See https://aka.ms/new-console-template for more information

/* dotnet --version 8.0.201

    Use the following dotnet command to create your new folder directory:

        dotnet new console -o ./nameOfFolder/

    Use the following dotnet commands to build and run your application: 
    
        dotnet build
        dotnet run
*/

/*
   This code reverses a message, counts the number of times 
   a particular character appears, then prints the results
   to the console window.
 */

string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] message = originalMessage.ToCharArray();
Array.Reverse(message);

int letterCount = 0;

foreach (char letter in message)
{
    if (letter == 'o')
    {
        letterCount++;
    }
}

string newMessage = new String(message);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {letterCount} times.");


/*HIGHLIGHTS
    1.This code includes a higher-level description of what the entire code listing is attempting to accomplish in a multi-line comment at the top. 
    2.The individual comments were removed because they weren't providing any real insight into the code's purpose or function.
    3.Several blank lines were added to improve the phrasing of the code listing.
    4.Line feeds and tabs were added to improve the appearance of the foreach statement and the if statement.
    5.Local variable naming conventions were applied to better convey the purpose of each value.
*/
