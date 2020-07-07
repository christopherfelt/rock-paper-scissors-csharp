using System;
using System.Collections.Generic;

namespace rockpaperscissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rock Paper Scissors");
            System.Console.WriteLine("Choose an action: Rock, Paper or Scissor");
            string playerChoice = System.Console.ReadLine().ToLower();
            List<string> choiceOptions = new List<string>() { "rock", "paper", "scissors" };
            if(!choiceOptions.Contains(playerChoice)){
                System.Console.WriteLine("That is not opition");
                System.Console.WriteLine("You die");
            } else {

                Random random = new Random();
                int computerChoiceNum = random.Next(1, 4);
                string computerChoice;
                if(computerChoiceNum == 1){
                    computerChoice = "rock";
                } else if (computerChoiceNum == 2) {
                    computerChoice = "paper";
                } else {
                    computerChoice = "scissors";
                }

                Dictionary<string, List<string>> choiceComparisons = new Dictionary<string, List<string>>()
                {
                    {"rock", new List<string>(){"paper", "scissors"}},
                    {"paper", new List<string>(){"scissors", "rock"}},
                    {"scissors", new List<string>(){"rock", "paper"}}
                };

                var playerKeyPair = choiceComparisons[playerChoice];

                if(computerChoice==playerKeyPair[0]){
                    System.Console.WriteLine(computerChoice + " beats " + playerChoice[0]+"!");
                    System.Console.WriteLine("You die");
                } else if (computerChoice==playerKeyPair[1]) {
                    System.Console.WriteLine(playerChoice + " beats " + computerChoice + "!");
                    System.Console.WriteLine("You win!");
                    System.Console.WriteLine("But you still die.");
                } else {
                    System.Console.WriteLine("You tie");
                    System.Console.WriteLine("You die");
                }
            }

            

        }
    }
}
