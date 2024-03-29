﻿// See https://aka.ms/new-console-template for more information


// dotnet --version 8.0.203

/***Use the following dotnet command to create your new folder directory:

        dotnet new console -o ./nameOfFolder/

    Use the following dotnet commands to build and run your application: 
    
        dotnet build
        dotnet run
***/



using System;

// the ourAnimals array will store the following: 
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";
string suggestedDonation = "";

// variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";
decimal decimalDonation = 0.00m;

// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 7];

// create some initial ourAnimals array entries
for (int i = 0; i < maxPets; i++)
{
   switch (i)
   {
       case 0:
           animalSpecies = "dog";
           animalID = "d1";
           animalAge = "2";
           animalPhysicalDescription = "Weimaraner Dog Breed, female 25 inches at shoulder, weighing 55 pounds, gray short smooth coat, with blue-gray eyes. Housetrained.";
           animalPersonalityDescription = "Energetic, playful, protective, who loves children. Enjoys playing tug-of-war, and relaxing on the couch.";
           animalNickname = "Mara";
           suggestedDonation = "85.00";
           break;

       case 1:
           animalSpecies = "dog";
           animalID = "d2";
           animalAge = "5";
           animalPhysicalDescription = "Norwegian Elkhound Dog Breed, male 20 inches at weighing 75 pounds, with a lush silver-gray and black coat, and dark brown eyes. Housetrained.";
           animalPersonalityDescription = "Warm, enthusiastic, family oriented personality. Enjoys playing, and meeting new people.";
           animalNickname = "Aknu";
           suggestedDonation = "65.00";
           break;

       case 2:
           animalSpecies = "cat";
           animalID = "c3";
           animalAge = "1";
           animalPhysicalDescription = "Balinese Cat Breed, female weighing 8 pounds, cream chocolate point medium long coat, with sapphire blue eyes. Litter box trained.";
           animalPersonalityDescription = "Energetic, friendly, chatty personality. Enjoys playing and being the center of attention.";
           animalNickname = "Luna";
           suggestedDonation = "45.00";
           break;

       case 3:
           animalSpecies = "cat";
           animalID = "c4";
           animalAge = "3";
           animalPhysicalDescription = "Tonkinese Cat Breed, male weighing 10 pounds, champagne mink fine silky coat. Litter box trained.";
           animalPersonalityDescription = "Warm, loving personality, that craves human attention. Enjoys playing, climbing and whizzing by at warp speed.";
           animalNickname = "Tito";
           suggestedDonation = "40.00";
           break;

        case 4:
           animalSpecies = "cat";
           animalID = "c5";
           animalAge = "2";
           animalPhysicalDescription = "Burmese Cat Breed, female weighing 7 pounds, creamy honey fading into ashy brown coat, with deep yellow eyes. Litter box trained.";
           animalPersonalityDescription = "Warm, loving personality, that craves human attention. Enjoys playing, climbing and whizzing by at warp speed.";
           animalNickname = "Mochi";
           suggestedDonation = "50.00";
           break;

       default:
           animalSpecies = "";
           animalID = "";
           animalAge = "";
           animalPhysicalDescription = "";
           animalPersonalityDescription = "";
           animalNickname = "";
           suggestedDonation = "";
           break;

   }

   ourAnimals[i, 0] = "ID #: " + animalID;
   ourAnimals[i, 1] = "Species: " + animalSpecies;
   ourAnimals[i, 2] = "Age: " + animalAge;
   ourAnimals[i, 3] = "Nickname: " + animalNickname;
   ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
   ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;

   if (!decimal.TryParse(suggestedDonation, out decimalDonation))
   {
        decimalDonation = 45.00m; // if suggestedDonation NOT a number, default to 45.00
   }
   ourAnimals[i, 6] = $"Suggested Donation: {decimalDonation:C2}";
}

