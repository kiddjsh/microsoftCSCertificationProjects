// See https://aka.ms/new-console-template for more information

// dotnet --version 8.0.203

/***Use the following dotnet command to create your new folder directory:

        dotnet new console -o ./nameOfFolder/

    Use the following dotnet commands to build and run your application: 
    
        dotnet build
        dotnet run
***/

/*Create code to print a receipt for the customer purchasing shares of an investment 
  product. The shares are purchased automatically at the end of the year based on a 
  series of payroll deductions, so the number of shares purchased usually contains a 
  decimal amount. To print the receipt, you would likely need to combine data of 
  different types, including fractional values, currency, and percentages in precise 
  ways.
*/

int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"   Shares: {productShares:N3} Product");
Console.WriteLine($"     Sub Total: {subtotal:C}");
Console.WriteLine($"           Tax: {taxPercentage:P2}");
Console.WriteLine($"     Total Billed: {total:C}");

