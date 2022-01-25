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
        int player = 1;
        public MainPage()
        {
            InitializeComponent();
        }

        void Button_Clicked(object sender, EventArgs e)
        {
            if (((Button)sender).Text != "") return;

            if (player == 1)
            {
                ((Button)sender).Text = "X";
                player = 2;
            }
            else
            {
                ((Button)sender).Text = "O";
                player = 1;
            }
        }


    }
}
