// See https://aka.ms/new-console-template for more information


// dotnet --version 8.0.203

/***Use the following dotnet command to create your new folder directory:

        dotnet new console -o ./nameOfFolder/

    Use the following dotnet commands to build and run your application: 
    
        dotnet build
        dotnet run
***/


//calling a method
int[] a = {1,2,3,4,5};

Console.WriteLine("Contents of Array:");
PrintArray();

void PrintArray()
{
    foreach (int x in a)
    {
        Console.Write($"{x} ");
    }
    Console.WriteLine();
}



//method execution
Console.WriteLine("Before calling a method, create the world");
SayHello();
Console.WriteLine("After calling a method, destroy the world");

void SayHello() 
{
    Console.WriteLine("Say Hello!");
}



//best practices
void ShowData(string a, int b, int c);
void DisplayDate(string month, int day, int year);