/* logic and conditional statements to write a classic text-based 
Choose Your Own Adventure Game. 
*/


internal class Program
{
    private static void Main(string[] args)
    {
        //variables
        string userName;
        string noiseChoice;
        string doorChoice = " ";
        string riddleAnswer = " ";
        string keyChoice = " ";
        /* the mysterious noise */


            //ask the user's name
            Console.Write("WHAT IS YOUR NAME?: ");
            userName = Console.ReadLine();
            Console.WriteLine($"Hello, {userName}! Welcome to our story!");

            Console.WriteLine("It begins on a cold rainy night. \n" +
            "You're sitting in your room and hear a noise coming \n" +
            "from down the hall. \n DO YOU GO INVESTIGATE?");

            Console.Write("Type YES or NO \n ");
            noiseChoice = Console.ReadLine();
            noiseChoice = noiseChoice.ToUpper();

            if(noiseChoice == "NO")
            {
                Console.WriteLine("Not much of an adventure if we don't \n" +
                "leave our room! \n THE END");
                    Environment.Exit(0);
            }
            else if(noiseChoice == "YES")
            {
                Console.WriteLine("You walk into the hallway and see a \n" + 
                "light coming from under a door down the hall. You walk \n" +
                "towards it. \n DO YOU OPEN IT OR KNOCK?");
            }
            else
            {
                Console.WriteLine("You didn't type YES or NO! \n Apparently your too dumb for games so.... \n GOODBYE!");
            }

            Console.Write("Type OPEN or KNOCK \n");
            doorChoice = Console.ReadLine();
            doorChoice = doorChoice.ToUpper();

            if( doorChoice == "KNOCK")
            {
                Console.WriteLine("A voice behind the door speaks. \n"
                                + "It says, \"Answer this riddle: Poor people have it\""
                                + "\"Rich people need it. If you eat it you die.\""
                                + "\n"
                                + "What is it?");
                Console.Write("Type your answer:");
                riddleAnswer = riddleAnswer.ToUpper();
                    if(riddleAnswer == "NOTHING")
                    {
                        Console.WriteLine("The door opens and NOTHING is"+
                        "there. You turn off \n the light and run back to"+
                        "your room and lock the door. \n THE END");
                    }
                    else
                    {
                    Console.WriteLine("You answered incorrectly. \n"+
                    "The door doesn't open. \n THE END"); 
                    }
            }
            else if(doorChoice == "OPEN")
            {
                Console.WriteLine("The door is locked! \n See if one of your"+
                "three keys will open it.");
                Console.Write("Your have three keys numbered 1-3 \n"+
                "Type the numbe of the key you would like to use \n");
                keyChoice = Console.ReadLine();
                keyChoice = keyChoice.ToUpper();
                
                while((!keyChoice.Contains("1") && keyChoice.Contains("2") && keyChoice.Contains("3")))
                {
                    Console.WriteLine("You only have keys 1-3. Enter the key number you actually have...");
                    keyChoice = Console.ReadLine();
                    keyChoice = keyChoice.ToUpper();
                    break;
                }
                switch(keyChoice)
                {
                    case "1":
                        Console.WriteLine("You choose the first key. \n"+
                        "Lucky choice! \n The door opens and NOTHING is there. \n"+
                        "Strange... \n THE END");
                        break;
                    case "2":
                        Console.WriteLine("You choose the second key. \n The door"+
                        "doesn't open. \n THE END");
                    break;
                    case "3":
                        Console.WriteLine("You choose the third key. \n The door"+
                        "doesn't open. \n THE END");
                    break;
                        /*default:
                            Console.WriteLine("You only have keys 1-3! Guess you are not smart enough to type a /n"+
                            "number... \n \n so... \n \n  GOODBYE! \n \n");
                            Environment.Exit(0); 
                        break; */
                }
                
                
            }
}
}