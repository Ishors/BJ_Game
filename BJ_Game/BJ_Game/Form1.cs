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
        CardsImport ci;
        Dictionary<string, Image> playerCards;
        Dictionary<string, Image> dealerCards;
        List<PictureBox> displayList;
        Image backOfCard;
        public Form1()
        {
            InitializeComponent();
            startScreen = new StartScreen();
            sr = new ShuffleRandomizer();
            ci = new CardsImport();
            ci.importCards();
            backOfCard = Image.FromFile(ci.FilepathCards + "/cardBack.jpg");

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
            playerCards = new Dictionary<string, Image>();
            dealerCards = new Dictionary<string, Image>();
            displayList = new List<PictureBox>();
            for (int j = 0; j < 4; j++)
            {
                string nextCard = sr.distribute();
                for (int i = 0; i < 52; i++)
                {
                    if (ci.CardsName[i] == nextCard && (j == 0 || j==1))
                    {
                        playerCards.Add(ci.CardsName[i], ci.CardsImage[i]);
                        displayList.Add(new PictureBox());
                        displayList.Last().Image = ci.CardsImage[i];
                        flowLayoutPanel_player.Controls.Add(displayList.Last());
                    }
                    else if(ci.CardsName[i] == nextCard && (j == 2))
                    {
                        dealerCards.Add(ci.CardsName[i], ci.CardsImage[i]);
                        displayList.Add(new PictureBox());
                        displayList.Last().Image = ci.CardsImage[i];
                        flowLayoutPanel_dealer.Controls.Add(displayList.Last());
                    }
                    else if (ci.CardsName[i] == nextCard && (j == 3))
                    {
                        dealerCards.Add(ci.CardsName[i], ci.CardsImage[i]);
                        displayList.Add(new PictureBox());
                        displayList.Last().Image = backOfCard;
                        flowLayoutPanel_dealer.Controls.Add(displayList.Last());
                    }
                }
            }
            
        }
    }
}
