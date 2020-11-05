using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BJ_Game
{
    class ShuffleRandomizer
    {
        private string[] Deck;
        private int cardsLeft;

        public ShuffleRandomizer()
        {
            // Exception a gérer plus tard si deckType != 32 ou 52 (quoique si on donne seulement 32 et 52 comme choix (boutons) c'est ok)

           /*this.Deck = new string[13, 4] { { "two", "two", "two", "two" }, { "three", "three", "three", "three" },
                { "four", "four", "four", "four"}, { "five", "five", "five", "five"}, { "six", "six", "six", "six" },
                { "seven", "seven", "seven", "seven" }, { "eight", "eight", "eight", "eight" },{ "nine", "nine", "nine", "nine" },
                { "ten", "ten", "ten", "ten" }, { "jack", "jack", "jack", "jack" }, { "queen", "queen", "queen", "queen" },
                { "king", "king", "king", "king" }, { "ace", "ace", "ace", "ace" } };*/
           this.Deck = new string [52] { "two", "two", "two", "two", "three", "three", "three", "three",
                 "four", "four", "four", "four",  "five", "five", "five", "five",  "six", "six", "six", "six" ,
                 "seven", "seven", "seven", "seven" ,  "eight", "eight", "eight", "eight" , "nine", "nine", "nine", "nine" ,
                 "ten", "ten", "ten", "ten" ,  "jack", "jack", "jack", "jack" ,  "queen", "queen", "queen", "queen" ,
                 "king", "king", "king", "king" ,  "ace", "ace", "ace", "ace" };
            this.cardsLeft = 52;
        }
        public string distribute()
        {
            while (cardsLeft !=0)
            {
                Random random = new Random(52);
                // Attention
                int randInt = Int32.Parse(random.ToString());
                if (Deck[randInt].Equals("") == false)
                {
                    string nextCard = this.Deck[randInt];
                    Deck[randInt] = "";
                    cardsLeft -= 1;
                    return nextCard;
                }
            }
            // A coupler avec un if pour recréer un randomizer
            return "deckEnd";
        }
    }
}
