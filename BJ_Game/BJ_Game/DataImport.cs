using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace BJ_Game
{
    class DataImport
    {
        private StreamReader reader;
        private string filepathFull; //chemin d'accès au fichier
        private List<string> rules;
        public DataImport()
        {
            rules = new List<string>();
        }

        public List<string> Rules { get => rules; set => rules = value; }

        public void ImportDataCSV()
        {
            this.filepathFull = Path.GetFullPath("rules.txt");
            using (reader = new StreamReader(filepathFull))
            {
                /// Local variable used to stock every readed line
                string line;
                // Read and display lines from the file until the end of
                // the file is reached.
                while ((line = reader.ReadLine()) != null)
                {
                    // Write every line in a single string
                    
                    rules.Add(line +"\n");
                }
            }
        }
    }
}
