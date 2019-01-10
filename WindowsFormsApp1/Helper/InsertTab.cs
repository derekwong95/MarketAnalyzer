using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.UserControls;
using System.Windows.Forms;


namespace WindowsFormsApp1.Helper
{
    class InsertTab
    {
        public void AddGeneralTab(TabControl tabControl)
        {
            GeneralTabControl myUserControl = new GeneralTabControl();
            myUserControl.Dock = DockStyle.Fill;
            TabPage myTabPage = new TabPage();//Create new tabpage
            myTabPage.Controls.Add(myUserControl);
            myTabPage.Text = "General";
            tabControl.Controls.Add(myTabPage);
        }

        public void AddChartTab(TabControl tabControl)
        {
            ChartTabControl myUserControl = new ChartTabControl();
            myUserControl.Dock = DockStyle.Fill;
            TabPage myTabPage = new TabPage();//Create new tabpage
            myTabPage.Controls.Add(myUserControl);
            myTabPage.Text = "Chart";
            tabControl.Controls.Add(myTabPage);
        }

        public void AddTestTab(TabControl tabControl)
        {
            TestTabControl myUserControl = new TestTabControl();
            myUserControl.Dock = DockStyle.Fill;
            TabPage myTabPage = new TabPage();//Create new tabpage
            myTabPage.Controls.Add(myUserControl);
            myTabPage.Text = "Test";
            tabControl.Controls.Add(myTabPage);
        }
    }
}
