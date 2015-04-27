﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HfcsLab1
{
    class Guy
    {
        public string Name; // The guy's name
        public Bet MyBet; // An instance of Bet that has his bet
        public int Cash; // How much cash he has
        // The last two fields are the guy’s GUI controls on the form
        public RadioButton MyRadioButton; // My RadioButton
        public Label MyLabel; // My Label
        public void UpdateLabels()
        {
            // Set my label to my bet’s description, and the label on my
            // radio button to show my cash ("Joe has 43 bucks")
            MyLabel.Text = MyBet.GetDescription();
            MyRadioButton.Text = Name + " has " + (Cash - MyBet.Amount) + " bucks.";

        }
        public void ClearBet() {
            MyBet = new Bet()
            {
                Amount = 0,
                Bettor = this
            };
        
        } // Reset my bet so it’s zero
        public bool PlaceBet(int BetAmount, int DogToWin)
        {
            // Place a new bet and store it in my bet field
            // Return true if the guy had enough money to bet
            if (Cash - BetAmount >= 0)
            {
                MyBet = new Bet()
                {
                    Amount = BetAmount,
                    Dog = DogToWin,
                    Bettor = this
                };
                return true;
            }
            else
            {
                MessageBox.Show(Form1.ActiveForm, "You haven't got enough money, you bum!", "Get the Hell Out!");
                return false;
            }
        
        }
        public void Collect(int Winner)
        {
            // Ask my bet to pay out, clear my bet, and update my labels
            Cash = Cash + MyBet.PayOut(Winner);
            ClearBet();
            UpdateLabels();

        }
    }
}
