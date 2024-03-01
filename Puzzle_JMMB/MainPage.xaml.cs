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

        private void Btn_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int id = int.Parse(btn.AutomationId.Substring(3, 1));
            Button newBtn;
            if(btn.Text != "")
            {
                try
                {
                    newBtn = (Button)FindByName("Btn" + (id + 3).ToString());
                    if(newBtn.Text == "")
                    {
                        newBtn.Text = btn.Text;
                        btn.Text = "";
                    }
                }
                catch { }
                try
                {
                    newBtn = (Button)FindByName("Btn" + (id - 3).ToString());
                    if (newBtn.Text == "")
                    {
                        newBtn.Text = btn.Text;
                        btn.Text = "";
                    }
                }
                catch { }
                try
                {
                    newBtn = (Button)FindByName("Btn" + (id + 1).ToString());
                    if (newBtn.Text == "")
                    {
                        newBtn.Text = btn.Text;
                        btn.Text = "";
                    }
                }
                catch { }
                try
                {
                    newBtn = (Button)FindByName("Btn" + (id - 1).ToString());
                    if (newBtn.Text == "")
                    {
                        newBtn.Text = btn.Text;
                        btn.Text = "";
                    }
                }
                catch { }
            }

            
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
