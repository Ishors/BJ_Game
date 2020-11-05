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
            DataImport dataImport = new DataImport();
            dataImport.ImportDataCSV();
            foreach (string line in dataImport.Rules) {
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
