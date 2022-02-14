namespace TicTacToe_cs
{
    class TicTacToe 
    {
        static void Main()
        {
            Board board = new Board();
            //BoardCAD board = new BoardCAD();
            Player player = new Player();

            for (int i = 1; i <= 9; i++)
            {
                board.DisplayBoard();
                player.TakeTurn(board.Squares);
                if (board.WinCheck(player.Current)) { board.DisplayWinner(player.Current); return; }
                player.SwitchPlayer();
            }

            board.DisplayTie();
        }
    }
}