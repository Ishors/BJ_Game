using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace BJ_Game
{
    class Player
    {
        private int playerHand;
        private Dictionary<string, Image> playerCards;

        public Player()
        {
            playerCards = new Dictionary<string, Image>();
        }

        public Dictionary<string, Image> PlayerCards { get => playerCards; set => playerCards = value; }
        public int PlayerHand { get => playerHand; set => playerHand = value; }

        public void addPlayerHand(string shuffledCard, Image shuffledCardImage)
        {
            // L'utilisation du dictionnaire sera problématique quand on utilisera plusieurs jeux
            // A voir s'il est si utile que ça
            playerCards.Add(shuffledCard, shuffledCardImage);
            if ((shuffledCard.Substring(0, 1).Equals("1")) == true ||
               (shuffledCard.Substring(0, 1).Equals("j")) == true ||
               (shuffledCard.Substring(0, 1).Equals("q")) == true ||
               (shuffledCard.Substring(0, 1).Equals("k")) == true)
            {
                playerHand += 10;
            }
            // Trouver comment gérer le cas de l'as
            else if ((shuffledCard.Substring(0, 1).Equals("a")) == true && PlayerHand <= 10)
            {
                playerHand += 11;
            }
            else if ((shuffledCard.Substring(0, 1).Equals("a")) == true && PlayerHand >= 11)
            {
                playerHand += 1;
            }
            else
            {
                playerHand += Int32.Parse(shuffledCard.Substring(0, 1).ToString());
            }
        }
    }
}
