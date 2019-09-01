using System;
namespace SticksGame
{
    public class UI
    {
        private readonly int numberOfSticksInGame;
        private readonly Player playerWhoStarted;
        readonly Game game;

        public UI(int NumberOfSticksInGame,Player playerWhoStarted)
        {
            numberOfSticksInGame = NumberOfSticksInGame;
            this.playerWhoStarted = playerWhoStarted;
            game = new Game(numberOfSticksInGame,playerWhoStarted);
            game.HumanTurnToMakeMove += Game_HumanTurnToMakeMove;
            game.MachineMoved += Game_MachineMoved;
            game.EndOfGame += Game_EndOfGame;

        }

        private void Game_EndOfGame(Player player)
        {
            Console.WriteLine($"{player} win!");
        }

        private void Game_MachineMoved(int number)
        {
            Console.WriteLine($"I took {number} stiks");
        }

        private void Game_HumanTurnToMakeMove()
        {
            Console.WriteLine($"{game.NumberOfSticks} stiks in game");
            Console.WriteLine("It is Your turn. Enter the number of stiks you take");
            int number = int.Parse(Console.ReadLine());
            game.HumanMove(number);
        }

        public void Start()
        {
            game.Start();
        }
    }
}