//top-level menu options
do
{
   // display the top-level menu options
   // note: the Console.Clear method is throwing an exception in debug sessions
   Console.Clear();

   Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
   Console.WriteLine(" 1. List all of our current pet information");
   Console.WriteLine(" 2. Display all dogs with a specified characteristic");
   Console.WriteLine();
   Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

   readResult = Console.ReadLine();
   if (readResult != null)
   {
       menuSelection = readResult.ToLower();
       // NOTE: We could try a do statement around the menuSelection entry to ensure a valid entry, but we
       //  use a conditional statement below that only processes the valid entry values, so the do statement 
       //  is not required here. 
   }

   // switch-case to process the selected menu option
   switch (menuSelection)
   {
       case "1":
           // List all of our current pet information
           for (int i = 0; i < maxPets; i++)
           {
               if (ourAnimals[i, 0] != "ID #: ")
               {
                   Console.WriteLine();
                   for (int j = 0; j < 7; j++)
                   {
                       Console.WriteLine(ourAnimals[i, j].ToString());
                   }
               }
           }
           Console.WriteLine("\n\rPress the Enter key to continue");
           readResult = Console.ReadLine();

           break;

        case "2":
            // CHALLENGE - Display all dogs with multiple search characteristics 

            string dogCharacteristics = "";

            while (dogCharacteristics == "")
            {
                /* 
                //have the user enter physical characteristics to search for
                Console.WriteLine($"\nEnter one desired dog characteristics to search for");
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    dogCharacteristic = readResult.ToLower().Trim();
                }
                */

                // have user enter multiple comma separated characteristics to search for
                Console.WriteLine($"\nEnter dog characteristics to search for separated by commas");
                readResult = Console.ReadLine();

                if (readResult != null)
                {
                    dogCharacteristics = readResult.ToLower();
                    Console.WriteLine();
                }                
            }

            string[] dogSearches = dogCharacteristics.Split(",");
            // trim leading and trailing spaces from each search term
            for (int i = 0; i < dogSearches.Length; i++)
            {
                dogSearches[i] = dogSearches[i].Trim();
            }

            Array.Sort(dogSearches);
            // update to "rotating" animation with countdown
            string[] searchingIcons = {" |", " /", "--", " \\", " *"};

            bool matchesAnyDog = false;
            string dogDescription = "";

            /*
            bool noMatchesDog = true;
            string dogDescription = "";
            */

            /*
            // loops through the ourAnimals array to search for matching animals
            for (int i = 0; i < maxPets; i++)
            {
                bool dogMatch = true;

                if (ourAnimals[i, 1].Contains("dog"))
                {
                    
                    if (dogMatch == true)
                    {
                        // #7 Search combined descriptions and report results
                        dogDescription = ourAnimals[i, 4] + "\n" + ourAnimals[i, 5];
                        

                        if (dogDescription.Contains(dogCharacteristic))
                        {
                            Console.WriteLine($"\nOur dog {ourAnimals[i, 3]} is a match!");
                            Console.WriteLine(dogDescription);

                            noMatchesDog = false;
                        }
                    }
                }
            }*/

            // CHALLENGE - loops through the ourAnimals array to search for matching animals
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 1].Contains("dog"))
                {

                    // Search combined descriptions and report results
                    dogDescription = ourAnimals[i, 4] + "\n" + ourAnimals[i, 5];
                    bool matchesCurrentDog = false;

                    foreach (string term in dogSearches)
                    {
                        // only search if there is a term to search for
                        if (term != null && term.Trim() != "")
                        {
                            for (int j = 2; j > -1 ; j--)
                            {
                                // update "searching" message to show countdown
                                foreach (string icon in searchingIcons)
                                {
                                    Console.Write($"\rsearching our dog {ourAnimals[i, 3]} for {term.Trim()} {icon} {j.ToString()}");
                                    Thread.Sleep(100);
                                }
                                
                                Console.Write($"\r{new String(' ', Console.BufferWidth)}");
                            }

                            // iterate submitted characteristic terms and search description for each term
                            if (dogDescription.Contains(" " + term.Trim() + " "))
                            {
                                // update message to reflect current search term match 

                                Console.WriteLine($"\rOur dog {ourAnimals[i, 3]} matches your search for {term.Trim()}");

                                matchesCurrentDog = true;
                                matchesAnyDog = true;
                            }
                        }
                    }
                    
                    // if the current dog is match, display the dog's info
                    if (matchesCurrentDog)
                    {
                        Console.WriteLine($"\r{ourAnimals[i, 3]} ({ourAnimals[i, 0]})\n{dogDescription}\n");
                    }
                }
            }

            //if (noMatchesDog)
            if (!matchesAnyDog)
            {
                Console.WriteLine("None of our dogs are a match found for: " + dogCharacteristics);
            }

            Console.WriteLine("\n\rPress the Enter key to continue");
            readResult = Console.ReadLine();

            break;

        default:
            break;
    }

} while (menuSelection != "exit");