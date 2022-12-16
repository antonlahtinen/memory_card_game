
namespace Memory_card_game
{
    partial class GameBoard
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PicHolder = new System.Windows.Forms.Panel();
            this.DupPic8 = new System.Windows.Forms.PictureBox();
            this.Pic8 = new System.Windows.Forms.PictureBox();
            this.DupPic7 = new System.Windows.Forms.PictureBox();
            this.Pic7 = new System.Windows.Forms.PictureBox();
            this.DupPic6 = new System.Windows.Forms.PictureBox();
            this.Pic6 = new System.Windows.Forms.PictureBox();
            this.DupPic5 = new System.Windows.Forms.PictureBox();
            this.Pic5 = new System.Windows.Forms.PictureBox();
            this.DupPic4 = new System.Windows.Forms.PictureBox();
            this.Pic4 = new System.Windows.Forms.PictureBox();
            this.DupPic3 = new System.Windows.Forms.PictureBox();
            this.Pic3 = new System.Windows.Forms.PictureBox();
            this.DupPic2 = new System.Windows.Forms.PictureBox();
            this.Pic2 = new System.Windows.Forms.PictureBox();
            this.DupPic1 = new System.Windows.Forms.PictureBox();
            this.Pic1 = new System.Windows.Forms.PictureBox();
            this.Score = new System.Windows.Forms.Label();
            this.ScoreNumber = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.TimeCounter = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.PicHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DupPic8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupPic7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupPic6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupPic5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupPic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupPic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupPic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupPic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(819, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(114, 29);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PicHolder
            // 
            this.PicHolder.BackColor = System.Drawing.Color.LightYellow;
            this.PicHolder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PicHolder.Controls.Add(this.DupPic8);
            this.PicHolder.Controls.Add(this.Pic8);
            this.PicHolder.Controls.Add(this.DupPic7);
            this.PicHolder.Controls.Add(this.Pic7);
            this.PicHolder.Controls.Add(this.DupPic6);
            this.PicHolder.Controls.Add(this.Pic6);
            this.PicHolder.Controls.Add(this.DupPic5);
            this.PicHolder.Controls.Add(this.Pic5);
            this.PicHolder.Controls.Add(this.DupPic4);
            this.PicHolder.Controls.Add(this.Pic4);
            this.PicHolder.Controls.Add(this.DupPic3);
            this.PicHolder.Controls.Add(this.Pic3);
            this.PicHolder.Controls.Add(this.DupPic2);
            this.PicHolder.Controls.Add(this.Pic2);
            this.PicHolder.Controls.Add(this.DupPic1);
            this.PicHolder.Controls.Add(this.Pic1);
            this.PicHolder.Location = new System.Drawing.Point(29, 132);
            this.PicHolder.Margin = new System.Windows.Forms.Padding(2);
            this.PicHolder.Name = "PicHolder";
            this.PicHolder.Size = new System.Drawing.Size(764, 692);
            this.PicHolder.TabIndex = 17;
            this.PicHolder.Paint += new System.Windows.Forms.PaintEventHandler(this.PicHolder_Paint);
            // 
            // DupPic8
            // 
            this.DupPic8.Location = new System.Drawing.Point(582, 519);
            this.DupPic8.Margin = new System.Windows.Forms.Padding(2);
            this.DupPic8.Name = "DupPic8";
            this.DupPic8.Size = new System.Drawing.Size(150, 150);
            this.DupPic8.TabIndex = 15;
            this.DupPic8.TabStop = false;
            this.DupPic8.Tag = "8";
            this.DupPic8.Click += new System.EventHandler(this.DupPic8_Click);
            // 
            // Pic8
            // 
            this.Pic8.Location = new System.Drawing.Point(397, 519);
            this.Pic8.Margin = new System.Windows.Forms.Padding(2);
            this.Pic8.Name = "Pic8";
            this.Pic8.Size = new System.Drawing.Size(150, 150);
            this.Pic8.TabIndex = 14;
            this.Pic8.TabStop = false;
            this.Pic8.Tag = "8";
            this.Pic8.Click += new System.EventHandler(this.Pic8_Click);
            // 
            // DupPic7
            // 
            this.DupPic7.Location = new System.Drawing.Point(214, 519);
            this.DupPic7.Margin = new System.Windows.Forms.Padding(2);
            this.DupPic7.Name = "DupPic7";
            this.DupPic7.Size = new System.Drawing.Size(150, 150);
            this.DupPic7.TabIndex = 13;
            this.DupPic7.TabStop = false;
            this.DupPic7.Tag = "7";
            this.DupPic7.Click += new System.EventHandler(this.DupPic7_Click);
            // 
            // Pic7
            // 
            this.Pic7.Location = new System.Drawing.Point(31, 519);
            this.Pic7.Margin = new System.Windows.Forms.Padding(2);
            this.Pic7.Name = "Pic7";
            this.Pic7.Size = new System.Drawing.Size(150, 150);
            this.Pic7.TabIndex = 12;
            this.Pic7.TabStop = false;
            this.Pic7.Tag = "7";
            this.Pic7.Click += new System.EventHandler(this.Pic7_Click);
            // 
            // DupPic6
            // 
            this.DupPic6.Location = new System.Drawing.Point(582, 353);
            this.DupPic6.Margin = new System.Windows.Forms.Padding(2);
            this.DupPic6.Name = "DupPic6";
            this.DupPic6.Size = new System.Drawing.Size(150, 150);
            this.DupPic6.TabIndex = 11;
            this.DupPic6.TabStop = false;
            this.DupPic6.Tag = "6";
            this.DupPic6.Click += new System.EventHandler(this.DupPic6_Click);
            // 
            // Pic6
            // 
            this.Pic6.Location = new System.Drawing.Point(397, 353);
            this.Pic6.Margin = new System.Windows.Forms.Padding(2);
            this.Pic6.Name = "Pic6";
            this.Pic6.Size = new System.Drawing.Size(150, 150);
            this.Pic6.TabIndex = 10;
            this.Pic6.TabStop = false;
            this.Pic6.Tag = "6";
            this.Pic6.Click += new System.EventHandler(this.Pic6_Click);
            // 
            // DupPic5
            // 
            this.DupPic5.Location = new System.Drawing.Point(214, 353);
            this.DupPic5.Margin = new System.Windows.Forms.Padding(2);
            this.DupPic5.Name = "DupPic5";
            this.DupPic5.Size = new System.Drawing.Size(150, 150);
            this.DupPic5.TabIndex = 9;
            this.DupPic5.TabStop = false;
            this.DupPic5.Tag = "5";
            this.DupPic5.Click += new System.EventHandler(this.DupPic5_Click);
            // 
            // Pic5
            // 
            this.Pic5.Location = new System.Drawing.Point(31, 353);
            this.Pic5.Margin = new System.Windows.Forms.Padding(2);
            this.Pic5.Name = "Pic5";
            this.Pic5.Size = new System.Drawing.Size(150, 150);
            this.Pic5.TabIndex = 8;
            this.Pic5.TabStop = false;
            this.Pic5.Tag = "5";
            this.Pic5.Click += new System.EventHandler(this.Pic5_Click);
            // 
            // DupPic4
            // 
            this.DupPic4.Location = new System.Drawing.Point(582, 186);
            this.DupPic4.Margin = new System.Windows.Forms.Padding(2);
            this.DupPic4.Name = "DupPic4";
            this.DupPic4.Size = new System.Drawing.Size(150, 150);
            this.DupPic4.TabIndex = 7;
            this.DupPic4.TabStop = false;
            this.DupPic4.Tag = "4";
            this.DupPic4.Click += new System.EventHandler(this.DupPic4_Click);
            // 
            // Pic4
            // 
            this.Pic4.Location = new System.Drawing.Point(397, 186);
            this.Pic4.Margin = new System.Windows.Forms.Padding(2);
            this.Pic4.Name = "Pic4";
            this.Pic4.Size = new System.Drawing.Size(150, 150);
            this.Pic4.TabIndex = 6;
            this.Pic4.TabStop = false;
            this.Pic4.Tag = "4";
            this.Pic4.Click += new System.EventHandler(this.Pic4_Click);
            // 
            // DupPic3
            // 
            this.DupPic3.Location = new System.Drawing.Point(214, 186);
            this.DupPic3.Margin = new System.Windows.Forms.Padding(2);
            this.DupPic3.Name = "DupPic3";
            this.DupPic3.Size = new System.Drawing.Size(150, 150);
            this.DupPic3.TabIndex = 5;
            this.DupPic3.TabStop = false;
            this.DupPic3.Tag = "3";
            this.DupPic3.Click += new System.EventHandler(this.DupPic3_Click);
            // 
            // Pic3
            // 
            this.Pic3.Location = new System.Drawing.Point(31, 186);
            this.Pic3.Margin = new System.Windows.Forms.Padding(2);
            this.Pic3.Name = "Pic3";
            this.Pic3.Size = new System.Drawing.Size(150, 150);
            this.Pic3.TabIndex = 4;
            this.Pic3.TabStop = false;
            this.Pic3.Tag = "3";
            this.Pic3.Click += new System.EventHandler(this.Pic3_Click);
            // 
            // DupPic2
            // 
            this.DupPic2.Location = new System.Drawing.Point(582, 20);
            this.DupPic2.Margin = new System.Windows.Forms.Padding(2);
            this.DupPic2.Name = "DupPic2";
            this.DupPic2.Size = new System.Drawing.Size(150, 150);
            this.DupPic2.TabIndex = 3;
            this.DupPic2.TabStop = false;
            this.DupPic2.Tag = "2";
            this.DupPic2.Click += new System.EventHandler(this.DupPic2_Click);
            // 
            // Pic2
            // 
            this.Pic2.Location = new System.Drawing.Point(397, 20);
            this.Pic2.Margin = new System.Windows.Forms.Padding(2);
            this.Pic2.Name = "Pic2";
            this.Pic2.Size = new System.Drawing.Size(150, 150);
            this.Pic2.TabIndex = 2;
            this.Pic2.TabStop = false;
            this.Pic2.Tag = "2";
            this.Pic2.Click += new System.EventHandler(this.Pic2_Click);
            // 
            // DupPic1
            // 
            this.DupPic1.Location = new System.Drawing.Point(214, 20);
            this.DupPic1.Margin = new System.Windows.Forms.Padding(2);
            this.DupPic1.Name = "DupPic1";
            this.DupPic1.Size = new System.Drawing.Size(150, 150);
            this.DupPic1.TabIndex = 1;
            this.DupPic1.TabStop = false;
            this.DupPic1.Tag = "1";
            this.DupPic1.Click += new System.EventHandler(this.DupPic1_Click);
            // 
            // Pic1
            // 
            this.Pic1.Location = new System.Drawing.Point(31, 20);
            this.Pic1.Margin = new System.Windows.Forms.Padding(2);
            this.Pic1.Name = "Pic1";
            this.Pic1.Size = new System.Drawing.Size(150, 150);
            this.Pic1.TabIndex = 0;
            this.Pic1.TabStop = false;
            this.Pic1.Tag = "1";
            this.Pic1.Click += new System.EventHandler(this.Pic1_Click);
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Harlow Solid Italic", 28F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Score.Location = new System.Drawing.Point(29, 48);
            this.Score.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(156, 71);
            this.Score.TabIndex = 18;
            this.Score.Text = "Score";
            // 
            // ScoreNumber
            // 
            this.ScoreNumber.AutoSize = true;
            this.ScoreNumber.Font = new System.Drawing.Font("Harlow Solid Italic", 28F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.ScoreNumber.Location = new System.Drawing.Point(191, 48);
            this.ScoreNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ScoreNumber.Name = "ScoreNumber";
            this.ScoreNumber.Size = new System.Drawing.Size(56, 71);
            this.ScoreNumber.TabIndex = 19;
            this.ScoreNumber.Text = "0";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harlow Solid Italic", 28F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(565, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 71);
            this.label1.TabIndex = 20;
            this.label1.Text = "Time";
            // 
            // TimeCounter
            // 
            this.TimeCounter.AutoSize = true;
            this.TimeCounter.Font = new System.Drawing.Font("Harlow Solid Italic", 28F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.TimeCounter.Location = new System.Drawing.Point(721, 48);
            this.TimeCounter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TimeCounter.Name = "TimeCounter";
            this.TimeCounter.Size = new System.Drawing.Size(82, 71);
            this.TimeCounter.TabIndex = 21;
            this.TimeCounter.Text = "60";
            // 
            // timer3
            // 
            this.timer3.Interval = 500;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // GameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(819, 862);
            this.Controls.Add(this.TimeCounter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ScoreNumber);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.PicHolder);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GameBoard";
            this.Text = "Memory Game";
            this.Load += new System.EventHandler(this.GameBoard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.PicHolder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DupPic8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupPic7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupPic6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupPic5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupPic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupPic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupPic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupPic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Timer timer1;
        private Panel PicHolder;
        private Label Score;
        private PictureBox DupPic8;
        private PictureBox Pic8;
        private PictureBox DupPic7;
        private PictureBox Pic7;
        private PictureBox DupPic6;
        private PictureBox Pic6;
        private PictureBox DupPic5;
        private PictureBox Pic5;
        private PictureBox DupPic4;
        private PictureBox Pic4;
        private PictureBox DupPic3;
        private PictureBox Pic3;
        private PictureBox DupPic2;
        private PictureBox Pic2;
        private PictureBox DupPic1;
        private PictureBox Pic1;
        private Label ScoreNumber;
        private System.Windows.Forms.Timer timer2;
        private Label label1;
        private Label TimeCounter;
        private ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.Timer timer3;
    }
}

