using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BJ_Game
{
    class ShuffleRandomizer
    {
        private List<string> deck;
        //private string[] deck;
        private int cardsLeft;
        private int nbDecks;

        public ShuffleRandomizer(int nbDecks)
        {
            this.nbDecks = nbDecks;
            this.deck = new List<string>();
            for (int i=0; i < nbDecks; i++)
            {
                deck.Add("2_hearts");
                deck.Add("2_spades");
                deck.Add("2_diamonds");
                deck.Add("2_clubs");
                deck.Add("3_hearts");
                deck.Add("3_spades");
                deck.Add("3_diamonds");
                deck.Add("3_clubs");
                deck.Add("4_hearts");
                deck.Add("4_spades");
                deck.Add("4_diamonds");
                deck.Add("4_clubs");
                deck.Add("5_hearts");
                deck.Add("5_spades");
                deck.Add("5_diamonds");
                deck.Add("5_clubs");
                deck.Add("6_hearts");
                deck.Add("6_spades");
                deck.Add("6_diamonds");
                deck.Add("6_clubs");
                deck.Add("7_hearts");
                deck.Add("7_spades");
                deck.Add("7_diamonds");
                deck.Add("7_clubs");
                deck.Add("8_hearts");
                deck.Add("8_spades");
                deck.Add("8_diamonds");
                deck.Add("8_clubs");
                deck.Add("9_hearts");
                deck.Add("9_spades");
                deck.Add("9_diamonds");
                deck.Add("9_clubs");
                deck.Add("10_hearts");
                deck.Add("10_spades");
                deck.Add("10_diamonds");
                deck.Add("10_clubs");
                deck.Add("j_hearts");
                deck.Add("j_spades");
                deck.Add("j_diamonds");
                deck.Add("j_clubs");
                deck.Add("q_hearts");
                deck.Add("q_spades");
                deck.Add("q_diamonds");
                deck.Add("q_clubs");
                deck.Add("k_hearts");
                deck.Add("k_spades");
                deck.Add("k_diamonds");
                deck.Add("k_clubs");
                deck.Add("a_hearts");
                deck.Add("a_spades");
                deck.Add("a_diamonds");
                deck.Add("a_clubs");
                this.cardsLeft += 52;
            }
           /*this.deck = new string [52] 
           { "2_hearts", "2_spades", "2_diamonds", "2_clubs", "3_hearts", "3_spades", "3_diamonds", "3_clubs",
             "4_hearts", "4_spades", "4_diamonds", "4_clubs", "5_hearts", "5_spades", "5_diamonds", "5_clubs",
             "6_hearts", "6_spades", "6_diamonds", "6_clubs", "7_hearts", "7_spades", "7_diamonds", "7_clubs" ,
             "8_hearts", "8_spades", "8_diamonds", "8_clubs", "9_hearts", "9_spades", "9_diamonds", "9_clubs" ,
             "10_hearts", "10_spades", "10_diamonds", "10_clubs" ,  "j_hearts", "j_spades", "j_diamonds", "j_clubs" , 
             "q_hearts", "q_spades", "q_diamonds", "q_clubs" ,"k_hearts", "k_spades", "k_diamonds", "k_clubs" ,
             "a_hearts", "a_spades", "a_diamonds", "a_clubs" };
            this.cardsLeft = 52;*/
        }

        public int CardsLeft { get => cardsLeft; set => cardsLeft = value; }

        public string distribute()
        {
            while (cardsLeft !=0)
            {
                Random random = new Random();
                int randInt = random.Next(nbDecks*52);
                if (this.deck[randInt].Equals("") == false)
                {
                    string nextCard = this.deck[randInt];
                    this.deck[randInt] = "";
                    cardsLeft -= 1;
                    return nextCard;
                }
            }
            // A coupler avec un if pour recréer un randomizer
            return "deckEnd";
        }
    }
}
