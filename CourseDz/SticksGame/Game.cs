using System;
namespace SticksGame
{
    public enum Player { Human,Machine}
    public enum GameStage { InProgress,GameOver,NotStarted}
    public class Game
    {
        public Game(int startNumberOfSticks,Player whoStarted)
        {
            NumberOfSticks = startNumberOfSticks;
            WhoseTurn = whoStarted;
            gameStage = GameStage.NotStarted;
            randomiser = new Random();
        }

        public int NumberOfSticks { get; private set; }
        public Player WhoseTurn { get; private set; }
        private GameStage gameStage;
        private Random randomiser;



        public event Action<Player> EndOfGame;
        public event Action HumanTurnToMakeMove;
        public event Action<int> MachineMoved;


        public void Start()
        {
            if (gameStage == GameStage.InProgress)
            {
                throw new InvalidOperationException("Game is already running and cant be started");
            }
            gameStage = GameStage.InProgress;

            while (gameStage == GameStage.InProgress)
            {
                if (WhoseTurn == Player.Human)
                {
                    HumanMakesMove();
                }
                else
                {
                    MachineMakesMove();
                }
                FireGameOverIfNeeded();
                if (gameStage == GameStage.GameOver)
                {
                    break;
                }

            }
        }

        private void FireGameOverIfNeeded()
        {
            if (NumberOfSticks == 0)
            {
                gameStage = GameStage.GameOver;
                EndOfGame.Invoke(WhoseTurn);

            }
        }

        private void MachineMakesMove()
        {
            int maxNumber = NumberOfSticks >= 3 ? 3 : NumberOfSticks;
            int numberOfSticks= randomiser.Next(1, maxNumber);
            NumberOfSticks -= numberOfSticks;
            MachineMoved?.Invoke(numberOfSticks);
            WhoseTurn = WhoseTurn == Player.Human ? Player.Machine : Player.Human;

        }

        private void HumanMakesMove()
        {
            HumanTurnToMakeMove?.Invoke();

        }
        public void HumanMove(int numberOfSticks)
        {
            if (numberOfSticks>3 || numberOfSticks < 1)
            {
                throw new ArgumentException("You can take from 1 to 3 Stikcs only");
            }
            if (numberOfSticks > NumberOfSticks)
            {
                throw new ArgumentException("You cant take more stiks then in game");
            }
            NumberOfSticks -= numberOfSticks;
            WhoseTurn = WhoseTurn == Player.Human ? Player.Machine : Player.Human;


        }






    }
}
