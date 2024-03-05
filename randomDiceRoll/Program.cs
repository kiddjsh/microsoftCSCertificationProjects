// See https://aka.ms/new-console-template for more information
// dotnet --version 8.0.201

/***Use the following dotnet command to create your new folder directory:

        dotnet new console -o ./nameOfFolder/

    Use the following dotnet commands to build and run your application: 
    
        dotnet build
        dotnet run
***/

/***creates System.Random class and stores a 
    reference to the object in a variable named dice***/
Random dice = new Random();

/***calls the Random.Next() method on the dice object three times providing both the lower and upper bounds to restrict the possible values between 1 
    and 6, saving the three random numbers in the variables roll1, roll2, and roll3***/
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

/***sums the three dice rolls and saves the value into an integer variable named total***/
int total = roll1 + roll2 + roll3;

/***calls the WriteLine() method to display the three values using string interpolation***/
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

/***updated to nesting to create an inner if-else construct to fix a subtle 
    logic bug, where the two outcomes are related opposites, then use a 
    opposing outcomes (if/true and else/false) to award the bonus points for
    triples and doubles***/ 
/***combines three boolean expressions defined by double pipe characters to create one composite boolean expression in a single line of code, or a compound condition; 
    double pipes indicate either the expression to the left OR the right must be true in order for the entire expression to be true; evaluates first expression, if 
    true, entire expression true, if false, evaluates second expression, if false, evaluates third***/
if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{   
    /***combines two boolean expressions defined by double ampersand characters to create one composite boolean expression in a single line of code, or a compound 
        condition; double ampersands indicate only if both expressions are true, then the entire expression is true, in order for the entire expression to be true
        then all three dice must be equal to each other***/
    if ((roll1 == roll2) && (roll2 == roll3)) 
    {
    // if triples detected print and add six points to total
    Console.WriteLine("You rolled triples! +6 bonus to total!");
    total += 6;
    }
    else
    {
    // if doubles detected print and add two points to total
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total += 2;
    }
    // prints total + bonus 
    Console.WriteLine($"Your total including the bonus: {total}");
}
/***if ((roll1 == roll2) && (roll2 == roll3)) 
{
    // if triples detected print and add six points to total
    Console.WriteLine("You rolled triples! +6 bonus to total!");
    total += 6;
}***/

/***if total is greater than or equal to 
    15 then executes code block "You Win!"***/
/***if (total >= 15)
{
    Console.WriteLine("You win!");
}***/
/***if total is less than 15 then executes 
    code block "Sorry, you lose."***/
/***if (total < 15)
{
    Console.WriteLine("Sorry, you lose.");
}***/

/***if total is greater or equal to 15 then 
    executes code block "You win a new car!"***/
if (total >= 16)
{
    Console.WriteLine("You win a new car!");
}
/***if total is greater or equal to 10 then 
    executes code block "You win a new laptop!"***/
else if (total >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
/***if total is equal to 7 then executes code 
    block "You win a trip for two!"***/
else if (total == 7)
{
    Console.WriteLine("You win a trip for two!");
}
else 
{
    Console.WriteLine("Sorry, you lose.");
}
