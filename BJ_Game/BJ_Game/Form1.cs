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
        StartScreen startScreen;
        CardsImport ci;
        List<PictureBox> displayListDealer;
        List<PictureBox> displayListPlayer;
        Image backOfCard;
        Player player;
        Dealer dealer;
        string lastDealerCard;

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
            button_go.Visible = false;
            button_hit.Enabled = true;
            button_hit.Visible = true;
            button_stand.Enabled = true;
            button_stand.Visible = true;
            player = new Player();
            dealer = new Dealer();
            displayListPlayer = new List<PictureBox>();
            displayListDealer = new List<PictureBox>();
            for (int j = 0; j < 4; j++)
            {
                string nextCard = sr.distribute();
                for (int i = 0; i < 52; i++)
                {
                    if (ci.CardsName[i] == nextCard && (j == 0 || j==1))
                    {
                        player.addPlayerHand(ci.CardsName[i], ci.CardsImage[i]);
                        //MessageBox.Show(ci.CardsName[i]);
                        //MessageBox.Show(player.PlayerHand.ToString());
                        displayImagePlayer(ci.CardsImage[i]);
                    }
                    else if(ci.CardsName[i] == nextCard && (j == 2))
                    {
                        dealer.addDealerHand(ci.CardsName[i], ci.CardsImage[i]);
                        //MessageBox.Show(ci.CardsName[i]);
                        //MessageBox.Show(dealer.DealerHand.ToString());
                        displayImageDealer(ci.CardsImage[i]);
                    }
                    else if (ci.CardsName[i] == nextCard && (j == 3))
                    {
                        dealer.addDealerHand(ci.CardsName[i], ci.CardsImage[i]);
                        lastDealerCard = ci.CardsName[i];
                        //MessageBox.Show(ci.CardsName[i]);
                        //MessageBox.Show(dealer.DealerHand.ToString());
                        displayImageDealer(backOfCard);
                    }
                }
            }
            if (player.PlayerHand == 21)
            {
                MessageBox.Show("Blackjack !!");
                clear();
            }
        }

        private void button_hit_Click(object sender, EventArgs e)
        {
            string nextCard = sr.distribute();
            for (int i = 0; i < 52; i++)
            {
                if (ci.CardsName[i] == nextCard)
                {
                    player.addPlayerHand(ci.CardsName[i], ci.CardsImage[i]);
                    if (player.PlayerHand > 21 && (player.PlayerCards.ContainsKey("a_hearts") ||
                        player.PlayerCards.ContainsKey("a_diamonds") || player.PlayerCards.ContainsKey("a_spades") ||
                        player.PlayerCards.ContainsKey("a_clubs")))
                    {
                        player.PlayerHand -= 10;
                        displayImagePlayer(ci.CardsImage[i]);
                    }
                    else if (player.PlayerHand > 21 && !(player.PlayerCards.ContainsKey("a_hearts") ||
                        player.PlayerCards.ContainsKey("a_diamonds") || player.PlayerCards.ContainsKey("a_spades") ||
                        player.PlayerCards.ContainsKey("a_clubs")))
                    {
                        displayImagePlayer(ci.CardsImage[i]);
                        MessageBox.Show("Bust !");
                        clear();
                    }
                    else if (player.PlayerHand == 21)
                    {
                        displayImagePlayer(ci.CardsImage[i]);
                        MessageBox.Show("Blackjack !!");
                        clear();
                    }
                    else
                    {
                        displayImagePlayer(ci.CardsImage[i]);
                    }
                }
            }
        }

        private void button_stand_Click(object sender, EventArgs e)
        {
            dealer.DealerCards.TryGetValue(lastDealerCard, out Image img);
            displayListDealer.Last().Image = img;

            while (dealer.DealerHand<=16)
            {
                string nextCard = sr.distribute();
                for (int i = 0; i < 52; i++)
                {
                    if (ci.CardsName[i] == nextCard)
                    {
                        dealer.addDealerHand(ci.CardsName[i], ci.CardsImage[i]);
                        if (dealer.DealerHand > 21)
                        {
                            displayImageDealer(ci.CardsImage[i]);
                            MessageBox.Show("Win !");
                            clear();
                            // Pour éviter que ça ne tourne à l'infi on met u ntruc supérieur à 16
                            // DealerHand sera de retour à 0 quand on lance une nouvelle partie de toutes façons
                            dealer.DealerHand = 100;
                        }
                        else
                        {
                            displayImageDealer(ci.CardsImage[i]);
                        }


                    }
                }
            }
            //Tester la win ou loose du joueur
            if (dealer.DealerHand > player.PlayerHand)
            {
                MessageBox.Show("Loose");
            }
            else if (dealer.DealerHand == player.PlayerHand)
            {
                MessageBox.Show("Even");
            }
            else
            {
                MessageBox.Show("Win");
            }
            clear();
        }

        public void clear()
        {
            player.PlayerHand = 0;
            dealer.DealerHand = 0;
            flowLayoutPanel_player.Controls.Clear();
            flowLayoutPanel_dealer.Controls.Clear();
            button_go.Visible = true;
            button_hit.Visible = false;
            button_stand.Visible = false;
        }

        public void displayImageDealer(Image image)
        {
            displayListDealer.Add(new PictureBox());
            displayListDealer.Last().Image = image;
            displayListDealer.Last().AutoSize = true;
            flowLayoutPanel_dealer.Controls.Add(displayListDealer.Last());
        }
        public void displayImagePlayer(Image image)
        {
            displayListPlayer.Add(new PictureBox());
            displayListPlayer.Last().Image = image;
            displayListPlayer.Last().AutoSize = true;
            flowLayoutPanel_player.Controls.Add(displayListPlayer.Last());
        }
    }
}
