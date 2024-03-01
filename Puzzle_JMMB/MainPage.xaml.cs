﻿using System;
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
        Button senderBtn;
        int senderId;
        Button newBtn;
        public MainPage()
        {
            InitializeComponent();
            GenerateFields();
        }

        private void Btn_Clicked(object sender, EventArgs e)
        {
            senderBtn = (Button)sender;
            senderId = int.Parse(senderBtn.AutomationId.Substring(3, 1));
            if(senderBtn.Text != "")
            {
                try
                {
                    newBtn = (Button)FindByName("Btn" + (senderId + 3).ToString());
                    if(newBtn.Text == "")
                    {
                        newBtn.Text = senderBtn.Text;
                        senderBtn.Text = "";
                    }
                }
                catch { }
                try
                {
                    newBtn = (Button)FindByName("Btn" + (senderId - 3).ToString());
                    if (newBtn.Text == "")
                    {
                        newBtn.Text = senderBtn.Text;
                        senderBtn.Text = "";
                    }
                }
                catch { }
                try
                {
                    newBtn = (Button)FindByName("Btn" + (senderId + 1).ToString());
                    if (newBtn.Text == "" && senderId % 3 != 0)
                    {
                        newBtn.Text = senderBtn.Text;
                        senderBtn.Text = "";
                    }
                }
                catch { }
                try
                {
                    newBtn = (Button)FindByName("Btn" + (senderId - 1).ToString());
                    if (newBtn.Text == "" && (senderId - 1) % 3 != 0)
                    {
                        newBtn.Text = senderBtn.Text;
                        senderBtn.Text = "";
                    }
                }
                catch { }

                WinCheck();
            }
        }

        void WinCheck()
        {
            if(Btn1.Text == "1" && Btn2.Text == "2" && Btn3.Text == "3" && Btn4.Text == "4" && Btn5.Text == "5" && Btn6.Text == "6" && Btn7.Text == "7" && Btn8.Text == "8")
            {
                DisplayAlert("Puzzle", "Wygrałeś!", "OK");
                GenerateFields();
            }
        }

        void GenerateFields()
        {
            List<int> fields = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            for (int i = 1; i < 9; i++)
            {
                int random = rand.Next(0, fields.Count - 1);
                Button newBtn = (Button)FindByName("Btn" + i);
                newBtn.Text = random.ToString();
                fields.RemoveAt(random);
            }
        }
    }
}
