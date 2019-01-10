using WindowsFormsApp1.Libraries;
using WindowsFormsApp1.UserControls;
using WindowsFormsApp1.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketAnalyzer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //add all the tabs here
            InsertTab insertTab = new InsertTab();
            insertTab.AddGeneralTab(tabControlMain);
            insertTab.AddChartTab(tabControlMain);
            insertTab.AddTestTab(tabControlMain);
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {

        }

        private void textBoxApiName_TextChanged(object sender, EventArgs e)
        {
            var ApiKey = Singleton.Instance;
            ApiKey.Set(textBoxApiName.Text);
            ApiKey.Get();
        }


    }
}
