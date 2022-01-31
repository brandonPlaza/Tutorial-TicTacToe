using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TicTacToe2
{
    public partial class MainPage : ContentPage
    {
        Game gameState;
        public MainPage()
        {
            InitializeComponent();
            gameState = new Game();
            List<int> vs = new List<int>();
        }

        void Button_Clicked(object sender, EventArgs e)
        {
            ((Button)sender).Text = gameState.PlayerMove((Button)sender);
        }

    }
}
