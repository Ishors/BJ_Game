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
        DataImport dataImport;
        public StartScreen()
        {
            InitializeComponent();
        }

        private void StartScreen_Load(object sender, EventArgs e)
        {
            dataImport = new DataImport();
            dataImport.ImportDataCSV();
            textBox1.Text = dataImport.Rules;
        }
    }
}
