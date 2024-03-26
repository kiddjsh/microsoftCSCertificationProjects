// See https://aka.ms/new-console-template for more information


// dotnet --version 8.0.203

/***Use the following dotnet command to create your new folder directory:

        dotnet new console -o ./nameOfFolder/

    Use the following dotnet commands to build and run your application: 
    
        dotnet build
        dotnet run
***/

/* 
This code uses a names array and corresponding methods to display
greeting messages
*/

string[] names = new string[] { "Sophia", "Andrew", "AllGreetings" };

string messageText = "";

foreach (string name in names)
{
    if (name == "Sophia")
        messageText = SophiaMessage();
    else if (name == "Andrew")
        messageText = AndrewMessage();
    else if (name == "AllGreetings")
        messageText = SophiaMessage();
        messageText = messageText + "\n\r" + AndrewMessage();

    Console.WriteLine(messageText + "\n\r");
}

bool pauseCode = true;
while (pauseCode == true);

static string SophiaMessage()
{
    return "Hello, my name is Sophia.";
}

static string AndrewMessage()
{
    return "Hi, my name is Andrew. Good to meet you.";
}
