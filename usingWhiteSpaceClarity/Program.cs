// See https://aka.ms/new-console-template for more information

// dotnet --version 8.0.201

/***Use the following dotnet command to create your new folder directory:

        dotnet new console -o ./nameOfFolder/

    Use the following dotnet commands to build and run your application: 
    
        dotnet build
        dotnet run
***/

/* EXAMPLE 1 & 2
Consider what the code below tells you about how you should use whitespace in your code.

These two code examples illustrate two vital ideas:

    Whitespace doesn't matter to the compiler. However ...
    Whitespace, when used properly, can increase your ability to read and comprehend the code.

You likely write your code once, but need to read the code multiple times. Therefore, you should focus on the readability of the code you write. 
Over time, you'll get a feel for when and how to use whitespace, such as the space character, tabs, and new lines.

Early guidance:

    1.Each complete command (a statement) belongs on a separate line.
    2.If a single line of code becomes long, you can break it up. However, you should avoid arbitrarily splitting up a single statement to multiple 
      lines until you have a good reason to do so.
    3.Use a space to the left and right of the assignment operator.
*/

// Example 1:
Console
.
WriteLine
(
"Hello Example 1!"
)
;

// Example 2:
string firstWord="Hello";string lastWord="Example 2";Console.WriteLine(firstWord+" "+lastWord+"!");


/* EXAMPLE 3
This code doesn't include much whitespace. This code will be used to illustrate an approach for adding whitespace to your applications. 
Effective whitespace should make it easier to understand what your code is doing.

There are two features of this code to take note of:

    There's no vertical whitespace in this code example. In other words, there's no empty lines separating the lines of code. It all runs together into one dense code listing.
    The code blocks as defined by the opening and closing curly brace symbols { } are compressed together, making their boundaries difficult to visually discern.
*/

//Example 3:
Random dice = new Random();
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);
int total = roll1 + roll2 + roll3;
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");
if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) {
    if ((roll1 == roll2) && (roll2 == roll3)) {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6; 
    } else {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}

/* EXAMPLE 4
To add vertical whitespace that improves readability: 

    The first line of whitespace is used to separate the declaration of the dice variable from the code lines used to assign values to your roll variables. 
    This separation makes it easier to see how dice is being used in your code.

    The next line of whitespace separates the declaration of your roll variables from the declaration of total. Grouping the declaration of your three roll 
    variables is helpful in two ways. First, it creates a group of code lines that includes related variables. Second, the variable names are so similar 
    and the declaration follows the same pattern. So, grouping them together draws your eye to the similarities and helps to expose the differences.

    The third line of whitespace separates another group of related statements from your nested if statements. The group of statements that includes the 
    declaration of total and the Console.WriteLine() method is related by purpose rather than appearance. Your code is focused on the total value achieved 
    by the three dice and whether the roll included doubles or triples. These lines are related because you need to calculate total and report the results 
    of the roll to the user.
*/

// Example 4:
Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) {
    if ((roll1 == roll2) && (roll2 == roll3)) {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6; 
    } else {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}


/* EXAMPLE 5
Considering curly brackets:
    
    Move the opening and closing curly braces to their own line to improve spacing.

    The { and } symbols create code blocks. Many C# constructs require code blocks. These symbols should be placed on a separate line so 
    that their boundaries are clearly visible and readable.

    It's important to use the tab key to line up the code block symbols under the keyword they belong to. For example, notice the line of 
    code that starts with the keyword if. Below that line is the { symbol. This alignment makes it easy to understand that the { "belongs 
    to" the if statement. Furthermore, the last } symbol lines up with the if statement as well. The combination of alignment and 
    indentation makes it easy to understand where the code block begins and ends.

    The code lines inside of this code block are indented, indicating that they "belong" to this code block.
*/

// Example 5:
Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) 
{
    if ((roll1 == roll2) && (roll2 == roll3)) 
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6; 
    } 
    else 
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}

/* KEY TIPS
    Use whitespace judiciously to improve the readability of your code.
    Use line feeds to create empty lines to separate phrases of code. A phrase includes lines of code that are similar, or work together.
    Use line feeds to separate code block symbols so that they are on their own line of code.
    Use the tab key to line up a code block with the keyword they're associated with.
    Indent code inside of a code block to show ownership.
*/