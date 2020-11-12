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
        private int hiddenCardInt;
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
            string ace;
            string nextCard = sr.distribute();
            for (int i = 0; i < 52; i++)
            {
                if (imp.CardsNames[i] == nextCard)
                {
                    player.addPlayerHand(imp.CardsNames[i]);
                    label_ptotal.Text = "Player total: " +player.PlayerHand.ToString();
                    if (player.PlayerHand > 21 && (player.PlayerCards.Contains(ace = "a_hearts") ||
                        player.PlayerCards.Contains(ace = "a_diamonds") || player.PlayerCards.Contains(ace = "a_spades") ||
                        player.PlayerCards.Contains(ace = "a_clubs")) && player.AceCount > 0)
                    {
                        player.PlayerHand -= 10;
                        displayImagePlayer(imp.CardsImages[i]);
                        player.PlayerCards.Remove(ace);
                        player.AceCount -= 1;
                    }
                    else if (player.PlayerHand > 21 && !(player.PlayerCards.Contains("a_hearts") ||
                        player.PlayerCards.Contains("a_diamonds") || player.PlayerCards.Contains("a_spades") ||
                        player.PlayerCards.Contains("a_clubs")) && player.AceCount == 0)
                    {
                        displayImagePlayer(imp.CardsImages[i]);
                        MessageBox.Show("Bust !");
                        label_dtotal.Text = "Dealer total: " + dealer.DealerHand.ToString();
                        label_ptotal.Text = "Player total: " + player.PlayerHand.ToString();
                        this.bet = 0;
                        clear();
                    }
                    //A revoir car le dealer peut quand même taper blackjack
                    else
                    {
                        displayImagePlayer(imp.CardsImages[i]);

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
                        label_dtotal.Text = "Dealer total: " + dealer.DealerHand.ToString();
                        if (dealer.DealerHand > 21)
                        {
                            displayImageDealer(imp.CardsImages[i]);
                            MessageBox.Show("Win !");
                            label_dtotal.Text = "Dealer total: " + dealer.DealerHand.ToString();
                            label_ptotal.Text = "Player total: " + player.PlayerHand.ToString();
                            bank.addCash(bet);
                            this.bet = 0;
                            clear();
                            // Pour éviter que ça ne tourne à l'infi on met u ntruc supérieur à 16
                            // DealerHand sera de retour à 0 quand on lance une nouvelle partie de toutes façons
                            dealer.DealerHand = 100;
                        }
                        else
                        {
                            displayImageDealer(imp.CardsImages[i]);
                        }
                    }
                }
            }    
            if (dealer.DealerHand > player.PlayerHand)
            {
                MessageBox.Show("Loose");
                label_dtotal.Text = "Dealer total: " + dealer.DealerHand.ToString();
                label_ptotal.Text = "Player total: " + player.PlayerHand.ToString();
                this.bet = 0;
            }
            else if (dealer.DealerHand == player.PlayerHand)
            {
                MessageBox.Show("Even");
                label_dtotal.Text = "Dealer total: " + dealer.DealerHand.ToString();
                label_ptotal.Text = "Player total: " + player.PlayerHand.ToString();
                bank.addCashEven(bet);
                this.bet = 0;
            }
            else
            {
                MessageBox.Show("Win");
                label_dtotal.Text = "Dealer total: " + dealer.DealerHand.ToString();
                label_ptotal.Text = "Player total: " + player.PlayerHand.ToString();
                bank.addCash(bet);
                this.bet = 0;
            }
            clear();
        }

        public void clear()
        {
            displayBets();
            player.PlayerHand = 0;
            dealer.DealerHand = 0;
            flowLayoutPanel_player.Controls.Clear();
            flowLayoutPanel_dealer.Controls.Clear();
            button_go.Visible = false;
            button_hit.Visible = false;
            button_stand.Visible = false;
            this.ingame = false;
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
                        //MessageBox.Show(imp.CardsNames[i]);
                        //MessageBox.Show(player.PlayerHand.ToString());
                        displayImagePlayer(imp.CardsImages[i]);
                    }
                    else if (imp.CardsNames[i] == nextCard && (j == 2))
                    {
                        dealer.addDealerHand(imp.CardsNames[i], imp.CardsImages[i]);
                        //MessageBox.Show(imp.CardsNames[i]);
                        //MessageBox.Show(dealer.DealerHand.ToString());
                        displayImageDealer(imp.CardsImages[i]);
                    }
                    else if (imp.CardsNames[i] == nextCard && (j == 3))
                    {
                        int stock = dealer.DealerHand;
                        dealer.addDealerHand(imp.CardsNames[i], imp.CardsImages[i]);
                        hiddenCard = imp.CardsNames[i];
                        hiddenCardInt = dealer.DealerHand - stock;
                        //MessageBox.Show(imp.CardsNames[i]);
                        //MessageBox.Show(dealer.DealerHand.ToString());
                        displayImageDealer(backOfCard);
                    }
                }
            }
            if (player.PlayerHand == 21)
            {
                MessageBox.Show("Blackjack !!");
                bank.addCash(bet);
                this.bet = 0;
                clear();
            }
            int dealerTotal = dealer.DealerHand - hiddenCardInt;
            label_dtotal.Text = "Dealer total: " + dealerTotal.ToString();
            label_ptotal.Text = "Player total: " + player.PlayerHand.ToString();
        }
    }
}
