using System;
using System.Collections.Generic;
using System.Drawing;

namespace BJ_Game
{
    class Dealer
    {
        private int dealerHand;
        Dictionary<string, Image> dealerCards;

        public Dealer()
        {
            dealerCards = new Dictionary<string, Image>();
        }

        public Dictionary<string, Image> DealerCards { get => dealerCards; set => dealerCards = value; }
        public int DealerHand { get => dealerHand; set => dealerHand = value; }

        public void addDealerHand(string shuffledCard, Image shuffledCardImage)
        {
            // L'utilisation du dictionnaire sera problématique quand on utilisera plusieurs jeux
            // A voir s'il est si utile que ça
            dealerCards.Add(shuffledCard, shuffledCardImage);
            if ((shuffledCard.Substring(0, 1).Equals("1")) == true ||
               (shuffledCard.Substring(0, 1).Equals("j")) == true ||
               (shuffledCard.Substring(0, 1).Equals("q")) == true ||
               (shuffledCard.Substring(0, 1).Equals("k")) == true)
            {
                dealerHand += 10;
            }
            // Trouver comment gérer le cas de l'as
            else if ((shuffledCard.Substring(0, 1).Equals("a")) == true && dealerHand <= 10)
            {
                dealerHand += 11;
            }
            else if ((shuffledCard.Substring(0, 1).Equals("a")) == true && dealerHand >= 11)
            {
                dealerHand += 1;
            }
            else
            {
                dealerHand += Int32.Parse(shuffledCard.Substring(0, 1).ToString());
            }
        }
    }
}
