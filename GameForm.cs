using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BlackjackOOP
{
    public partial class GameForm : Form
    {
        private Shoe shoe;
        private Hand playerHand;
        private Hand dealerHand;

        private int correctPoints = 0;
        private int penaltyPoints = 0;

        public GameForm()
        {
            InitializeComponent();
        }

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

            return $@"C:\Users\anapr\Documents\schooljaar2\periode3\OOP\BlackjackOOP\Cards\{rank}_of_{suit}.png";
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            shoe = new Shoe(2);
            playerHand = new Hand();
            dealerHand = new Hand();

            UpdatePointsUI();
            StartNewRound();
        }

        private void StartNewRound()
        {
            if (shoe.Count < 10)
            {
                shoe = new Shoe(2);
            }

            button1.Enabled = true; // Stand
            button2.Enabled = true; // Hit

            playerHand.Clear();
            dealerHand.Clear();

            playerHand.AddCard(shoe.DealCard());
            dealerHand.AddCard(shoe.DealCard());
            playerHand.AddCard(shoe.DealCard());
            dealerHand.AddCard(shoe.DealCard());

            UpdateUI();
            UpdatePointsUI();
        }

        private void EndRound()
        {
            button1.Enabled = false;
            button2.Enabled = false;
        }

        private string GetCorrectAction()
        {
            int playerValue = playerHand.GetValue();

            if (playerValue < 17)
            {
                return "Hit";
            }

            return "Stand";
        }

        private void CheckDealerChoice(string chosenAction)
        {
            string correctAction = GetCorrectAction();

            if (chosenAction == correctAction)
            {
                correctPoints++;
                MessageBox.Show("Correct choice.");
            }
            else
            {
                penaltyPoints++;
                MessageBox.Show("Wrong choice.");
            }

            UpdatePointsUI();
        }

        private void UpdatePointsUI()
        {
            label1.Text = "Correct: " + correctPoints.ToString();
            label2.Text = "Penalty: " + penaltyPoints.ToString();
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
            {
                string path = GetCardImagePath(playerHand.Cards[0]);
                if (File.Exists(path))
                    pictureBox1.Image = Image.FromFile(path);
            }

            if (playerHand.Cards.Count > 1)
            {
                string path = GetCardImagePath(playerHand.Cards[1]);
                if (File.Exists(path))
                    pictureBox2.Image = Image.FromFile(path);
            }

            if (playerHand.Cards.Count > 2)
            {
                string path = GetCardImagePath(playerHand.Cards[2]);
                if (File.Exists(path))
                    pictureBox5.Image = Image.FromFile(path);
            }

            if (playerHand.Cards.Count > 3)
            {
                string path = GetCardImagePath(playerHand.Cards[3]);
                if (File.Exists(path))
                    pictureBox6.Image = Image.FromFile(path);
            }

            if (dealerHand.Cards.Count > 0)
            {
                string path = GetCardImagePath(dealerHand.Cards[0]);
                if (File.Exists(path))
                    pictureBox3.Image = Image.FromFile(path);
            }

            if (dealerHand.Cards.Count > 1)
            {
                string path = GetCardImagePath(dealerHand.Cards[1]);
                if (File.Exists(path))
                    pictureBox4.Image = Image.FromFile(path);
            }

            if (dealerHand.Cards.Count > 2)
            {
                string path = GetCardImagePath(dealerHand.Cards[2]);
                if (File.Exists(path))
                    pictureBox7.Image = Image.FromFile(path);
            }

            if (dealerHand.Cards.Count > 3)
            {
                string path = GetCardImagePath(dealerHand.Cards[3]);
                if (File.Exists(path))
                    pictureBox8.Image = Image.FromFile(path);
            }

            textBox2.Text = "Player total: " + playerHand.GetValue().ToString();
            textBox1.Text = "Dealer total: " + dealerHand.GetValue().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CheckDealerChoice("Hit");

            playerHand.AddCard(shoe.DealCard());
            UpdateUI();

            if (playerHand.IsBust())
            {
                MessageBox.Show("Player bust. Round over.");
                EndRound();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckDealerChoice("Stand");
            MessageBox.Show("Player stands. Round over.");
            EndRound();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StartNewRound();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            shoe = new Shoe(2);
            StartNewRound();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
    }
}