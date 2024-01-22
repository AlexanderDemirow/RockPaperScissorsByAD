namespace RockPaperScissors
{
    internal class RockPaperScissors
    {
        static void Main(string[] args)
        {
            const string Rock = "Rock";
            const string Paper = "Paper";
            const string Scissors = "Scissors";

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.WriteLine("Choose [r]ock, [p]aper or [s]cissors: ");
            string playerMove = Console.ReadLine();

            if (playerMove == "rock" || playerMove == "r")
            {
                playerMove = Rock;
            }
            else if (playerMove == "p" || playerMove == "paper")
            {
                playerMove = Paper;
            }
            else if (playerMove == "s" || playerMove == "scissors")
            {
                playerMove = Scissors;
            }
            else
            {
                Console.WriteLine("Invalid input. Try again...");
                return;
            }

            Random randomNumber = new Random();
            int computerRandomNumber = randomNumber.Next(1, 4);
            string computerMove = "";

            switch (computerRandomNumber)
            {
                case 1: computerMove = Rock; break;
                case 2: computerMove = Paper; break;
                case 3: computerMove = Scissors; break;

            }

            Console.ForegroundColor = ConsoleColor.Yellow;
           
            Console.WriteLine($"The computer chose: {computerMove}");

            if ((playerMove == Rock && computerMove == Scissors) || (playerMove == Paper && computerMove == Rock) || (playerMove == Scissors && computerMove == Paper))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You win!");
            }
            else if ((computerMove == Rock && playerMove == Scissors) || (computerMove == Paper && playerMove == Rock) || (computerMove == Scissors && playerMove == Paper))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You lose!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("This game was a draw.");
            }
            Console.ResetColor();
           
        }
    }
}