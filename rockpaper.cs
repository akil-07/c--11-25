using System;
namespace rockpaperscissors
{
    class program
    {
        static void Main()
        {
            Random ran = new Random();
            bool again = true;
            string player;
            string computer;
            String play;
            while (again)
            {
                player = "";
                computer = "";
                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
                {
                    Console.WriteLine("ENTER ROCK,PAPER,SCISSORS");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                }
                switch (ran.Next(1, 4))
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;
                }
                Console.WriteLine("Player: " + player);
                Console.WriteLine("Computer: " + computer);
                switch (player)
                {
                    case "ROCK":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("IT'S A DRAW");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("YOU LOSE!");
                        }
                        else
                        {
                            Console.WriteLine("YOU WIN!!!");
                        }
                        break;

                    case "SCISSORS":
                        if (computer == "SCISSORS")
                        {
                            Console.WriteLine("IT'S A DRAW");
                        }
                        else if (computer == "ROCK")
                        {
                            Console.WriteLine("YOU LOSE!");
                        }
                        else
                        {
                            Console.WriteLine("YOU WIN!!!");
                        }
                        break;

                    case "PAPER":
                        if (computer == "PAPER")
                        {
                            Console.WriteLine("IT'S A DRAW");
                        }
                        else if (computer == "SCISSORS")
                        {
                            Console.WriteLine("YOU LOSE!");
                        }
                        else
                        {
                            Console.WriteLine("YOU WIN!!!");
                        }
                        break;

                }
                Console.WriteLine("WOULD YOU LIKE TO PLAY AGAIN (Y/N):");
                play=Console.ReadLine();
                play=play.ToUpper();
                if(play =="Y")
                {
                    again=true;
                }
                else
                {
                    again=false;
                }

            }
            Console.WriteLine("THANKS FOR PLAYING!!!");
            Console.ReadKey();

        }
    }
}