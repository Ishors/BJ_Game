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
           { "two_hearts", "two_spades", "two_diamonds", "two_clubs", "three_hearts", "three_spades", "three_diamonds", "three_clubs",
             "four_hearts", "four_spades", "four_diamonds", "four_clubs",  "five_hearts", "five_spades", "five_diamonds", "five_clubs",
             "six_hearts", "six_spades", "six_diamonds", "six_clubs" ,"seven_hearts", "seven_spades", "seven_diamonds", "seven_clubs" ,
             "eight_hearts", "eight_spades", "eight_diamonds", "eight_clubs" , "nine_hearts", "nine_spades", "nine_diamonds", "nine_clubs" ,
             "ten_hearts", "ten_spades", "ten_diamonds", "ten_clubs" ,  "jack_hearts", "jack_spades", "jack_diamonds", "jack_clubs" , 
             "queen_hearts", "queen_spades", "queen_diamonds", "queen_clubs" ,"king_hearts", "king_spades", "king_diamonds", "king_clubs" ,
             "ace_hearts", "ace_spades", "ace_diamonds", "ace_clubs" };
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
