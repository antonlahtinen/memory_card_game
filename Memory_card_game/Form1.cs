namespace Memory_card_game
{
    public partial class GameBoard : Form
    {
        //variables
        Random paikka = new Random();
        List<Point> points = new List<Point>();

        PictureBox? pendingImage1;
        PictureBox? pendingImage2;

        PictureBox? Ready1;
        PictureBox? Ready2;
        PictureBox? Ready3;
        PictureBox? Ready4;
        PictureBox? Ready5;
        PictureBox? Ready6;
        PictureBox? Ready7;
        PictureBox? Ready8;
        PictureBox? Ready9;
        PictureBox? Ready10;
        PictureBox? Ready11;
        PictureBox? Ready12;
        PictureBox? Ready13;
        PictureBox? Ready14;
        PictureBox? Ready15;
        PictureBox? Ready16;

        bool again = false; //Pelaa uudestaan yes or no
        public GameBoard()
        {
            InitializeComponent();
        }

        private void GameBoard_Load(object sender, EventArgs e)
        {
            PicHolder.Enabled = false;
            foreach (PictureBox picture in PicHolder.Controls)
            {
                picture.Enabled = false;
                points.Add(picture.Location);
            }
            foreach (PictureBox picture in PicHolder.Controls)
            {
                int next = paikka.Next(points.Count);
                Point p = points[next];
                picture.Location = p;
                points.Remove(p);
            }
            timer1.Start();

            Pic1.Image = Properties.Resources.Pic1;
            DupPic1.Image = Properties.Resources.Pic1;
            Pic2.Image = Properties.Resources.Pic2;
            DupPic2.Image = Properties.Resources.Pic2;
            Pic3.Image = Properties.Resources.Pic3;
            DupPic3.Image = Properties.Resources.Pic3;
            Pic4.Image = Properties.Resources.Pic4;
            DupPic4.Image = Properties.Resources.Pic4;
            Pic5.Image = Properties.Resources.Pic5;
            DupPic5.Image = Properties.Resources.Pic5;
            Pic6.Image = Properties.Resources.Pic6;
            DupPic6.Image = Properties.Resources.Pic6;
            Pic7.Image = Properties.Resources.Pic7;
            DupPic7.Image = Properties.Resources.Pic7;
            Pic8.Image = Properties.Resources.Pic8;
            DupPic8.Image = Properties.Resources.Pic8;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Start();
            PicHolder.Enabled = true;
            foreach (PictureBox picture in PicHolder.Controls)
            {
                picture.Enabled = true;
                picture.Cursor = Cursors.Hand;
                picture.Image = Properties.Resources.Cover;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int timer = Convert.ToInt32(TimeCounter.Text);
            timer = timer - 1;
            TimeCounter.Text = Convert.ToString(timer);
            if (timer == 0)
            {
                timer2.Stop();
                MessageBox.Show("You lost, better luck next time!", "Game Over");
            }
        }

        public void CheckTags()
        {

        }
        public void CheckWinState()
        {
            
            if (Pic1.Enabled == false && DupPic1.Enabled == false && Pic2.Enabled == false && DupPic2.Enabled == false && Pic3.Enabled == false && DupPic3.Enabled == false
                 && Pic4.Enabled == false && DupPic4.Enabled == false && Pic5.Enabled == false && DupPic5.Enabled == false && Pic6.Enabled == false && DupPic6.Enabled == false
                  && Pic7.Enabled == false && DupPic7.Enabled == false && Pic8.Enabled == false && DupPic8.Enabled == false)
            {
                timer2.Stop();
                MessageBox.Show("You got " + ScoreNumber.Text + " points!!", "You won!");
            }
        }

        private void PicHolder_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Pic1_Click(object sender, EventArgs e)
        {
            Pic1.Image = Properties.Resources.Pic1;
            if (pendingImage1 == null)
            {
                pendingImage1 = Pic1;
                Pic1.Enabled = false;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = Pic1;
                Pic1.Enabled = false;
            }
            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage1 = null;
                    pendingImage2 = null;
                    Ready1 = Pic1;
                    Ready2 = DupPic1;
                    Ready1.Enabled = false;
                    Ready2.Enabled = false;
                    ScoreNumber.Text = Convert.ToString(Convert.ToInt32(ScoreNumber.Text) + 10);
                    CheckWinState();
                }
                else
                {
                    timer3.Start();
                    PicHolder.Enabled = false;
                    ScoreNumber.Text = Convert.ToString(Convert.ToInt32(ScoreNumber.Text) - 1);
                }
            }
        }
        private void DupPic1_Click(object sender, EventArgs e)
        {
            DupPic1.Image = Properties.Resources.Pic1;
            if (pendingImage1 == null)
            {
                pendingImage1 = DupPic1;
                DupPic1.Enabled = false;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = DupPic1;
                DupPic1.Enabled = false;
            }
            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage1 = null;
                    pendingImage2 = null;
                    Ready1 = Pic1;
                    Ready2 = DupPic1;
                    Ready1.Enabled = false;
                    Ready2.Enabled = false;
                    ScoreNumber.Text = Convert.ToString(Convert.ToInt32(ScoreNumber.Text) + 10);
                    CheckWinState();
                }
                else
                {

                    timer3.Start();
                    PicHolder.Enabled = false;
                    ScoreNumber.Text = Convert.ToString(Convert.ToInt32(ScoreNumber.Text) - 1);
                }
            }
        }

        private void Pic2_Click(object sender, EventArgs e)
        {
            Pic2.Image = Properties.Resources.Pic2;
            if (pendingImage1 == null)
            {
                pendingImage1 = Pic2;
                Pic2.Enabled = false;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = Pic2;
                Pic2.Enabled = false;
            }
            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage1 = null;
                    pendingImage2 = null;
                    Ready3 = Pic2;
                    Ready4 = DupPic2;
                    Ready3.Enabled = false;
                    Ready4.Enabled = false;
                    ScoreNumber.Text = Convert.ToString(Convert.ToInt32(ScoreNumber.Text) + 10);
                    CheckWinState();
                }
                else
                {
                    timer3.Start();
                    PicHolder.Enabled = false;
                    ScoreNumber.Text = Convert.ToString(Convert.ToInt32(ScoreNumber.Text) - 1);
                }
            }
        }
        private void DupPic2_Click(object sender, EventArgs e)
        {
            DupPic2.Image = Properties.Resources.Pic2;
            if (pendingImage1 == null)
            {
                pendingImage1 = DupPic2;
                DupPic2.Enabled = false;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = DupPic2;
                DupPic2.Enabled = false;
            }
            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage1 = null;
                    pendingImage2 = null;
                    Ready3 = Pic2;
                    Ready4 = DupPic2;
                    Ready3.Enabled = false;
                    Ready4.Enabled = false;
                    ScoreNumber.Text = Convert.ToString(Convert.ToInt32(ScoreNumber.Text) + 10);
                    CheckWinState();
                }
                else
                {
                    timer3.Start();
                    PicHolder.Enabled = false;
                    ScoreNumber.Text = Convert.ToString(Convert.ToInt32(ScoreNumber.Text) - 1);
                }
            }
        }
        private void Pic3_Click(object sender, EventArgs e)
        {
            Pic3.Image = Properties.Resources.Pic3;
            if (pendingImage1 == null)
            {
                pendingImage1 = Pic3;
                Pic3.Enabled = false;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = Pic3;
                Pic3.Enabled = false;
            }
            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage1 = null;
                    pendingImage2 = null;
                    Ready5 = Pic3;
                    Ready6 = DupPic3;
                    Ready5.Enabled = false;
                    Ready6.Enabled = false;
                    ScoreNumber.Text = Convert.ToString(Convert.ToInt32(ScoreNumber.Text) + 10);
                    CheckWinState();
                }
                else
                {
                    timer3.Start();
                    PicHolder.Enabled = false;
                    ScoreNumber.Text = Convert.ToString(Convert.ToInt32(ScoreNumber.Text) - 1);
                }
            }
        }

        private void DupPic3_Click(object sender, EventArgs e)
        {
            DupPic3.Image = Properties.Resources.Pic3;
            if (pendingImage1 == null)
            {
                pendingImage1 = DupPic3;
                DupPic3.Enabled = false;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = DupPic3;
                DupPic3.Enabled = false;
            }
            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage1 = null;
                    pendingImage2 = null;
                    Ready5 = Pic3;
                    Ready6 = DupPic3;
                    Ready5.Enabled = false;
                    Ready6.Enabled = false;
                    ScoreNumber.Text = Convert.ToString(Convert.ToInt32(ScoreNumber.Text) + 10);
                    CheckWinState();
                }
                else
                {
                    timer3.Start();
                    PicHolder.Enabled = false;
                    ScoreNumber.Text = Convert.ToString(Convert.ToInt32(ScoreNumber.Text) - 1);
                }
            }
        }
        private void Pic4_Click(object sender, EventArgs e)
        {
            Pic4.Image = Properties.Resources.Pic4;
            if (pendingImage1 == null)
            {
                pendingImage1 = Pic4;
                Pic4.Enabled = false;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = Pic4;
                Pic4.Enabled = false;
            }
            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage1 = null;
                    pendingImage2 = null;
                    Ready7 = Pic4;
                    Ready8 = DupPic4;
                    Ready7.Enabled = false;
                    Ready8.Enabled = false;
                    ScoreNumber.Text = Convert.ToString(Convert.ToInt32(ScoreNumber.Text) + 10);
                    CheckWinState();
                }
                else
                {
                    timer3.Start();
                    PicHolder.Enabled = false;
                    ScoreNumber.Text = Convert.ToString(Convert.ToInt32(ScoreNumber.Text) - 1);
                }
            }
        }
        private void DupPic4_Click(object sender, EventArgs e)
        {
            DupPic4.Image = Properties.Resources.Pic4;
            if (pendingImage1 == null)
            {
                pendingImage1 = DupPic4;
                DupPic4.Enabled = false;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = DupPic4;
                DupPic4.Enabled = false;
            }
            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage1 = null;
                    pendingImage2 = null;
                    Ready7 = Pic4;
                    Ready8 = DupPic4;
                    Ready7.Enabled = false;
                    Ready8.Enabled = false;
                    ScoreNumber.Text = Convert.ToString(Convert.ToInt32(ScoreNumber.Text) + 10);
                    CheckWinState();
                }
                else
                {
                    timer3.Start();
                    PicHolder.Enabled = false;
                    ScoreNumber.Text = Convert.ToString(Convert.ToInt32(ScoreNumber.Text) - 1);
                }
            }
        }
        private void Pic5_Click(object sender, EventArgs e)
        {
            Pic5.Image = Properties.Resources.Pic5;
            if (pendingImage1 == null)
            {
                pendingImage1 = Pic5;
                Pic5.Enabled = false;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = Pic5;
                Pic5.Enabled = false;
            }
            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage1 = null;
                    pendingImage2 = null;
                    Ready9 = Pic5;
                    Ready10 = DupPic5;
                    Ready9.Enabled = false;
                    Ready10.Enabled = false;
                    ScoreNumber.Text = Convert.ToString(Convert.ToInt32(ScoreNumber.Text) + 10);
                    CheckWinState();
                }
                else
                {
                    timer3.Start();
                    PicHolder.Enabled = false;
                    ScoreNumber.Text = Convert.ToString(Convert.ToInt32(ScoreNumber.Text) - 1);
                }
            }
        }
        private void DupPic5_Click(object sender, EventArgs e)
        {
            DupPic5.Image = Properties.Resources.Pic5;
            if (pendingImage1 == null)
            {
                pendingImage1 = DupPic5;
                DupPic5.Enabled = false;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = DupPic5;
                DupPic5.Enabled = false;
            }
            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage1 = null;
                    pendingImage2 = null;
                    Ready9 = Pic5;
                    Ready10 = DupPic5;
                    Ready9.Enabled = false;
                    Ready10.Enabled = false;
                    ScoreNumber.Text = Convert.ToString(Convert.ToInt32(ScoreNumber.Text) + 10);
                    CheckWinState();
                }
                else
                {
                    timer3.Start();
                    PicHolder.Enabled = false;
                    ScoreNumber.Text = Convert.ToString(Convert.ToInt32(ScoreNumber.Text) - 1);
                }
            }
        }
        private void Pic6_Click(object sender, EventArgs e)
        {
            Pic6.Image = Properties.Resources.Pic6;
            if (pendingImage1 == null)
            {
                pendingImage1 = Pic6;
                Pic6.Enabled = false;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = Pic6;
                Pic6.Enabled = false;
            }
            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage1 = null;
                    pendingImage2 = null;
                    Ready11 = Pic6;
                    Ready12 = DupPic6;
                    Ready11.Enabled = false;
                    Ready12.Enabled = false;
                    ScoreNumber.Text = Convert.ToString(Convert.ToInt32(ScoreNumber.Text) + 10);
                    CheckWinState();
                }
                else
                {
                    timer3.Start();
                    PicHolder.Enabled = false;
                    ScoreNumber.Text = Convert.ToString(Convert.ToInt32(ScoreNumber.Text) - 1);
                }
            }
        }

        private void DupPic6_Click(object sender, EventArgs e)
        {
            DupPic6.Image = Properties.Resources.Pic6;
            if (pendingImage1 == null)
            {
                pendingImage1 = DupPic6;
                DupPic6.Enabled = false;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = DupPic6;
                DupPic6.Enabled = false;
            }
            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage1 = null;
                    pendingImage2 = null;
                    Ready11 = Pic6;
                    Ready12 = DupPic6;
                    Ready11.Enabled = false;
                    Ready12.Enabled = false;
                    ScoreNumber.Text = Convert.ToString(Convert.ToInt32(ScoreNumber.Text) + 10);
                    CheckWinState();
                }
                else
                {
                    timer3.Start();
                    PicHolder.Enabled = false;
                    ScoreNumber.Text = Convert.ToString(Convert.ToInt32(ScoreNumber.Text) - 1);
                }
            }
        }
        private void Pic7_Click(object sender, EventArgs e)
        {
            Pic7.Image = Properties.Resources.Pic7;
            if (pendingImage1 == null)
            {
                pendingImage1 = Pic7;
                Pic7.Enabled = false;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = Pic7;
                Pic7.Enabled = false;
            }
            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage1 = null;
                    pendingImage2 = null;
                    Ready13 = Pic7;
                    Ready14 = DupPic7;
                    Ready13.Enabled = false;
                    Ready14.Enabled = false;
                    ScoreNumber.Text = Convert.ToString(Convert.ToInt32(ScoreNumber.Text) + 10);
                    CheckWinState();
                }
                else
                {
                    timer3.Start();
                    PicHolder.Enabled = false;
                    ScoreNumber.Text = Convert.ToString(Convert.ToInt32(ScoreNumber.Text) - 1);
                }
            }
        }

        private void DupPic7_Click(object sender, EventArgs e)
        {
            DupPic7.Image = Properties.Resources.Pic7;
            if (pendingImage1 == null)
            {
                pendingImage1 = DupPic7;
                DupPic7.Enabled = false;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = DupPic7;
                DupPic7.Enabled = false;
            }
            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage1 = null;
                    pendingImage2 = null;
                    Ready13 = Pic7;
                    Ready14 = DupPic7;
                    Ready13.Enabled = false;
                    Ready14.Enabled = false;
                    ScoreNumber.Text = Convert.ToString(Convert.ToInt32(ScoreNumber.Text) + 10);
                    CheckWinState();
                }
                else
                {
                    timer3.Start();
                    PicHolder.Enabled = false;
                    ScoreNumber.Text = Convert.ToString(Convert.ToInt32(ScoreNumber.Text) - 1);
                }
            }
        }

        private void Pic8_Click(object sender, EventArgs e)
        {
            Pic8.Image = Properties.Resources.Pic8;
            if (pendingImage1 == null)
            {
                pendingImage1 = Pic8;
                Pic8.Enabled = false;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = Pic8;
                Pic8.Enabled = false;
            }
            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage1 = null;
                    pendingImage2 = null;
                    Ready15 = Pic8;
                    Ready16 = DupPic8;
                    Ready15.Enabled = false;
                    Ready16.Enabled = false;
                    ScoreNumber.Text = Convert.ToString(Convert.ToInt32(ScoreNumber.Text) + 10);
                    CheckWinState();
                }
                else
                {
                    PicHolder.Enabled = false;
                    ScoreNumber.Text = Convert.ToString(Convert.ToInt32(ScoreNumber.Text) - 1);
                    timer3.Start();
                }
            }
        }
        private void DupPic8_Click(object sender, EventArgs e)
        {
            DupPic8.Image = Properties.Resources.Pic8;
            if (pendingImage1 == null)
            {
                pendingImage1 = DupPic8;
                DupPic8.Enabled = false;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = DupPic8;
                DupPic8.Enabled = false;
            }
            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {

                    pendingImage1 = null;
                    pendingImage2 = null;
                    Ready15 = Pic8;
                    Ready16 = DupPic8;
                    Ready15.Enabled = false;
                    Ready16.Enabled = false;
                    ScoreNumber.Text = Convert.ToString(Convert.ToInt32(ScoreNumber.Text) + 10);
                    CheckWinState();
                }
                else
                {
                    timer3.Start();
                    PicHolder.Enabled = false;
                    ScoreNumber.Text = Convert.ToString(Convert.ToInt32(ScoreNumber.Text) - 1);
                }
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameBoard_Load(sender, e);
            TimeCounter.Text = "60";
            ScoreNumber.Text = "0";
            timer2.Stop();
            Ready1 = null;
            Ready2 = null;
            Ready3 = null;
            Ready4 = null;
            Ready5 = null;
            Ready6 = null;
            Ready7 = null;
            Ready8 = null;
            Ready9 = null;
            Ready10 = null;
            Ready11 = null;
            Ready12 = null;
            Ready13 = null;
            Ready14 = null;
            Ready15 = null;
            Ready16 = null;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            PicHolder.Enabled = true;

            #region IfPictureboxIsNullOrNot
            if (Ready1 != null)
                Pic1.Enabled = false;
            else
                Pic1.Enabled = true;

            if (Ready2 != null)
                DupPic1.Enabled = false;
            else
                DupPic1.Enabled = true;

            if (Ready3 != null)
                Pic2.Enabled = false;
            else
                Pic2.Enabled = true;

            if (Ready4 != null)
                DupPic2.Enabled = false;
            else
                DupPic2.Enabled = true;

            if (Ready5 != null)
                Pic3.Enabled = false;
            else
                Pic3.Enabled = true;

            if (Ready6 != null)
                DupPic3.Enabled = false;
            else
                DupPic3.Enabled = true;

            if (Ready7 != null)
                Pic4.Enabled = false;
            else
                Pic4.Enabled = true;

            if (Ready8 != null)
                DupPic4.Enabled = false;
            else
                DupPic4.Enabled = true;

            if (Ready9 != null)
                Pic5.Enabled = false;
            else
                Pic5.Enabled = true;

            if (Ready10 != null)
                DupPic5.Enabled = false;
            else
                DupPic5.Enabled = true;

            if (Ready11 != null)
                Pic6.Enabled = false;
            else
                Pic6.Enabled = true;

            if (Ready12 != null)
                DupPic6.Enabled = false;
            else
                DupPic6.Enabled = true;

            if (Ready13 != null)
                Pic7.Enabled = false;
            else
                Pic7.Enabled = true;

            if (Ready14 != null)
                DupPic7.Enabled = false;
            else
                DupPic7.Enabled = true;

            if (Ready15 != null)
                Pic8.Enabled = false;
            else
                Pic8.Enabled = true;

            if (Ready16 != null)
                DupPic8.Enabled = false;
            else
                DupPic8.Enabled = true;
            #endregion

            pendingImage1.Image = Properties.Resources.Cover;
            pendingImage2.Image = Properties.Resources.Cover;
            pendingImage1 = null;
            pendingImage2 = null;

            CheckWinState();
        }
    }
}