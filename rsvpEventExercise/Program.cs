﻿// See https://aka.ms/new-console-template for more information


// dotnet --version 8.0.203

/***Use the following dotnet command to create your new folder directory:

        dotnet new console -o ./nameOfFolder/

    Use the following dotnet commands to build and run your application: 
    
        dotnet build
        dotnet run
***/

string[] guestList = {"Rebecca", "Nadia", "Noor", "Jonte"};
string[] rsvps = new string[10];
int count = 0;

//RSVP("Rebecca", 1, "none", true);
//RSVP("Nadia", 2, "Nuts", true);
//RSVP("Linh", 2, "none", false);
//RSVP(name: "Linh", partySize: 2, allergies: "none", inviteOnly: false);
//RSVP("Tony", 1, "Jackfruit", true);
//RSVP("Tony", inviteOnly: true, allergies: "Jackfruit",  partySize: 1);
//RSVP("Noor", 4, "none", false);
//RSVP("Jonte", 2, "Stone fruit", false);
RSVP("Rebecca");
RSVP("Nadia", 2, "Nuts");
RSVP(name: "Linh", partySize: 2, inviteOnly: false);
RSVP("Tony", allergies: "Jackfruit", inviteOnly: true);
RSVP("Noor", 4, inviteOnly: false);
RSVP("Jonte", 2, "Stone fruit", false);
ShowRSVPs();

//void RSVP(string name, int partySize, string allergies, bool inviteOnly) 
void RSVP(string name, int partySize = 1, string allergies = "none", bool inviteOnly = true)
{
    if (inviteOnly)
    {
        // search guestList before adding rsvp
    }

    rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
    count++;

    if (inviteOnly)
    {
        bool found = false;
        foreach (string guest in guestList)
        {
            if (guest.Equals(name)) {
                found = true;
                break;
            }
        }
        if (!found)
        {
            Console.WriteLine($"Sorry, {name} is not on the guest list");
            return;
        }
    }
}

void ShowRSVPs()
{
    Console.WriteLine("\nTotal RSVPs:");
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(rsvps[i]);
    }
}
