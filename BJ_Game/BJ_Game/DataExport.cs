using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BJ_Game
{
    class DataExport
    {
        private StreamWriter writer;

        public DataExport()
        {

        }

        public void Writeinfile(string card)
        {
            using (writer = new System.IO.StreamWriter(@"cartes.txt",true))
            {
                writer.WriteLine(card);
            }
        }
    }
}
