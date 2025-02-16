using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory_card_game
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameBoard start = new GameBoard();
            start.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" 1. In the beginning of the game all the cards are mixed up and laid in rows.\n 2. Cards are shown to the player for 5 seconds before they are turned over. " +
                "\n 3. Player starts and turns over two cards. If the cards match, the cards stay open. \n 4. If the cards don’t match, then the cards are turned back over. " +
                "\n 5. When the player has found all the pairs or time is up, the game is over.", "Instructions");
            
        }

        private void StartPage_Load(object sender, EventArgs e)
        {


            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
