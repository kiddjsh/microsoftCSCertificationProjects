// See https://aka.ms/new-console-template for more information


// dotnet --version 8.0.203

/***Use the following dotnet command to create your new folder directory:

        dotnet new console -o ./nameOfFolder/

    Use the following dotnet commands to build and run your application: 
    
        dotnet build
        dotnet run
***/

/*Develop a small mini-game, and establish the basics of the game to include updating player state, manipulating player movement, 
  and consuming and regenerating a food object. The following features, and sub-features must be included in the game design:

  []Create code to support an option to terminate the gameplay if a nondirectional character is entered. You also want to terminate 
    the game if the terminal window was resized. You need to locate the correct methods for your code to use.

    Terminate on resize
    This feature must:

        Determine if the terminal was resized before allowing the game to continue
        Clear the Console and end the game if the terminal was resized
        Display the following message before ending the program: Console was resized. Program exiting.

    Add optional termination

        Modify the existing Move method to support an optional parameter
        If enabled, the optional parameter should detect nondirectional key input
        If nondirectional input is detected, allow the game to terminate

  []Create a method that determines if the player has consumed the food that was displayed. If the food was consumed, you want to 
    update the player's appearance and redisplay the food.

    Check if the player consumed the food

        Create a method that uses the existing position variables of the player and food
        The method should return a value
        After the user moves the character, call your method to determine the following:
            Whether or not to use the existing method that changes player appearance
            Whether or not to use the existing method to redisplay the food

  []Create a method that determines if the player has consumed the food that affects their movement. When the player consumes the 
    food string with value #####, the appearance is updated to (X_X). You'll add a feature to detect if the player appearance is 
    (X_X), and if so, temporarily prevent the player from moving.

    Add an optional feature that detects if the player appearance is (^-^) and if so, increase or decrease the right and left 
    movement speeds by a value of 3 while that appearance is active. When the player state is ('-'), you want the speed to 
    return to normal. You want to make this feature optional since consuming food in this state requires more collision detection 
    than you want to develop for now.

    Check if the player should freeze

        Create a method that checks if the current player appearance is (X_X)
        The method should return a value
        Before allowing the user to move the character, call your method to determine the following:
        Whether or not to use the existing method that freezes character movement
        Make sure the character is only frozen temporarily and the player can still move afterwards

    Add an option to increase player speed

        Modify the existing Move method to support an optional movement speed parameter
        Use the parameter to increase or decrease right and left movement speed by 3
        Create a method that checks if the current player appearance is (^-^)
        The method should return a value
        Call your method to determine if Move should use the movement speed parameter
*/



using System;

Random random = new Random();
Console.CursorVisible = false;
int height = Console.WindowHeight - 1;
int width = Console.WindowWidth - 5;
bool shouldExit = false;

// Console position of the player
int playerX = 0;
int playerY = 0;

// Console position of the food
int foodX = 0;
int foodY = 0;

// Available player and food strings
string[] states = {"('-')", "(^-^)", "(X_X)"};
string[] foods = {"@@@@@", "$$$$$", "#####"};

// Current player string displayed in the Console
string player = states[0];

// Index of the current food
int food = 0;

InitializeGame();
while (!shouldExit) 
{
    if (TerminalResized()) 
    {
        Console.Clear();
        Console.Write("Console was resized. Program exiting.");
        shouldExit = true;
    } 
    else 
    {
        if (PlayerIsFaster()) 
        {
            Move(1, false);
        } 
        else if (PlayerIsSick()) 
        {
            FreezePlayer();
        } else 
        {
            Move(otherKeysExit: false);
        }
        if (GotFood())
        {
            ChangePlayer();
            ShowFood();
        }
    }
}

// Returns true if the Terminal was resized 
bool TerminalResized() 
{
    return height != Console.WindowHeight - 1 || width != Console.WindowWidth - 5;
}

// Displays random food at a random location
void ShowFood() 
{
    // Update food to a random index
    food = random.Next(0, foods.Length);

    // Update food position to a random location
    foodX = random.Next(0, width - player.Length);
    foodY = random.Next(0, height - 1);

    // Display the food at the location
    Console.SetCursorPosition(foodX, foodY);
    Console.Write(foods[food]);
}

// Returns true if the player location matches the food location
bool GotFood() 
{
    return playerY == foodY && playerX == foodX;
}

// Returns true if the player appearance represents a sick state
bool PlayerIsSick() 
{
    return player.Equals(states[2]);
}

// Returns true if the player appearance represents a fast state
bool PlayerIsFaster() 
{
    return player.Equals(states[1]);
}

// Changes the player to match the food consumed
void ChangePlayer() 
{
    player = states[food];
    Console.SetCursorPosition(playerX, playerY);
    Console.Write(player);
}

// Temporarily stops the player from moving
void FreezePlayer() 
{
    System.Threading.Thread.Sleep(1000);
    player = states[0];
}

// Reads directional input from the Console and moves the player
void Move(int speed = 1, bool otherKeysExit = false) 
{
    int lastX = playerX;
    int lastY = playerY;
    
    switch (Console.ReadKey(true).Key) {
        case ConsoleKey.UpArrow:
            playerY--; 
            break;
		case ConsoleKey.DownArrow: 
            playerY++; 
            break;
		case ConsoleKey.LeftArrow:  
            playerX -= speed; 
            break;
		case ConsoleKey.RightArrow: 
            playerX += speed; 
            break;
		case ConsoleKey.Escape:     
            shouldExit = true; 
            break;
        default:
            // Exit if any other keys are pressed
            shouldExit = otherKeysExit;
            break;
    }

    // Clear the characters at the previous position
    Console.SetCursorPosition(lastX, lastY);
    for (int i = 0; i < player.Length; i++) 
    {
        Console.Write(" ");
    }

    // Keep player position within the bounds of the Terminal window
    playerX = (playerX < 0) ? 0 : (playerX >= width ? width : playerX);
    playerY = (playerY < 0) ? 0 : (playerY >= height ? height : playerY);

    // Draw the player at the new location
    Console.SetCursorPosition(playerX, playerY);
    Console.Write(player);
}

// Clears the console, displays the food and player
void InitializeGame() 
{
    Console.Clear();
    ShowFood();
    Console.SetCursorPosition(0, 0);
    Console.Write(player);
}
