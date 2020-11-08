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
        private List<Image> cardsImage;
        private List<string> cardsName;
        private string filepathCards;
        public CardsImport()
        {
            cardsImage = new List<Image>();
            cardsName = new List<string>();
            filepathCards = Path.GetFullPath("Imgs");
        }

        public List<Image> CardsImage { get => cardsImage; set => cardsImage = value; }
        public List<string> CardsName { get => cardsName; set => cardsName = value; }
        public string FilepathCards { get => filepathCards; set => filepathCards = value; }

        public void importCards()
        {
            DirectoryInfo d = new DirectoryInfo(filepathCards);
            foreach (var img in d.GetFiles("*.png"))
            {
                cardsImage.Add(Image.FromFile(filepathCards+"/"+img.Name));
                cardsName.Add(img.Name.Substring(0,img.Name.Length-4));
            }
        }
    }
}
