using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    public partial class SlotMachineForm : Form
    {
        private int _bet = 150;
        private int _credits = 5000;
        private int _jackpot = 10500;

        //toms

        private int winnings = 0;

        private int _shock = 0;
        private int _zero = 0;
        private int _lock = 0;
        private int _barrel = 0;
        private int _jack = 0;
        private int _sandyClaws = 0;
        private int _santa = 0;
        private int _oogie = 0;

        private Random random = new Random();

        public SlotMachineForm()
        {
            InitializeComponent();

            if (_credits < 5)
            {
                SpinButton.Enabled = false;
                ChangeBetButton.Enabled = false;

            }
        }

        //tom's

        /* Check to see if the player won the jackpot */
        private void checkJackPot()
        {
            /* compare two random values */
            var jackPotTry = this.random.Next(51) + 1;
            var jackPotWin = this.random.Next(51) + 1;
            if (jackPotTry == jackPotWin)
            {
                MessageBox.Show("You Won the $" + _jackpot + " Jackpot!!", "Jackpot!!");
                _credits += _jackpot;
                _jackpot = 10000;
            }
        }

        /* Utility function to check if a value falls within a range of bounds */
        private bool checkRange(int value, int lowerBounds, int upperBounds)
        {
            return (value >= lowerBounds && value <= upperBounds) ? true : false;

        }

        /* When this function is called it determines the betLine results.
    e.g. Bar - Orange - Banana */
        private void Reels()
        {
            int[] outCome = { 0, 0, 0 };
            string picture = "";

            for (var spin = 0; spin < 3; spin++)
            {
                outCome[spin] = this.random.Next(65) + 1;

                if (checkRange(outCome[spin], 1, 27))
                {  // 41.5% probability
                    picture = "oogie_boogie.png";
                    _oogie++;
                }
                else if (checkRange(outCome[spin], 28, 37))
                { // 15.4% probability
                    picture = "shock.png";
                    _shock++;
                }
                else if (checkRange(outCome[spin], 38, 46))
                { // 13.8% probability
                    picture = "zero.png";
                    _zero++;
                }
                else if (checkRange(outCome[spin], 47, 54))
                { // 12.3% probability
                    picture = "Lock.png";
                    _lock++;
                }
                else if (checkRange(outCome[spin], 55, 59))
                { //  7.7% probability
                    picture = "barrel.png";
                    _barrel++;
                }
                else if (checkRange(outCome[spin], 60, 62))
                { //  4.6% probability
                    picture = "jack.png";
                    _jack++;
                }
                else if (checkRange(outCome[spin], 63, 64))
                { //  3.1% probability
                    picture = "sandy_claws.png";
                    _sandyClaws++;
                }
                else if (checkRange(outCome[spin], 65, 65))
                { //  1.5% probability
                    picture = "merry_christmas.png";
                    _santa++;
                }

                if (spin == 0)
                {
                    Reel1PictureBox.Load(picture);
                }
                else if (spin == 1)
                {
                    Reel2PictureBox.Load(picture);
                }
                if (spin == 2)
                {
                    Reel3PictureBox.Load(picture);
                }
            }
        }

        /* This function calculates the player's winnings, if any */
        private void determineWinnings()
        {
            if (_oogie == 0)
            {
                if (_shock == 3)
                {
                    winnings = _bet * 10;
                }
                else if (_zero == 3)
                {
                    winnings = _bet * 20;
                }
                else if (_lock == 3)
                {
                    winnings = _bet * 30;
                }
                else if (_barrel == 3)
                {
                    winnings = _bet * 40;
                }
                else if (_jack == 3)
                {
                    winnings = _bet * 50;
                }
                else if (_sandyClaws == 3)
                {
                    winnings = _bet * 75;
                }
                else if (_santa == 3)
                {
                    winnings = _bet * 100;
                }
                else if (_shock == 2)
                {
                    winnings = _bet * 2;
                }
                else if (_zero == 2)
                {
                    winnings = _bet * 2;
                }
                else if (_lock == 2)
                {
                    winnings = _bet * 3;
                }
                else if (_barrel == 2)
                {
                    winnings = _bet * 4;
                }
                else if (_jack == 2)
                {
                    winnings = _bet * 5;
                }
                else if (_sandyClaws == 2)
                {
                    winnings = _bet * 10;
                }
                else if (_santa == 2)
                {
                    winnings = _bet * 20;
                }
                else if (_santa == 1)
                {
                    winnings = _bet * 5;
                }
                else
                {
                    winnings = _bet * 1;
                }
                _credits += winnings;
            }

        }

       

        /// <summary>
        /// this method makes the bet buttons visible when pressed as long as there are enough credits
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeBetButton_Click(object sender, EventArgs e)
        {
            BetGroupBox.Visible = true;

            // if there are less than 10 credits only allow user to select the 5 bet button
            if (_credits < 10)
            {
                Bet10Button.Enabled = false;
                Bet25Button.Enabled = false;
                Bet50Button.Enabled = false;
                Bet100Button.Enabled = false;
                Bet150Button.Enabled = false;
            }
            // if there are less than 25 credits only allow user to select the 5 and 10 bet buttons
            else if (_credits < 25)
            {
                Bet25Button.Enabled = false;
                Bet50Button.Enabled = false;
                Bet100Button.Enabled = false;
                Bet150Button.Enabled = false;
            }
            // if there are less than 50 credits only allow user to select the 5, 10 and 25 bet buttons
            else if (_credits < 50)
            {
                Bet50Button.Enabled = false;
                Bet100Button.Enabled = false;
                Bet150Button.Enabled = false;
            }
            // if there are less than 100 credits only allow user to select the 5, 10, 25, and 50 bet buttons
            else if (_credits < 100)
            {
                Bet100Button.Enabled = false;
                Bet150Button.Enabled = false;
            }
            // if there are less than 150 credits only allow user to select the 5, 10, 25, 50 and 100 bet buttons
            else if (_credits < 150)
            {
                Bet150Button.Enabled = false;
            }
        }

        /// <summary>
        /// this method sets the slot bet to 5 and hides the bet buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Bet5Button_Click(object sender, EventArgs e)
        {
            _bet = 5;
            BetLabel.Text = "5";
            BetGroupBox.Visible = false;
        }

        /// <summary>
        /// this method sets the slot bet to 10 and hides the bet buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Bet10Button_Click(object sender, EventArgs e)
        {
            _bet = 10;
            BetLabel.Text = "10";
            BetGroupBox.Visible = false;
        }

        /// <summary>
        /// this method sets the slot bet to 25 and hides the bt buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Bet25Button_Click(object sender, EventArgs e)
        {
            _bet = 25;
            BetLabel.Text = "25";
            BetGroupBox.Visible = false;
        }

        /// <summary>
        /// this method sets the slot bet to 50 and hides the bet buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Bet50Button_Click(object sender, EventArgs e)
        {
            _bet = 50;
            BetLabel.Text = "50";
            BetGroupBox.Visible = false;
        }

        /// <summary>
        /// this method sets the slot bet to 100 and hides the bet buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Bet100Button_Click(object sender, EventArgs e)
        {
            _bet = 100;
            BetLabel.Text = "100";
            BetGroupBox.Visible = false;
        }

        /// <summary>
        /// this method sets the slot bet to 150 and hides the bet buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Bet150Button_Click(object sender, EventArgs e)
        {
            _bet = 150;
            BetLabel.Text = "150";
            BetGroupBox.Visible = false;
        }

        /// <summary>
        /// this method resets the slot machine
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetButton_Click(object sender, EventArgs e)
        {
            //reset credits
            NumberCreditsLabel.Text = "5000";
            _credits = 5000;
            
            //reset bet
            BetLabel.Text = "150";
            _bet = 150;

            //reset jackpot
            JackpotNumberLabel.Text = "10500";
            _jackpot = 10500;

            //reset reel pictures
            Reel1PictureBox.Load("merry_christmas.png");
            Reel2PictureBox.Load("merry_christmas.png");
            Reel3PictureBox.Load("merry_christmas.png");

            //reset nightmare tallys
            _shock = 0;
            _zero = 0;
            _lock = 0;
            _barrel = 0;
            _jack = 0;
            _sandyClaws = 0;
            _santa = 0;
            _oogie = 0;

            winnings = 0;
        }

        private void SpinButton_Click(object sender, EventArgs e)
        {
            if (_bet > _credits)
            {
                MessageBox.Show("You don't have enough Money to place that bet.", "Insufficient Funds");
            }

            else if (_bet <= _credits)
            {
                _credits -= _bet;
                Reels();
                determineWinnings();
            }
        }
    }
}
