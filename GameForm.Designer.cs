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
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            textBox2 = new TextBox();
            button2 = new Button();
            button1 = new Button();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            textBox1 = new TextBox();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
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
            splitContainer1.Panel1.BackColor = Color.RosyBrown;
            splitContainer1.Panel1.Controls.Add(pictureBox2);
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            splitContainer1.Panel1.Controls.Add(textBox2);
            splitContainer1.Panel1.Controls.Add(button2);
            splitContainer1.Panel1.Controls.Add(button1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.RosyBrown;
            splitContainer1.Panel2.Controls.Add(pictureBox4);
            splitContainer1.Panel2.Controls.Add(pictureBox3);
            splitContainer1.Panel2.Controls.Add(textBox1);
            splitContainer1.Panel2.Controls.Add(button6);
            splitContainer1.Panel2.Controls.Add(button5);
            splitContainer1.Panel2.Controls.Add(button4);
            splitContainer1.Panel2.Controls.Add(button3);
            splitContainer1.Size = new Size(1157, 784);
            splitContainer1.SplitterDistance = 490;
            splitContainer1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(248, 386);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(198, 228);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(12, 386);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(198, 228);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Snow;
            textBox2.Location = new Point(-16, 12);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(507, 39);
            textBox2.TabIndex = 6;
            textBox2.Text = "Player cards";
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.TextChanged += textBox2_TextChanged;
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
            // pictureBox4
            // 
            pictureBox4.BorderStyle = BorderStyle.FixedSingle;
            pictureBox4.Location = new Point(293, 101);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(198, 228);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Location = new Point(34, 101);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(198, 228);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Snow;
            textBox1.Location = new Point(61, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(554, 39);
            textBox1.TabIndex = 2;
            textBox1.Text = "Dealer cards";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
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
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1157, 784);
            Controls.Add(splitContainer1);
            Name = "GameForm";
            Text = "GameForm";
            Load += GameForm_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
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
        private TextBox textBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
    }
}