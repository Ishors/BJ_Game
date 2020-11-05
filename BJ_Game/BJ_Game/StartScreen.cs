using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BJ_Game
{
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        private void StartScreen_Load(object sender, EventArgs e)
        {
            RulesImport rulesImport = new RulesImport();
            rulesImport.importDataCSV();
            foreach (string line in rulesImport.Rules) {
                // Add a text box for each line read in the .txt file
                label1.Text += line + Environment.NewLine;
            }
            
        }

        private void button_playBJ_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
