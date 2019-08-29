using System;
namespace dz.UITicTacToe
{
    public enum State {X,O,Unset}
    public enum Winner { Crosses,Zeros,Draw,Unfinished}
    public class TicTacToe
    {
        public int MovesCounter { get; private set; }
        private State[] board = new State[9];
        public TicTacToe()
        {
            for (int i = 0; i < board.Length; i++)
            {
                board[i] = State.Unset;
            }
        }
        public void MakeMove(int index)
        {
            board[index - 1] = MovesCounter % 2 == 0 ? State.X : State.O;
            MovesCounter++;
        }
        public State GetState (int index)
        {
            return board[index - 1];
        }
        public Winner GetWinner()
        {
            int[,] checkIndexes = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 1, 4, 7 }, { 2, 5, 8 }, { 3, 6, 9 }, { 1, 5, 9 }, { 3, 5, 7 } };
            return GetWinner(checkIndexes);
        }

        private Winner GetWinner(int[,] checkIndexes)
        {
            for (int i = 0; i <8 ; i++)
            {
                switch (SameState(checkIndexes[i,1],checkIndexes[i,2],checkIndexes[i,3]))
                {
                    case State.X:
                        return Winner.Crosses;
                        
                    case State.O:
                        return Winner.Zeros;
                }
            }
            return MovesCounter == 8 ? Winner.Draw : Winner.Unfinished;

        }

        private State SameState(int v1, int v2, int v3)
        {
            if (board[v1] == board[v2] && board[v1] == board[v3])
            {
                return board[v1];
            }
            return State.Unset;

        }
    }
}
