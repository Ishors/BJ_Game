using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BJ_Game
{
    class Import
    {
        private List<Image> cardsImages;
        private List<string> cardsNames;
        private string filepathCards;
        private Dictionary<int, Image> chips;
        private string filepathChips;

        public Import()
        {
  
        }

        public List<Image> CardsImages { get => cardsImages; set => cardsImages = value; }
        public List<string> CardsNames { get => cardsNames; set => cardsNames = value; }
        public string FilepathCards { get => filepathCards; set => filepathCards = value; }
        public Dictionary<int, Image> Chips { get => chips; set => chips = value; }

        public void importCards()
        {
            cardsImages = new List<Image>();
            cardsNames = new List<string>();
            filepathCards = Path.GetFullPath("cards");
            DirectoryInfo d = new DirectoryInfo(filepathCards);
            foreach (var img in d.GetFiles("*.png"))
            {
                cardsImages.Add(Image.FromFile(filepathCards+"/"+img.Name));
                cardsNames.Add(img.Name.Substring(0,img.Name.Length-4));
            }
        }
        public void importChips()
        {          
            chips = new Dictionary<int, Image>();
            filepathChips = Path.GetFullPath("chips");
            DirectoryInfo d = new DirectoryInfo(filepathChips);
            foreach (var img in d.GetFiles("*.png"))
            {
                chips.Add(Int32.Parse(img.Name.Substring(2, img.Name.Length - 6)), Image.FromFile(filepathChips + "/" + img));
            }
        }

    }
}
