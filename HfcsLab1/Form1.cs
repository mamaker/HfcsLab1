using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HfcsLab1
{
    public partial class Form1 : Form
    {
        //Declare Array Sizes
        Greyhound[] GreyhoundArray = new Greyhound[4];
        Guy[] GuyArray = new Guy[3];
        Guy GuyBet = new Guy();

        //Declare Random Object
        //Required so we don't have the same sequence of distance
        //for each instance of Greyhound. Wouldn't be a very exciting
        //race otherwise.
        Random random = new Random();

        //Declare Variables
        bool lockRace = false;
        bool BetPlaced = false;

        public Form1()
        {
            InitializeComponent();

            //Init Constants
            minBetLabel.Text = "Minimum Bet = $" + betValue.Minimum ;

            GreyhoundArray[0] = new Greyhound()
            {
                MyPictureBox = Greyhound1,
                StartingPosition = Greyhound1.Left,
                RaceTrackLength = raceTrackPictureBox.Width - Greyhound1.Width,
                Randomizer = random
            };


            GreyhoundArray[1] = new Greyhound()
            {
                MyPictureBox = Greyhound2,
                StartingPosition = Greyhound2.Left,
                RaceTrackLength = raceTrackPictureBox.Width - Greyhound2.Width,
                Randomizer = random
            };

            GreyhoundArray[2] = new Greyhound()
            {
                MyPictureBox = Greyhound3,
                StartingPosition = Greyhound3.Left,
                RaceTrackLength = raceTrackPictureBox.Width - Greyhound3.Width,
                Randomizer = random
            };

            GreyhoundArray[3] = new Greyhound()
            {
                MyPictureBox = Greyhound4,
                StartingPosition = Greyhound4.Left,
                RaceTrackLength = raceTrackPictureBox.Width - Greyhound4.Width,
                Randomizer = random
            };

            //Initialise Guy Array
            GuyArray[0] = new Guy()
            {
                Name = "Joe",
                MyBet = new Bet(),
                Cash = 50,
                MyRadioButton = joeRadioButton,
                MyLabel = joeBetLabel
            };

            GuyArray[1] = new Guy()
            {
                Name = "Bob",
                MyBet = new Bet(),
                Cash = 75,
                MyRadioButton = bobRadioButton,
                MyLabel = bobBetLabel
            };

            GuyArray[2] = new Guy()
            {
                Name = "Al",
                MyBet = new Bet(),
                Cash = 45,
                MyRadioButton = alRadioButton,
                MyLabel = alBetLabel
            };

            //Clear Bets on Startup Only!
            for (int i = 0; i <= 2; i++)
            {
                GuyArray[i].ClearBet();
                GuyArray[i].UpdateLabels();
            }

        }

        private void raceButton_Click(object sender, EventArgs e)
        {
            if (BetPlaced)
            {
                //Start Timer and reset race lock.
                raceTimer.Start();
                lockRace = false;
                bettingParlour.Enabled = false;
            }
            else
            {
                MessageBox.Show(this, "No Bets have been placed!", "Payup if you wanna race!");
            }

        }

        private void raceTimer_Tick(object sender, EventArgs e)
        {
                        //Add the call Run method from Greyhound class to update the race location.
            for (int i = 0; i <= 3; i++)
            {
                GreyhoundArray[i].Run();
                //Stop Race if we have a Winner!    
                if (lockRace == false)
                {
                    
                    if (GreyhoundArray[i].Run())
                    {
                        raceTimer.Stop();
                       
                        MessageBox.Show(this, "Congratulations Greyhound Number : " + (i+1), "We have a winner!");
                        //Assign Winning Dog.
                        int winner = (i+1);
                        //Check who has won!
                        GuyArray[0].Collect(winner);
                        GuyArray[1].Collect(winner);
                        GuyArray[2].Collect(winner);
                        //Stop Race
                        lockRace = true;
                        BetPlaced = false;
                        bettingParlour.Enabled = true;
                        //Reset Greyhound position for start of race
                        for (int j = 0; j <= 3; j++)
                        {
                            GreyhoundArray[j].TakeStartingPosition();

                        }

                    }
                        
                }
            }
         }

        private void joeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = "Joe";
            GuyBet = GuyArray[0];
        }

        private void bobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = "Bob";
            GuyBet = GuyArray[1];
        
        }

        private void alRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = "Al";
            GuyBet = GuyArray[2];
        }

        private void betButton_Click(object sender, EventArgs e)
        {
            //Init Variables
            int bet = (int)betValue.Value;
            int dogNo = (int)dogNumber.Value;
            bool PlaceBet;

            //Assign Name associated to bet, selected via RadioButtons
            GuyBet.Name = nameLabel.Text;
            //Assign Bool Var and call PlaceBet method for associated Guy
            if (bet >= betValue.Minimum)
            {
                PlaceBet = GuyBet.PlaceBet(bet, dogNo);
                //Check the Bet is Valid before updating the Labels.
                if (PlaceBet)
                {
                    GuyBet.UpdateLabels();
                    BetPlaced = true;
                }
            }
            else
            {
                MessageBox.Show(this, "The Minimum Bet allowed is: $" + betValue.Minimum, "Pay up Cheapo!");
            }
                        

        }

    }
}
