using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace BJ_Game
{
    public partial class Form1 : Form
    {
        private ShuffleRandomizer sr;
        private StartScreen startScreen;
        private Import imp;
        private List<PictureBox> displayListDealer;
        private List<PictureBox> displayListPlayer;
        private List<PictureBox> displayListChips;
        private Image backOfCard;
        private Player player;
        private Dealer dealer;
        private Bank bank;
        private string hiddenCard;
        private int bet;
        private bool ingame;

        public Form1()
        {
            InitializeComponent();
            startScreen = new StartScreen();
            sr = new ShuffleRandomizer();
            bank = new Bank();
            imp = new Import();
            imp.importCards();
            imp.importChips();
            backOfCard = Image.FromFile(imp.FilepathCards + "/cardBack.jpg");
            this.ingame = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            startScreen.Show();
            startScreen.TopMost = true;
            startScreen.Select();
            displayListChips = new List<PictureBox>();
            displayChips();
            displayBets();
        }

        private void button_hit_Click(object sender, EventArgs e)
        {
            string nextCard = sr.distribute();
            for (int i = 0; i < 52; i++)
            {
                if (imp.CardsNames[i] == nextCard)
                {
                    player.addPlayerHand(imp.CardsNames[i]);
                    displayImagePlayer(imp.CardsImages[i]);
                    if (player.PlayerHand > 21 && player.AceCount > 0)
                    {
                        player.PlayerHand -= 10;
                        player.AceCount -= 1;
                        label_ptotal.Text = "Player total: " + player.PlayerHand.ToString();
                    }
                    else if (player.PlayerHand > 21 && player.AceCount == 0)
                    {
                        label_ptotal.Text = "Player total: " + player.PlayerHand.ToString();
                        MessageBox.Show("Bust !");
                        clear();
                    }
                    else
                    {
                        label_ptotal.Text = "Player total: " + player.PlayerHand.ToString();
                    }
                }
            } 
        }

        private void button_stand_Click(object sender, EventArgs e)
        {
            dealer.DealerCards.TryGetValue(hiddenCard, out Image img);
            displayListDealer.Last().Image = img;
            while (dealer.DealerHand<=16)
            {
                string nextCard = sr.distribute();
                for (int i = 0; i < 52; i++)
                {
                    if (imp.CardsNames[i] == nextCard)
                    {
                        dealer.addDealerHand(imp.CardsNames[i], imp.CardsImages[i]);
                        displayImageDealer(imp.CardsImages[i]);
                        if (dealer.DealerHand > 21 && dealer.AceCount > 0)
                        {
                            dealer.DealerHand -= 10;                           
                            dealer.AceCount -= 1;                           
                        }
                    }                   
                }             
            }
            label_dtotal.Text = "Dealer total: " + dealer.DealerHand.ToString();
            if (dealer.DealerHand > 21)
            {
                MessageBox.Show("Win !");
                bank.addCash(bet);
                clear();
            }
            else if (dealer.DealerHand > player.PlayerHand)
            {
                MessageBox.Show("Loose");
            }
            else if (dealer.DealerHand == player.PlayerHand)
            {
                MessageBox.Show("Even");
                bank.addCashEven(bet);
            }
            else
            {
                MessageBox.Show("Win");
                bank.addCash(bet);
            }
            clear();
        }

        public void clear()
        {
            this.bet = 0;
            displayBets();
            player.PlayerHand = 0;
            dealer.DealerHand = 0;
            flowLayoutPanel_player.Controls.Clear();
            flowLayoutPanel_dealer.Controls.Clear();
            button_go.Visible = false;
            button_hit.Visible = false;
            button_stand.Visible = false;
            this.ingame = false;
            label_dtotal.Text = "Dealer total: ";
            label_ptotal.Text = "Player total: ";
        }

        public void displayImageDealer(Image image)
        {
            // Tentative de deux images qui se chevauchent
            /*
            if (displayListDealer.Count() != 0)
            {
                Point pt = new Point();
                pt = displayListDealer.Last().Location;
                pt.X = displayListDealer.Last().Width - 50;
                displayListDealer.Add(new PictureBox());
                displayListDealer.Last().Image = image;
                displayListDealer.Last().Location = pt;
                displayListDealer.Last().AutoSize = true;
                flowLayoutPanel_dealer.Controls.Add(displayListDealer.Last());
            }
            else
            {*/
                displayListDealer.Add(new PictureBox());
                displayListDealer.Last().Image = image;
                flowLayoutPanel_dealer.Controls.Add(displayListDealer.Last());
                displayListDealer.Last().AutoSize = true;
            //}
        }
        public void displayImagePlayer(Image image)
        {
            displayListPlayer.Add(new PictureBox());
            displayListPlayer.Last().Image = image;
            displayListPlayer.Last().AutoSize = true;
            flowLayoutPanel_player.Controls.Add(displayListPlayer.Last());
        }

        // This method is here so that there aren't too many things in the "button_go_Click" method
        public void displayChips()
        {
            foreach (var kvp in imp.Chips)
            {
                displayListChips.Add(new PictureBox());
                displayListChips.Last().Image = kvp.Value;
                displayListChips.Last().AccessibleName = kvp.Key.ToString();
                displayListChips.Last().AutoSize = true;
                displayListChips.Last().Click += new System.EventHandler(chip_Click);
                flowLayoutPanel_bank.Controls.Add(displayListChips.Last());
            }
        }

        public void displayBets()
        {
            label_bet.Text = "Bet: " + bet.ToString() + "€";
            label_cash.Text = "Remaining: " + bank.Cash.ToString() + "€";
        }
        private void chip_Click(object sender, EventArgs e)
        {
            if (this.ingame == false)
            {
                string amount = (sender as PictureBox).AccessibleName;
                if (bank.Cash >= Int32.Parse(amount))
                {
                    bet += Int32.Parse(amount);
                    bank.takeCash(Int32.Parse(amount));
                    displayBets();
                    button_go.Visible = true;
                }
                else
                {
                    MessageBox.Show("No more money dude");
                }
            }
            
        }

        private void button_go_Click_1(object sender, EventArgs e)
        {
            this.ingame = true;
            int hiddenCardInt = 0;
            button_go.Visible = false;
            button_hit.Visible = true;
            button_stand.Visible = true;
            label_ptotal.Visible = true;
            label_dtotal.Visible = true;
            player = new Player();
            dealer = new Dealer();
            displayListPlayer = new List<PictureBox>();
            displayListDealer = new List<PictureBox>();
            for (int j = 0; j < 4; j++)
            {
                string nextCard = sr.distribute();
                for (int i = 0; i < 52; i++)
                {
                    if (imp.CardsNames[i] == nextCard && (j == 0 || j == 1))
                    {
                        player.addPlayerHand(imp.CardsNames[i]);
                        displayImagePlayer(imp.CardsImages[i]);
                    }
                    else if (imp.CardsNames[i] == nextCard && (j == 2))
                    {
                        dealer.addDealerHand(imp.CardsNames[i], imp.CardsImages[i]);
                        displayImageDealer(imp.CardsImages[i]);
                    }
                    else if (imp.CardsNames[i] == nextCard && (j == 3))
                    {
                        int stock = dealer.DealerHand;
                        dealer.addDealerHand(imp.CardsNames[i], imp.CardsImages[i]);
                        displayImageDealer(backOfCard);
                        hiddenCard = imp.CardsNames[i];
                        hiddenCardInt = dealer.DealerHand - stock;
                    }
                }
            }
            if (player.PlayerHand == 21)
            {
                MessageBox.Show("Blackjack !!");
                bank.addCash(bet);
                clear();
            }
            int dealerTotal = dealer.DealerHand - hiddenCardInt;
            label_dtotal.Text = "Dealer total: " + dealerTotal.ToString();
            label_ptotal.Text = "Player total: " + player.PlayerHand.ToString();
        }
    }
}
