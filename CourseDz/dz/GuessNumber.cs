using System;
namespace dz
{
    public enum Player
    {
        Human,
        Machine
    }
    public enum Answer { More,Less}
    public class GuessNumber
    {
        private readonly int maxNumber;
        private readonly int maxTurns;
        private readonly Player guessingPlayer;

        private int lastRangeMin;
        private int lastRangeMax;
        private int lastNumber;


        private int rightNumber;
        private bool win;

        public GuessNumber(int maxNumber, int maxTurns, Player guessingPlayer)
        {
            this.maxNumber = maxNumber;
            this.maxTurns = maxTurns;
            this.guessingPlayer = guessingPlayer;
        }
        public void Start()
        {
            if (guessingPlayer == Player.Machine)
            {
                lastRangeMin = 0;
                lastRangeMax = maxNumber;
                lastNumber = 0;
                Console.WriteLine($"Think up a number from 0 to {maxNumber}");
            }
            else
            {
                var random = new Random();
                rightNumber = random.Next(0, 100);
            }
            Game();
        }

            public void Game()
        {

            for (int i = 0; i < maxTurns; i++)
            {
                Turn();
                if (win)
                    break;
            }
            if (!win)
                Loose();
        }

        private void Loose()
        {
            Console.WriteLine($"{guessingPlayer} loose!");
        }
        private void Win()
        {
            win = true;
            Console.WriteLine($"{guessingPlayer} win!");
        }

        private void Turn()
        {
            if (guessingPlayer == Player.Machine) {
                
                HumanCheckNumber(AskMachine());
            }
            else
            { 
                MachineCheckNumber(AskHuman());
            }


        }

        private void MachineCheckNumber(int number)
        {
            if (number == rightNumber)
                Win();
            else
            {
                string answer = number > rightNumber ? "Less" : "More";
                Console.WriteLine($"My number is {answer} then {number}." );
            }

        }

        

        private int AskHuman()
        {
            Console.WriteLine($"Enter number from 0 to {maxNumber} ");
            int number;
            while (!int.TryParse(Console.ReadLine(), out number)&&number>100&&number<0){
                Console.WriteLine("Wrong number!");
            }
            return number;
            
        }

        private void HumanCheckNumber(int number)
        {
            Console.WriteLine($"I think it is {number} .");
            Console.WriteLine("If it is less then your number enter '<'");
            Console.WriteLine("If it is more then your number enter '>'");
            Console.WriteLine("If it is equal your number enter '='");
            string str = "";
            do
            {
                str = Console.ReadLine();
            } while (!(str == "=" || str == "<" || str == ">"));

            switch (str)
            {
                case "=":
                    Win();
                    break;

                case ">":
                    lastRangeMin = number;
                    break;

                case "<":
                    lastRangeMax = number;
                    
                    break;
            } 
            
        }
        

       


        private int AskMachine()
        {

            lastNumber = (lastRangeMax-lastRangeMin)/2+lastRangeMin;
            return lastNumber;
        }

        private Player InversePlayer(Player player)
        {
            return player == Player.Machine ? Player.Human : Player.Machine;
        }

        
    }
}
