using System;
// Namespace
namespace Number_guesser
{
    // Main Class
    class Program
    {
        // Entry point method
        static void Main(string[] args)
        {
            //Run GetAppInfo function to get app info
            GetAppInfo();

            //Run GreetUser to start game
            GreetUser();

            while (true)
            {

                //Create random number
                Random random = new Random();

                //int correctNumber
                int correctNumber = random.Next(1, 10);

                //Init quess var
                int guess = 0;

                //Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                //While guess is not correct
                while (guess != correctNumber)
                {
                    //Get user input
                    string input = Console.ReadLine();

                    //Check input
                    if (!int.TryParse(input, out guess))
                    {

                        //Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please use a number between 1 and 10");

                        //Keep going
                        continue;
                    }

                    //cast to int put in guess
                    guess = Int32.Parse(input);

                    //Match guess to correct number
                    if (guess != correctNumber)
                    {
                        //Print wrong number message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, try again");
                    }
                }

                //Print you won message
                PrintColorMessage(ConsoleColor.Green, "You Won!!!");

                //Ask user to play again
                Console.WriteLine("Would you like to play again? [Y or N]");

                //Get answer
                string answer = Console.ReadLine().ToUpper();

                if(answer == "Y")
                {
                    continue;
                } 
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        static void GetAppInfo()
        {
             // Set app vars
            string appName = "Number Guesser";
        string appVersion = "1.0.0";
        string appAuthor = "Micheal Frary";

        //Change text color
        Console.ForegroundColor = ConsoleColor.Yellow;

            //Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset console color
            Console.ResetColor();
        }

        static void GreetUser()
        {
            //Ask user name
            Console.WriteLine("What is your name");

            //Get user name input
            string inputName = Console.ReadLine();

            //Ask for game
            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            //Change text color
            Console.ForegroundColor = color;

            //Tell user not a number
            Console.WriteLine(message);

            //Reset console color
            Console.ResetColor();
        }
    }
}
