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

        public SlotMachineForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// this method makes the bet buttons visible when pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeBetButton_Click(object sender, EventArgs e)
        {
            BetGroupBox.Visible = true;
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
        }
    }
}
