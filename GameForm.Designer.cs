namespace BlackjackOOP
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
<<<<<<< Updated upstream
=======
            textBox2 = new TextBox();
            button2 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
>>>>>>> Stashed changes
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
<<<<<<< Updated upstream
            button2 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
=======
>>>>>>> Stashed changes
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(textBox1);
            splitContainer1.Panel1.Controls.Add(button2);
            splitContainer1.Panel1.Controls.Add(button1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(button6);
            splitContainer1.Panel2.Controls.Add(button5);
            splitContainer1.Panel2.Controls.Add(button4);
            splitContainer1.Panel2.Controls.Add(button3);
            splitContainer1.Size = new Size(1166, 754);
            splitContainer1.SplitterDistance = 494;
            splitContainer1.TabIndex = 0;
            splitContainer1.SplitterMoved += splitContainer1_SplitterMoved;
            // 
<<<<<<< Updated upstream
=======
            // textBox2
            // 
            textBox2.Location = new Point(-16, 12);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(507, 39);
            textBox2.TabIndex = 6;
            textBox2.Text = "BlackJack";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // button2
            // 
            button2.ForeColor = Color.DarkOliveGreen;
            button2.Location = new Point(31, 625);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 1;
            button2.Text = "Hit";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.ForeColor = Color.IndianRed;
            button1.Location = new Point(269, 625);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.Yes;
            button1.Size = new Size(150, 46);
            button1.TabIndex = 0;
            button1.Text = "Stand";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(61, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(554, 39);
            textBox1.TabIndex = 2;
            textBox1.Text = "BlackJack";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
>>>>>>> Stashed changes
            // button6
            // 
            button6.Location = new Point(497, 466);
            button6.Name = "button6";
            button6.Size = new Size(150, 46);
            button6.TabIndex = 5;
            button6.Text = "Exit";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(497, 386);
            button5.Name = "button5";
            button5.Size = new Size(150, 46);
            button5.TabIndex = 4;
            button5.Text = "Tutorial";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(497, 310);
            button4.Name = "button4";
            button4.Size = new Size(150, 46);
            button4.TabIndex = 3;
            button4.Text = "Shuffle";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(497, 225);
            button3.Name = "button3";
            button3.Size = new Size(150, 46);
            button3.TabIndex = 2;
            button3.Text = "New Round";
            button3.UseVisualStyleBackColor = true;
            // 
<<<<<<< Updated upstream
            // button2
            // 
            button2.ForeColor = Color.DarkOliveGreen;
            button2.Location = new Point(31, 625);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 1;
            button2.Text = "Hit";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.ForeColor = Color.IndianRed;
            button1.Location = new Point(269, 625);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.Yes;
            button1.Size = new Size(150, 46);
            button1.TabIndex = 0;
            button1.Text = "Stand";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(171, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(875, 39);
            textBox1.TabIndex = 2;
            textBox1.Text = "BlackJack";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
=======
>>>>>>> Stashed changes
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
<<<<<<< Updated upstream
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1166, 754);
            Controls.Add(splitContainer1);
=======
            ClientSize = new Size(1166, 787);
>>>>>>> Stashed changes
            Name = "GameForm";
            Text = "GameForm";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button button2;
        private Button button1;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private TextBox textBox1;
    }
}