using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BJ_Game
{
    class ShuffleRandomizer
    {
        private string[] deck;
        private int cardsLeft;

        public ShuffleRandomizer()
        {  
           this.deck = new string [52] 
           { "2_hearts", "2_spades", "2_diamonds", "2_clubs", "3_hearts", "3_spades", "3_diamonds", "3_clubs",
             "4_hearts", "4_spades", "4_diamonds", "4_clubs",  "5_hearts", "5_spades", "5_diamonds", "5_clubs",
             "6_hearts", "6_spades", "6_diamonds", "6_clubs" ,"7_hearts", "7_spades", "7_diamonds", "7_clubs" ,
             "8_hearts", "8_spades", "8_diamonds", "8_clubs" , "9_hearts", "9_spades", "9_diamonds", "nine_clubs" ,
             "10_hearts", "10_spades", "10_diamonds", "10_clubs" ,  "j_hearts", "j_spades", "j_diamonds", "j_clubs" , 
             "q_hearts", "q_spades", "q_diamonds", "q_clubs" ,"k_hearts", "k_spades", "k_diamonds", "k_clubs" ,
             "a_hearts", "a_spades", "a_diamonds", "a_clubs" };
            this.cardsLeft = 52;
        }

        public string[] Deck { get => deck; set => deck = value; }
        public int CardsLeft { get => cardsLeft; set => cardsLeft = value; }

        public string distribute()
        {
            while (cardsLeft !=0)
            {
                Random random = new Random();
                int randInt = random.Next(52);
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
