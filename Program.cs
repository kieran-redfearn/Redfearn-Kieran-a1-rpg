// Tell backstory to player 
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

Console.WriteLine("Welcome to the old castle");
Console.WriteLine("you randomly wake up in an old run down castle's bedroom");
Console.WriteLine("You have no idea why or even how you got here");
Console.WriteLine("The place is dark and the windows don't have any light coming through them");
Console.WriteLine("The windows cant be opened and cant be seen through");
Console.WriteLine("you walkout of the bedroom door to a hallway spliting left  and right");
Console.WriteLine("do you want to go left or right");

// ask player for choice 
Console.Write(">");
String hallwayChoice = Console.ReadLine();

// ask which way they want to go 
if (hallwayChoice == "left");
{
    Console.WriteLine("You choose to go down the left hall");
    Console.WriteLine("you see a single door at the end");
    Console.WriteLine("you open the door to find a kitchen");
    Console.WriteLine("you see all kinds of old kitchen equipment");
    Console.WriteLine("you catch a glimpse of a kitchen knife");
    Console.WriteLine("for some reason it calls to you");
    Console.WriteLine("do you want to touch the knife");

    // ask player for choice 
    Console.Write(">");
    string knifechoice == Console.ReadLine();
    if (knifechoice == "touch") ;
    {
        Console.WriteLine("you go to grab the knife");
        Console.WriteLine("as you grab the handle it flies up and points towards you");
        Console.WriteLine("you died");
    }
   else if (knifechoice == "don't") ;
    Console.WriteLine("You decide to ignore the calls of the knife and turn away");
    Console.WriteLine("you exit the kitchen and head back to where you started");
}


else if (hallwayChoice == "right") ;
{
    Console.WriteLine("you decide to go down to the right hallway");
    Console.WriteLine("while walking down the hallway you can see a dim light furthur down the hall");
    Console.WriteLine("as you get closer and closer the light gets brighter");
    Console.WriteLine("you approach the light source");
    Console.WriteLine("the light was coming from a torch");
    Console.WriteLine("beside the torch is a door");
    Console.WriteLine("you open the door");
    Console.WriteLine("you walk in and see that you have arrived in the throne room");
    Console.WriteLine("the room is well lit with torches on pillars");
    Console.WriteLine("there are also suits of armour that don't seem to have anyone inside");
    Console.WriteLine("one suit of armour has dropped it's sword at its feet");
    Console.WriteLine("would you like to pick up the sword");

    //ask player for choice 
    Console.Write(">");
    string swordChoice == Console.readline();
    if (swordChoice == "pick up") ;
    {
        Console.WriteLine("you pick the sword up from the ground");
        Console.WriteLine("you decide it would be fun to play around with it");
        Console.WriteLine("you start swinging the sword around");
        Console.WriteLine(" while swinging the sword you hit one of the suits of armour");
        Console.WriteLine("there is a horrible clashing nosie");
        Console.WriteLine("All the suits of armour start to screech");
        Console.WriteLine("they all ready the weapons they were carrying and turn them towards you");
        Console.WriteLine("you died");
    }
 else if (swordChoice == "don't") ;
    Console.WriteLine("you decide not to touch it");
    Console.WriteLine("you walk past the suits of empty armour and see the throne");
    Console.WriteLine("you walk towards the throne");
    Console.WriteLine("you now stand infront of the throne");
    Console.WriteLine("voices in your head tell you not to sit down");
    Console.WriteLine("unfortunatlly you no longer have the right to chose");
    Console.WriteLine("you have been here far too long");
    Console.WriteLine("you are just a vessle to be used for sacrafice");
    Console.WriteLine("you sit down on the throne");
    Console.WriteLine("you will now spend the rest of your time here");
    Console.WriteLine("you wont see light ever again");
    Console.WriteLine("THE END");
}
