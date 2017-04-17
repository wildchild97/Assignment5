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

        public SlotMachineForm()
        {
            InitializeComponent();
        }

        private void ChangeBetButton_Click(object sender, EventArgs e)
        {
            BetGroupBox.Visible = true;
        }

        private void Bet5Button_Click(object sender, EventArgs e)
        {
            _bet = 5;
            BetLabel.Text = "5";
            BetGroupBox.Visible = false;
        }

        private void Bet10Button_Click(object sender, EventArgs e)
        {
            _bet = 10;
            BetLabel.Text = "10";
            BetGroupBox.Visible = false;
        }

        private void Bet25Button_Click(object sender, EventArgs e)
        {
            _bet = 25;
            BetLabel.Text = "25";
            BetGroupBox.Visible = false;
        }

        private void Bet50Button_Click(object sender, EventArgs e)
        {
            _bet = 50;
            BetLabel.Text = "50";
            BetGroupBox.Visible = false;
        }

        private void Bet100Button_Click(object sender, EventArgs e)
        {
            _bet = 100;
            BetLabel.Text = "100";
            BetGroupBox.Visible = false;
        }

        private void Bet150Button_Click(object sender, EventArgs e)
        {
            _bet = 150;
            BetLabel.Text = "150";
            BetGroupBox.Visible = false;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {

        }
    }
}
