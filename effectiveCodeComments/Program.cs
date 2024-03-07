// See https://aka.ms/new-console-template for more information

// dotnet --version 8.0.201

/***Use the following dotnet command to create your new folder directory:

        dotnet new console -o ./nameOfFolder/

    Use the following dotnet commands to build and run your application: 
    
        dotnet build
        dotnet run
***/

/*
Notice that the code comments are used to document the potential change being made, and to temporarily disable the old message as you test the new message. 
Your next step will be to test your update. If you're satisfied with the new code, you can safely delete the old code that was commented out. This is a 
safer, more methodical approach to modifying working code until you're convinced that you're ready to permanently remove it.

Block comments are great if you need to write a long comment or remove many lines of code. Using a block comment is the quickest and easiest way to disable 
three or more lines of code.
*/

string firstName = "Bob";
int widgetsPurchased = 7;
/* 
Testing a change to the message.
int widgetsSold = 7;
Console.WriteLine($"{firstName} sold {widgetsSold} widgets.");
*/
Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets.");

/* TIP # 1
In the code below, notice that there are two main problems with the comments:

    1.The code comments unnecessarily explain the obvious functionality of individual lines of code. These are considered low-quality 
      comments because they merely explain how C# or methods of the .NET Class Library work. If the reader is unfamiliar with these 
      ideas, they can look them up using learn.microsoft.com or IntelliSense.
    2.The code comments don't provide any context to the problem being solved by the code. These are considered low-quality comments 
      because the reader doesn't gain any insight into the purpose of this code, especially as it relates to the larger system.
*/

Random random = new Random();
string[] orderIDs = new string[5];
// Loop through each blank orderID
for (int i = 0; i < orderIDs.Length; i++)
{
    // Get a random value that equates to ASCII letters A through E
    int prefixValue = random.Next(65, 70);
    // Convert the random value into a char, then a string
    string prefix = Convert.ToChar(prefixValue).ToString();
    // Create a random number, pad with zeroes
    string suffix = random.Next(1, 1000).ToString("000");
    // Combine the prefix and suffix together, then assign to current OrderID
    orderIDs[i] = prefix + suffix;
}
// Print out each orderID
foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}


/* TIP # 2
    Instead of structuring comments like outlined in the above code, 
    explain the higher-level purpose of your code as shown below:
/*
/* 
The following code creates five random OrderIDs
to test the fraud detection process.  OrderIDs 
consist of a letter from A to E, and a three
digit number. Ex. A123.
*/

Random random = new Random();
string[] orderIDs = new string[5];

for (int i = 0; i < orderIDs.Length; i++)
{
    int prefixValue = random.Next(65, 70);
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = random.Next(1, 1000).ToString("000");

    orderIDs[i] = prefix + suffix;
}

foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}


/* KEY TIPS

    Use code comments to leave meaningful notes to yourself about the problem your code solves.
    Don't use code comments that explain how C# or the .NET Class Library works.
    Use code comments when temporarily trying alternative solutions until you're ready to commit to the new code solution, at which point you can delete the old code.
    Never trust comments. They may not reflect the current state of the code after many changes and updates.
*/