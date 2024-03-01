using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Puzzle_JMMB
{
    public partial class MainPage : ContentPage
    {
        Random rand;

        public MainPage()
        {
            InitializeComponent();
        }

        void WinCheck()
        {
            if(Btn1.Text == "1" && Btn2.Text == "2" && Btn3.Text == "3" && Btn4.Text == "4" && Btn5.Text == "5" && Btn6.Text == "6" && Btn7.Text == "7" && Btn8.Text == "8")
            {
                DisplayAlert("Puzzle", "Wygrałeś!", "OK");
            }
        }
    }
}
