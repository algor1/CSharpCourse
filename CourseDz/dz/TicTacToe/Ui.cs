using System;
using System.Text;

namespace dz.UITicTacToe
{
    public class UITicTakToe 
    {
        public TicTacToe Game { get; }

        public UITicTakToe(TicTacToe game)
        {
            Game = game;
            Start();
        }

        private void Start()
        {
            for (int i = 0; i < 9; i++)
            {

                int index;
                Console.WriteLine("Make your move(type index)");
                Console.WriteLine(GetBoard());
                index = int.Parse(Console.ReadLine());
                Game.MakeMove(index);
                if (Game.GetWinner() != Winner.Unfinished) break;
             }
            Console.WriteLine();
            Console.WriteLine($"Winner is{Game.GetWinner()}");
        }

        private string GetBoard()
        {
            var sb = new StringBuilder();

            sb.AppendLine($" {StateFormat(Game.GetState(1))} | {StateFormat(Game.GetState(2))} | {StateFormat(Game.GetState(3))} ");
            sb.AppendLine("---+---+---");
            sb.AppendLine($" {StateFormat(Game.GetState(4))} | {StateFormat(Game.GetState(5))} | {StateFormat(Game.GetState(6))} ");
            sb.AppendLine("---+---+---");
            sb.AppendLine($" {StateFormat(Game.GetState(7))} | {StateFormat(Game.GetState(8))} | {StateFormat(Game.GetState(9))} ");
            return sb.ToString();
        }

        private string StateFormat(State state)
        {
            if (state == State.Unset) return " ";
            return state.ToString();
        }
    }
}
