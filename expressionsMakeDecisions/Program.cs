// See https://aka.ms/new-console-template for more information

// dotnet --version 8.0.201

/***Use the following dotnet command to create your new folder directory:

        dotnet new console -o ./nameOfFolder/

    Use the following dotnet commands to build and run your application: 
    
        dotnet build
        dotnet run
***/

/*
This code uses the equality operator to evaluate the string data

*/
Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);

string myValue = "a";
Console.WriteLine(myValue == "a");

/*
Here a space character is added at the end of the string. This expression will output false.

In some cases, having a space character before or after the text might be perfectly acceptable. 
However, if you need to accept a match that isn't exact, you can "massage" the data first. 
"Massaging" the data means that you perform some cleanup before you perform a comparison for equality.

For example, consider the case when you're collecting user input inside a loop. After each value 
is entered, you could provide the user with a prompt to determine if they want to continue, such 
as Do you want to continue (Y/N)?. If the user wants to continue, they will probably enter either 
y or Y. You'll want your code to interpret both values equally, even though y isn't equivalent to Y.
*/

Console.WriteLine("a" == "a ");

/*
Before you check two string values for equality, especially when one or both values were entered by a user, you should:

    Make sure both strings are all upper-case or all lower-case using the ToUpper() or ToLower() helper method on any string value.
    Remove any leading or trailing blank spaces using the Trim() helper method on any string value.
*/

string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

/*
This code uses the inequality operator to evaluate the string data, though outputs the opposite of what you saw when using the equality 
operator. That means that your code will branch in the opposite manner as well, which can be exactly what you want.

*/

Console.WriteLine("a" != "a");
Console.WriteLine("a" != "A");
Console.WriteLine(1 != 2);

string myValue = "a";
Console.WriteLine(myValue != "a");

/*
When evaluating comparisons with numeric data types, you might want to determine if a value is larger or smaller than another value. 
Use the following operators to perform these types of comparisons:

    Greater than >
    Less than <
    Greater than or equal to >=
    Less than or equal to <=
*/

Console.WriteLine(1 > 2);
Console.WriteLine(1 < 2);
Console.WriteLine(1 >= 1);
Console.WriteLine(1 <= 1);

/*
This code logic uses a built-in method of the String class to determine whether or 
not a larger string contains a specific word or phrase that's significant to your 
application.
*/

string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));

/*
The inequality operator != includes a ! character, but should not be confused with logical negation. The inequality operator 
returns true if its operands aren't equal, and returns false if the operands are equal. For the operands of the built-in 
types, the expression x != y produces the same result as the expression !(x == y) (an example of logical negation).
*/

int a = 7;
int b = 6;
Console.WriteLine(a != b); // output: True
string s1 = "Hello";
string s2 = "Hello";
Console.WriteLine(s1 != s2); // output: False


/* KEY TIPS
    1.There are many different kinds of expressions that evaluate to either true or false.
    2.Evaluate equality using the == operator.
    3.Evaluating equality of strings requires you to consider the possibility that the strings have different case and leading or 
      trailing spaces. Depending on your situation, use the ToLower() or ToUpper() helper methods, and the Trim() helper method to 
      improve the likelihood that two strings are equal.
    4.Evaluate inequality using the != operator.
    5.Evaluate greater than, less than and similar operations using comparison operators like >, <, >=, and <=.
    6.If a method returns a bool, it can be used as a Boolean expression.
    7.Use the logical negation operator ! to evaluate the opposite of a given expression.
*/


/*
Consider how you'd apply the conditional operator ?: to a promotional discount scenario, using pseudo.
*/

<evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>

/*
The conditional operator ?: evaluates a Boolean expression and returns one of two results depending on whether the Boolean expression 
evaluates to true or false. The conditional operator is commonly referred to as the ternary conditional operator.
*/

int saleAmount = 1001;
int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {discount}");

/*
Using the conditional operator inline:

This code logic wraps the entire conditional operator statement in parentheses. The parentheses ensure that the runtime understands the 
intent, which is to display the conditional result rather than the result of evaluating the condition (saleAmount > 1000).
*/

int saleAmount = 1001;
// int discount = saleAmount > 1000 ? 100 : 50;

Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

/* KEY TIPS

    You can use the conditional operator to reduce the size of your code, but you should ensure that the resulting code is easily readable.
    You can use the conditional operator when you need to return a value that's based on a binary condition. Your code will return the first 
    option when the condition evaluates to true, and it will return the second option when the condition evaluates to false.
*/

