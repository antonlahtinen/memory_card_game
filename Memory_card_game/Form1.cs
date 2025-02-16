namespace Memory_card_game
{
    public partial class GameBoard : Form
    {
        // Game state variables
        private readonly Random random = new Random();
        private readonly List<Point> cardPositions = new List<Point>();
        private PictureBox? firstSelectedCard;    // Stores the first card clicked in a pair
        private PictureBox? secondSelectedCard;   // Stores the second card clicked in a pair
        private readonly Dictionary<string, PictureBox> matchedPairs = new Dictionary<string, PictureBox>();  // Keeps track of matched card pairs

        // Point system constants
        private const int PointsForMatch = 3;    // Points awarded for finding a matching pair
        private const int PenaltyForMismatch = 1; // Points deducted for incorrect match attempt

        public GameBoard()
        {
            InitializeComponent();
        }

        private void GameBoard_Load(object sender, EventArgs e)
        {
            // Initialize and start the game when the form loads
            InitializeGame();
            ShuffleCards();
            LoadCardImages();
            timer1.Start();
        }

        private void InitializeGame()
        {
            // Reset game state and prepare the board
            PicHolder.Enabled = false;
            cardPositions.Clear();
            matchedPairs.Clear();
            firstSelectedCard = null;
            secondSelectedCard = null;

            // Store initial positions of all cards
            foreach (PictureBox picture in PicHolder.Controls)
            {
                picture.Enabled = false;
                cardPositions.Add(picture.Location);
            }
        }

        private void ShuffleCards()
        {
            // Randomly assign positions to cards
            foreach (PictureBox picture in PicHolder.Controls)
            {
                int next = random.Next(cardPositions.Count);
                Point p = cardPositions[next];
                picture.Location = p;
                cardPositions.Remove(p);
            }
        }

        private void LoadCardImages()
        {
            // Assign images to each card pair
            Pic1.Image = DupPic1.Image = Properties.Resources.Pic1;
            Pic2.Image = DupPic2.Image = Properties.Resources.Pic2;
            Pic3.Image = DupPic3.Image = Properties.Resources.Pic3;
            Pic4.Image = DupPic4.Image = Properties.Resources.Pic4;
            Pic5.Image = DupPic5.Image = Properties.Resources.Pic5;
            Pic6.Image = DupPic6.Image = Properties.Resources.Pic6;
            Pic7.Image = DupPic7.Image = Properties.Resources.Pic7;
            Pic8.Image = DupPic8.Image = Properties.Resources.Pic8;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Initial timer that shows cards briefly before covering them
            timer1.Stop();
            timer2.Start();
            EnableAllCards();
        }

        private void EnableAllCards()
        {
            // Enable all cards for interaction and show their cover image
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
            UpdateGameTimer();
        }

        private void UpdateGameTimer()
        {
            // Update the countdown timer and check for game over
            int timer = Convert.ToInt32(TimeCounter.Text);
            timer--;
            TimeCounter.Text = timer.ToString();
            
            if (timer == 0)
            {
                timer2.Stop();
                MessageBox.Show("You lost, better luck next time!", "Game Over");
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            ResetUnmatchedCards();
        }

        private void ResetUnmatchedCards()
        {
            // Reset cards that didn't match back to their covered state
            if (firstSelectedCard != null && secondSelectedCard != null)
            {
                firstSelectedCard.Image = secondSelectedCard.Image = Properties.Resources.Cover;
                firstSelectedCard.Enabled = secondSelectedCard.Enabled = true;
                firstSelectedCard = secondSelectedCard = null;
            }
            
            PicHolder.Enabled = true;
            timer3.Stop();
        }

        private void HandleCardClick(PictureBox clickedCard, Image cardImage)
        {
            // Handle the logic when a card is clicked
            clickedCard.Image = cardImage;
            
            if (firstSelectedCard == null)
            {
                // First card of the pair was clicked
                firstSelectedCard = clickedCard;
                clickedCard.Enabled = false;
            }
            else if (secondSelectedCard == null)
            {
                // Second card of the pair was clicked
                secondSelectedCard = clickedCard;
                clickedCard.Enabled = false;
                CheckForMatch();
            }
        }

        private void CheckForMatch()
        {
            // Check if the two selected cards match
            if (firstSelectedCard == null || secondSelectedCard == null) return;

            if (firstSelectedCard.Tag == secondSelectedCard.Tag)
            {
                HandleMatch();
            }
            else
            {
                HandleMismatch();
            }
        }

        private void HandleMatch()
        {
            // Process a successful match
            matchedPairs[firstSelectedCard.Tag.ToString()] = firstSelectedCard;
            matchedPairs[secondSelectedCard.Tag.ToString()] = secondSelectedCard;
            
            firstSelectedCard.Enabled = secondSelectedCard.Enabled = false;
            firstSelectedCard = secondSelectedCard = null;
            
            UpdateScore(PointsForMatch);
            CheckWinState();
        }

        private void HandleMismatch()
        {
            // Process when cards don't match
            timer3.Start();
            PicHolder.Enabled = false;
            UpdateScore(-PenaltyForMismatch);
        }

        private void UpdateScore(int points)
        {
            // Update the player's score
            int currentScore = Convert.ToInt32(ScoreNumber.Text);
            ScoreNumber.Text = (currentScore + points).ToString();
        }

        private void CheckWinState()
        {
            // Check if all pairs have been found
            if (matchedPairs.Count == 8) // All pairs found
            {
                timer2.Stop();

                int finalScore = Convert.ToInt32(ScoreNumber.Text);
                if (finalScore > 0)
                {
                    MessageBox.Show($"You got {finalScore} points!!", "You won!");
                }
                else
                {
                    MessageBox.Show("You lost, better luck next time!", "Game Over");
                }
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Reset and start a new game
            InitializeGame();
            ShuffleCards();
            LoadCardImages();
            TimeCounter.Text = "60";
            ScoreNumber.Text = "0";
            timer1.Start();
            timer2.Stop();
        }

        private void PicHolder_Paint(object sender, PaintEventArgs e)
        {
            // This event handler is required by the Windows Forms Designer
            // It's empty because we don't need custom painting, but the Designer needs it
        }

        // Event handlers for card clicks - each one calls HandleCardClick with the appropriate card and image
        private void Pic1_Click(object sender, EventArgs e) => HandleCardClick(Pic1, Properties.Resources.Pic1);
        private void DupPic1_Click(object sender, EventArgs e) => HandleCardClick(DupPic1, Properties.Resources.Pic1);
        private void Pic2_Click(object sender, EventArgs e) => HandleCardClick(Pic2, Properties.Resources.Pic2);
        private void DupPic2_Click(object sender, EventArgs e) => HandleCardClick(DupPic2, Properties.Resources.Pic2);
        private void Pic3_Click(object sender, EventArgs e) => HandleCardClick(Pic3, Properties.Resources.Pic3);
        private void DupPic3_Click(object sender, EventArgs e) => HandleCardClick(DupPic3, Properties.Resources.Pic3);
        private void Pic4_Click(object sender, EventArgs e) => HandleCardClick(Pic4, Properties.Resources.Pic4);
        private void DupPic4_Click(object sender, EventArgs e) => HandleCardClick(DupPic4, Properties.Resources.Pic4);
        private void Pic5_Click(object sender, EventArgs e) => HandleCardClick(Pic5, Properties.Resources.Pic5);
        private void DupPic5_Click(object sender, EventArgs e) => HandleCardClick(DupPic5, Properties.Resources.Pic5);
        private void Pic6_Click(object sender, EventArgs e) => HandleCardClick(Pic6, Properties.Resources.Pic6);
        private void DupPic6_Click(object sender, EventArgs e) => HandleCardClick(DupPic6, Properties.Resources.Pic6);
        private void Pic7_Click(object sender, EventArgs e) => HandleCardClick(Pic7, Properties.Resources.Pic7);
        private void DupPic7_Click(object sender, EventArgs e) => HandleCardClick(DupPic7, Properties.Resources.Pic7);
        private void Pic8_Click(object sender, EventArgs e) => HandleCardClick(Pic8, Properties.Resources.Pic8);
        private void DupPic8_Click(object sender, EventArgs e) => HandleCardClick(DupPic8, Properties.Resources.Pic8);
    }
}