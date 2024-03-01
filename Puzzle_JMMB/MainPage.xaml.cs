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
    }
}
