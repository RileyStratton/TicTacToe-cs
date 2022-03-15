

namespace TicTacToe_cs
{
    internal class Player
    {
        
        public char current = 'X';

        public void TakeTurn(char[] squares)
        {
            Console.WriteLine("Player " + current + "'s turn.");

            int choice;
            while (true)
            {
                Console.Write("Type a square number to claim: ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice < 1 | choice > 9)
                {
                    Console.WriteLine("Please enter a number between 1 and 9.");
                }

                else if (squares[choice] == 'X' | squares[choice] == 'O')
                {
                    Console.WriteLine("Please enter a number not taken by a player.");
                }

                else if (squares[choice] == Convert.ToChar(Convert.ToString(choice)))
                {
                    squares[choice] = current;
                    return;

                }
            }
        }

        public void SwitchPlayer()
        {
            if (current == 'X') { current = 'O'; }
            else if (current == 'O') { current = 'X'; }
        }
    }
}
