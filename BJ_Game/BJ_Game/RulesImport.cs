using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace BJ_Game
{
    class RulesImport
    {
        private StreamReader reader;
        private List<string> rules;

        public RulesImport()
        {
            rules = new List<string>();
        }

        public List<string> Rules { get => rules; set => rules = value; }

        public void importDataCSV()
        {
            string filepathRules;
            filepathRules = Path.GetFullPath("rules.txt");
            using (reader = new StreamReader(filepathRules))
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
