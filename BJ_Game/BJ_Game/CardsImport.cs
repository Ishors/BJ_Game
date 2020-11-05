using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BJ_Game
{
    class CardsImport
    {
        private List<Image> cards;
        private List<string> cardsName;
        public CardsImport()
        {
            cards = new List<Image>();
            cardsName = new List<string>();
        }

        public List<Image> Cards { get => cards; set => cards = value; }
        public List<string> CardsName { get => cardsName; set => cardsName = value; }

        public void importCards()
        {
            string filepathCards;
            filepathCards = Path.GetFullPath("Imgs");
            DirectoryInfo d = new DirectoryInfo(filepathCards);
            foreach (var img in d.GetFiles("*.png"))
            {
                cards.Add(Image.FromFile(filepathCards+"/"+img.Name));
                cardsName.Add(img.Name.Substring(0,img.Name.Length-4));
            }
        }
    }
}
