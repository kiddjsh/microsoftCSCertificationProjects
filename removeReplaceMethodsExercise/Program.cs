// See https://aka.ms/new-console-template for more information


// dotnet --version 8.0.203

/***Use the following dotnet command to create your new folder directory:

        dotnet new console -o ./nameOfFolder/

    Use the following dotnet commands to build and run your application: 
    
        dotnet build
        dotnet run
***/


/*This exercise has data stored in older files having a fixed length, and with character 
  positions allocated for certain fields of information. The first five digits represent 
  a customer identification number. The next 20 digits contain a customer's name. The 
  next six positions represent the customer's latest invoice amount, and the last three 
  positions represent the number of items ordered on that invoice.

  In the following steps, you need to remove the customer's name to format the data so 
  that it can be sent to a separate process. Since you know the exact position and length 
  of the user's name, you can easily remove it using the Remove() method.
*/


//Removes characters in specific locations from a string
string data = "12345John Smith          5000  3  ";
string updatedData = data.Remove(5, 20);
Console.WriteLine(updatedData);


//Remove characters no matter where they appear in a string
string message = "This--is--ex-amp-le--da-ta";
message = message.Replace("--", " ");
message = message.Replace("-", "");
Console.WriteLine(message);


/*Here are two important things to remember:

  The Remove() method works like the Substring() method, except that it deletes the specified characters in the string.
  The Replace() method swaps all instances of a string with a new string.
*/