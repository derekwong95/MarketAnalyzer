using AlphaVantageApiWrapper;
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

        }

        private async void buttonSubmit_Click(object sender, EventArgs e)
        {
            var API_KEY = textBoxApiName.Text;

            var StockTickers = new List<string> { "AAPL" };

            var parameters = new List<AlphaVantageApiWrapper.AlphaVantageApiWrapper.ApiParam>
                {
                    new AlphaVantageApiWrapper.AlphaVantageApiWrapper.ApiParam("function", AlphaVantageApiWrapper.AlphaVantageApiWrapper.AvFuncationEnum.Sma.ToDescription()),
                    new AlphaVantageApiWrapper.AlphaVantageApiWrapper.ApiParam("symbol", "AAPL"),
                    new AlphaVantageApiWrapper.AlphaVantageApiWrapper.ApiParam("interval", AlphaVantageApiWrapper.AlphaVantageApiWrapper.AvIntervalEnum.Daily.ToDescription()),
                    new AlphaVantageApiWrapper.AlphaVantageApiWrapper.ApiParam("time_period", "5"),
                    new AlphaVantageApiWrapper.AlphaVantageApiWrapper.ApiParam("series_type", AlphaVantageApiWrapper.AlphaVantageApiWrapper.AvSeriesType.Open.ToDescription()),
                };

            var SMA_5 = await AlphaVantageApiWrapper.AlphaVantageApiWrapper.GetTechnical(parameters, API_KEY);
            parameters.FirstOrDefault(x => x.ParamName == "time_period").ParamValue = "20";

            ListViewItem listItem = new ListViewItem();
            listItem.SubItems.Add(SMA_5.ToString());
            listItem.SubItems.Add("test");
            //listViewData.Columns.Add("testing");
            listViewData.Items.Add(SMA_5.ToString());
            listViewData.View = View.Details;

        }

        private void textBoxApiName_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
