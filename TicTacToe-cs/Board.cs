namespace TicTacToe_cs
{
    internal class Board
    {

        public char[] Squares = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };


        public void DisplayBoard()
        {
            Console.WriteLine();
            Console.WriteLine(" " + Squares[1] + " | " + Squares[2] + " | " + Squares[3] + " ");
            Console.WriteLine("--- --- ---");
            Console.WriteLine(" " + Squares[4] + " | " + Squares[5] + " | " + Squares[6] + " ");
            Console.WriteLine("--- --- ---");
            Console.WriteLine(" " + Squares[7] + " | " + Squares[8] + " | " + Squares[9] + " ");
            Console.WriteLine();
        }

        public bool WinCheck(char Current)
        {
            if (Squares[1] == Current & Squares[2] == Current & Squares[3] == Current) { return true; }
            else if (Squares[4] == Current & Squares[5] == Current & Squares[6] == Current) { return true; }
            else if (Squares[7] == Current & Squares[8] == Current & Squares[9] == Current) { return true; }

            // Vertical win conditions
            else if (Squares[1] == Current & Squares[4] == Current & Squares[7] == Current) { return true; }
            else if (Squares[2] == Current & Squares[5] == Current & Squares[8] == Current) { return true; }
            else if (Squares[3] == Current & Squares[6] == Current & Squares[9] == Current) { return true; }

            // Diagonal win conditions
            else if (Squares[1] == Current & Squares[5] == Current & Squares[9] == Current) { return true; }
            else if (Squares[3] == Current & Squares[5] == Current & Squares[7] == Current) { return true; }

            // No win conditions
            else { return false; }
        }

        public void DisplayWinner(char Current)
        {
            DisplayBoard();
            Console.WriteLine("Player " + Current + " wins!");
        }

        public void DisplayTie()
        {
            DisplayBoard();
            Console.WriteLine("Cat. No one wins.");
        }

    }
}
