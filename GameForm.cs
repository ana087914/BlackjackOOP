using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;



    namespace BlackjackOOP
    {
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
        }
        private Shoe shoe;
        private Hand playerHand;
        private Hand dealerHand;
        private string GetCardImagePath(Card card)
        {
            string rank = "";

            switch (card.Rank)
            {
                case Rank.ACE: rank = "ace"; break;
                case Rank.TWO: rank = "2"; break;
                case Rank.THREE: rank = "3"; break;
                case Rank.FOUR: rank = "4"; break;
                case Rank.FIVE: rank = "5"; break;
                case Rank.SIX: rank = "6"; break;
                case Rank.SEVEN: rank = "7"; break;
                case Rank.EIGHT: rank = "8"; break;
                case Rank.NINE: rank = "9"; break;
                case Rank.TEN: rank = "10"; break;
                case Rank.JACK: rank = "jack"; break;
                case Rank.QUEEN: rank = "queen"; break;
                case Rank.KING: rank = "king"; break;
            }

            string suit = card.Suit.ToString().ToLower();

            return $@"Cards\{rank}_of_{suit}.png";
        }
        private void GameForm_Load(object sender, EventArgs e)
        {
            shoe = new Shoe(2);
            playerHand = new Hand();
            dealerHand = new Hand();

            StartNewRound();
        }
        private void StartNewRound()
        {
            if (shoe.Count < 10)
            {
                shoe = new Shoe(2);
            }

            button1.Enabled = true;
            button2.Enabled = true;

            playerHand.Clear();
            dealerHand.Clear();

            playerHand.AddCard(shoe.DealCard());
            dealerHand.AddCard(shoe.DealCard());
            playerHand.AddCard(shoe.DealCard());
            dealerHand.AddCard(shoe.DealCard());

            UpdateUI();

            if (playerHand.GetValue() == 21)
            {
                MessageBox.Show("Blackjack! Player wins.");
                EndRound();
            }
        }
        private void EndRound()
        {
            button1.Enabled = false; // Stand
            button2.Enabled = false; // Hit
        }
        private void UpdateUI()
        {
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
            pictureBox6.Image = null;
            pictureBox7.Image = null;
            pictureBox8.Image = null;

            if (playerHand.Cards.Count > 0)
                pictureBox1.Image = Image.FromFile(GetCardImagePath(playerHand.Cards[0]));

            if (playerHand.Cards.Count > 1)
                pictureBox2.Image = Image.FromFile(GetCardImagePath(playerHand.Cards[1]));

            if (playerHand.Cards.Count > 2)
                pictureBox5.Image = Image.FromFile(GetCardImagePath(playerHand.Cards[2]));

            if (playerHand.Cards.Count > 3)
                pictureBox6.Image = Image.FromFile(GetCardImagePath(playerHand.Cards[3]));

            if (dealerHand.Cards.Count > 0)
                pictureBox3.Image = Image.FromFile(GetCardImagePath(dealerHand.Cards[0]));

            if (dealerHand.Cards.Count > 1)
                pictureBox4.Image = Image.FromFile(GetCardImagePath(dealerHand.Cards[1]));

            if (dealerHand.Cards.Count > 2)
                pictureBox7.Image = Image.FromFile(GetCardImagePath(dealerHand.Cards[2]));

            if (dealerHand.Cards.Count > 3)
                pictureBox8.Image = Image.FromFile(GetCardImagePath(dealerHand.Cards[3]));

            textBox2.Text = "Player: " + playerHand.GetValue().ToString();
            textBox1.Text = "Dealer: " + dealerHand.GetValue().ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            playerHand.AddCard(shoe.DealCard());
            UpdateUI();

            if (playerHand.IsBust())
            {
                MessageBox.Show("Player bust! Dealer wins.");
                EndRound();
            }
        }
        private void ShowResult()
        {
            int playerValue = playerHand.GetValue();
            int dealerValue = dealerHand.GetValue();

            if (playerHand.IsBust())
            {
                MessageBox.Show("Player loses.");
            }
            else if (dealerHand.IsBust())
            {
                MessageBox.Show("Dealer bust! Player wins.");
            }
            else if (playerValue > dealerValue)
            {
                MessageBox.Show("Player wins.");
            }
            else if (dealerValue > playerValue)
            {
                MessageBox.Show("Dealer wins.");
            }
            else
            {
                MessageBox.Show("Draw.");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            while (dealerHand.GetValue() < 17)
            {
                dealerHand.AddCard(shoe.DealCard());
            }

            UpdateUI();
            ShowResult();
            EndRound();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            StartNewRound();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


    

