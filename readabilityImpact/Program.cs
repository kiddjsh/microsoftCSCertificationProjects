// See https://aka.ms/new-console-template for more information

// dotnet --version 8.0.201

/*Use the following dotnet command to create your new folder directory:

        dotnet new console -o ./nameOfFolder/

    Use the following dotnet commands to build and run your application: 
    
        dotnet build
        dotnet run
*/


/*SINGLE-LINE FORM IF STATEMENTS
When implementing an if statement that includes a single-statement code block, Microsoft recommends that you consider these conventions:

    1.Never use single-line form (for example: if (flag) Console.WriteLine(flag);
    2.Using braces is always accepted, and required if any block of an if/else if/.../else compound statement uses braces or if a single 
      statement body spans multiple lines.
    3.Braces may be omitted only if the body of every block associated with an if/else if/.../else compound statement is placed on a single line.

*/

bool flag = true;
if (flag) Console.WriteLine(flag);


/*LARGER IF-ELSEIF-ELSE CONSTRUCTS
The lines of code here are dense and hard to read. 
Reformat the code to include a line break after the if, else if, and else statements.
*/

string name = "steve";
if (name == "bob") Console.WriteLine("Found Bob");
else if (name == "steve") Console.WriteLine("Found Steve");
else Console.WriteLine("Found Chuck");


/*REFORMATTED READABILITY*/

string name = "steve";

if (name == "bob")
    Console.WriteLine("Found Bob");
else if (name == "steve") 
    Console.WriteLine("Found Steve");
else
    Console.WriteLine("Found Chuck");

/*KEY TIPS

    If you realize you have only one line of code listed within the code blocks of an if-elseif-else statement, 
    you can remove the curly braces of the code block and white space. Microsoft recommends that curly braces 
    be used consistently for all of the code blocks of an if-elseif-else statement (either present or removed 
    consistently).
    Only remove the curly braces of a code block when it makes the code more readable. It's always acceptable 
    to include curly braces.
    Only remove the line feed if it makes the code more readable. Microsoft suggests that your code will be more 
    readable when each statement is placed on its own code line.
*/
