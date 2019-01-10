using WindowsFormsApp1.Libraries;
using WindowsFormsApp1.UserControls;
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
            addnewtab();
        }

        public void addnewtab()
        {
            GeneralTabControl myUserControl = new GeneralTabControl();
            myUserControl.Dock = DockStyle.Fill;
            TabPage myTabPage = new TabPage();//Create new tabpage
            myTabPage.Controls.Add(myUserControl);
            myTabPage.Text = "General";
            tabControl1.Controls.Add(myTabPage);
        }

        private async void buttonSubmit_Click(object sender, EventArgs e)
        {
            var API_KEY = textBoxApiName.Text;

            var StockTickers = new List<string> { "AAPL" };

            var parameters = new List<AlphaVantageApiWrapper.ApiParam>
                {
                    new AlphaVantageApiWrapper.ApiParam("function", AlphaVantageApiWrapper.AvFuncationEnum.TimeSeriesDaily.ToDescription()),
                    new AlphaVantageApiWrapper.ApiParam("symbol", "AAPL"),
                    new AlphaVantageApiWrapper.ApiParam("interval", AlphaVantageApiWrapper.AvIntervalEnum.FiveMinutes.ToDescription()),
                    //new AlphaVantageApiWrapper.AlphaVantageApiWrapper.ApiParam("time_period", "5"),
                   // new AlphaVantageApiWrapper.AlphaVantageApiWrapper.ApiParam("series_type", AlphaVantageApiWrapper.AlphaVantageApiWrapper.AvSeriesType.Open.ToDescription()),
                };

            var SMA_5 = await AlphaVantageApiWrapper.GetGeneralData(parameters, API_KEY);
            parameters.FirstOrDefault(x => x.ParamName == "time_period").ParamValue = "20";

            ListViewItem listItem = new ListViewItem();
            listItem.SubItems.Add(SMA_5.ToString());
            listItem.SubItems.Add("test");
            //listViewData.Columns.Add("testing");
            //listViewData.Items.Add(SMA_5.ToString());
            //listViewData.View = View.Details;

        }

        private void textBoxApiName_TextChanged(object sender, EventArgs e)
        {
            var c = Singleton.Instance;
            c.Set(textBoxApiName.Text);

            var a = c.Get();
        }

        private async void buttonSector_Click(object sender, EventArgs e)
        {
            addnewtab();
            var apiKey = textBoxApiName.Text;
            ListViewItem item = new ListViewItem();

            var parameters = new List<AlphaVantageApiWrapper.ApiParam>
                {
                    new AlphaVantageApiWrapper.ApiParam("function", AlphaVantageApiWrapper.AvFuncationEnum.Sector.ToDescription()),
                };

            var sectors = await AlphaVantageApiWrapper.GetSector(parameters, apiKey);

            foreach (var sector in sectors.SectorData)
            {
                foreach (var category in sector.Data)
                {
                    item = new ListViewItem(new[] { category.Key, String.Concat(category.Value.ToString(), '%') });

                    switch (sector.TimeRange)
                    {
                        case "Rank A: Real-Time Performance":
                            listViewRealTime.Items.Add(item);
                            break;
                        case "Rank B: 1 Day Performance":
                            //listView1Day.Items.Add(item);
                            break;
                        case "Rank C: 5 Day Performance":
                            //listView5Day.Items.Add(item);
                            break;
                        case "Rank D: 1 Month Performance":
                            //listView1Month.Items.Add(item);
                            break;
                        case "Rank E: 3 Month Performance":
                            //listView3Month.Items.Add(item);
                            break;
                        case "Rank F: Year-to-Date (YTD) Performance":
                            //listViewYearToDate.Items.Add(item);
                            break;
                        case "Rank G: 1 Year Performance":
                            //listView1Year.Items.Add(item);
                            break;
                        case "Rank H: 3 Year Performance":
                            //listView3Year.Items.Add(item);
                            break;
                        case "Rank I: 5 Year Performance":
                            //listView5Year.Items.Add(item);
                            break;
                        case "Rank J: 10 Year Performance":
                            //listView10Year.Items.Add(item);
                            break;
                        default:
                            break;
                    } 
                }      
            }
        }

        private async void loadGraph_Click(object sender, EventArgs e)
        {
            var apiKey = textBoxApiName.Text;
            ListViewItem item = new ListViewItem();

            var parameters = new List<AlphaVantageApiWrapper.ApiParam>
                {
                    new AlphaVantageApiWrapper.AlphaVantageApiWrapper.ApiParam("function", AlphaVantageApiWrapper.AlphaVantageApiWrapper.AvFuncationEnum.TimeSeriesIntraday.ToDescription()),
                    new AlphaVantageApiWrapper.AlphaVantageApiWrapper.ApiParam("symbol", "MSFT"),
                    new AlphaVantageApiWrapper.AlphaVantageApiWrapper.ApiParam("interval", AlphaVantageApiWrapper.AlphaVantageApiWrapper.AvIntervalEnum.FiveMinutes.ToDescription()),
                    new AlphaVantageApiWrapper.AlphaVantageApiWrapper.ApiParam("time_period", "5"),
                    new AlphaVantageApiWrapper.AlphaVantageApiWrapper.ApiParam("series_type", AlphaVantageApiWrapper.AlphaVantageApiWrapper.AvSeriesType.Open.ToDescription()),
                };
            //parameters.FirstOrDefault(x => x.ParamName == "function").ParamValue = AlphaVantageApiWrapper.AlphaVantageApiWrapper.AvFuncationEnum.Stoch.ToDescription();
            var stock = await AlphaVantageApiWrapper.AlphaVantageApiWrapper.GetGeneralData(parameters, apiKey);

            foreach (var stocks in stock.GeneralByDate)
            {
                foreach (var stockInfo in stocks.Data)
                {
                    if (stockInfo.Key == "1. open")
                    {
                        double price = stockInfo.Value;
                        DateTime dateTime = stocks.Date;
                
                        this.chart1.Series["Apple"].Points.AddXY(dateTime, price);
                        this.chart1.ChartAreas[0].AxisX.IsReversed = true;

                        //Double.TryParse(test2, out Double result);
                        this.chart1.ChartAreas[0].AxisX.LabelStyle.Format = "MM/dd/yyyy HH:mm:ss";
                        //this.chart1.ChartAreas[0].AxisX.Interval = 1;
                        //this.chart1.ChartAreas[0].AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;
                        this.chart1.ChartAreas[0].AxisX.IntervalOffset = 1;
                          }
                }
            }
            this.chart1.ChartAreas[0].AxisY.Maximum = 104;
            this.chart1.ChartAreas[0].AxisY.Minimum = 100;
        }
    }
}
