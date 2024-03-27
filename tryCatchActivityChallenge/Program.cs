// See https://aka.ms/new-console-template for more information

// dotnet --version 8.0.203

/*Use the following dotnet command to create your new folder directory:

        dotnet new console -o ./nameOfFolder/

    Use the following dotnet commands to build and run your application: 
    
        dotnet build
        dotnet run
*/


try
{
    Process1();
}
catch
{
    Console.WriteLine("An exception has occurred");
}

Console.WriteLine("Exit program");

static void Process1()
{
    try
    {
        WriteMessage();
    }
    catch
    {
        Console.WriteLine("Exception caught in Process1");
    }

}

static void WriteMessage()
{
    double float1 = 3000.0;
    double float2 = 0.0;
    int number1 = 3000;
    int number2 = 0;

    Console.WriteLine(float1 / float2);
    Console.WriteLine(number1 / number2);
}
