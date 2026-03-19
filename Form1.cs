namespace BlackjackOOP
{
    public partial class Form1 : Form
    {
        Card card1;
        public Form1()
        {
            InitializeComponent();
            card1 = new Card(Rank.ACE, Suit.SPADES);
            Card card2 = new Card(Rank.TWO, Suit.SPADES);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            GameForm gameForm = new GameForm();
            gameForm.Show();

            // opțional: ascunzi prima fereastră
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {



            label1.Text = "Click the Start Game Button to start the game";
            label1.BackColor = Color.LightGreen;

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
