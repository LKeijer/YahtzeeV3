using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YahtzeeV3
{
    public partial class Yahtzee : Form
    {
        Image[] diceImages;
        int[] dice;
        Random rngeesus;
        public Yahtzee()
        {
            InitializeComponent();
        }

        private void Yahtzee_Load(object sender, EventArgs e)
        {
            diceImages = new Image[7];
            diceImages[0] = Properties.Resources.dice1_6;
            diceImages[1] = Properties.Resources.dice1;
            diceImages[2] = Properties.Resources.dice2;
            diceImages[3] = Properties.Resources.dice3;
            diceImages[4] = Properties.Resources.dice4;
            diceImages[5] = Properties.Resources.dice5;
            diceImages[6] = Properties.Resources.dice6;
            diceImages[7] = Properties.Resources.rollDice;
             
            dice = new int[5] { 0, 0, 0, 0, 0 };
        }

        private void rollDice_Click(object sender, EventArgs e)
        {

        }
    }
}

