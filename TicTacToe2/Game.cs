using System;
using Xamarin.Forms;

namespace TicTacToe2
{
    public enum Player
    {
        player1,
        player2
    }
   
    public class Game
    {
        private Player player;

        //Constructor
        public Game()
        {
            player = Player.player1;
        }

        public Player GetPlayer()
        {
            return player;
        }

        public string PlayerMove(Button button)
        {
            if (button.Text != "") return button.Text;
            // Equiv to ==
            if (player.Equals(Player.player1))
            {
                player = Player.player2;
                return "X";
            }
            else
            {
                player = Player.player1;
                return "O";
            }
        }

    }
}
