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
            Card testCard = new Card(Rank.ACE, Suit.SPADES);

            pictureBox1.Image = Image.FromFile(
@"C:\Users\anapr\Documents\schooljaar2\periode3\OOP\BlackjackOOP\Cards\ace_of_spades.png");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


    

