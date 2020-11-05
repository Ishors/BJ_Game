using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace BJ_Game
{
    public partial class Form1 : Form
    {
        private ShuffleRandomizer sr;
        private string turn;
        StartScreen startScreen;
        CardsImport cardsImport;

        public Form1()
        {
            InitializeComponent();
            startScreen = new StartScreen();
            sr = new ShuffleRandomizer();
            cardsImport = new CardsImport();
            cardsImport.importCards();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            startScreen.Show();
            startScreen.TopMost = true;
            startScreen.Select();         
        }

        private void button_go_Click(object sender, EventArgs e)
        {
            button_go.Enabled = false;
            button_go.Visible = false;
            button_hit.Enabled = true;
            button_hit.Visible = true;
            button_stand.Enabled = true;
            button_stand.Visible = true;
            for (int i=0; i < 52; i++)
            {
                if (cardsImport.CardsName[i] == sr.distribute())
                {
                    pictureBox1_player.Image = cardsImport.Cards[i];
                }
            }
            
        }
    }
}
