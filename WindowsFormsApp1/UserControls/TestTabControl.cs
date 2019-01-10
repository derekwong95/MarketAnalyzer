using WindowsFormsApp1.Libraries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.UserControls
{
    public partial class TestTabControl : UserControl
    {
        public TestTabControl()
        {
            InitializeComponent();
        }

        private async void loadGraph_Click(object sender, EventArgs e)
        {
            var apiKey = Singleton.Instance.Get();
            ListViewItem item = new ListViewItem();

            var parameters = new List<AlphaVantageApiWrapper.ApiParam>
                {
                    new AlphaVantageApiWrapper.ApiParam("function", AlphaVantageApiWrapper.AvFuncationEnum.TimeSeriesIntraday.ToDescription()),
                    new AlphaVantageApiWrapper.ApiParam("symbol", "MSFT"),
                    new AlphaVantageApiWrapper.ApiParam("interval", AlphaVantageApiWrapper.AvIntervalEnum.FiveMinutes.ToDescription()),
                    new AlphaVantageApiWrapper.ApiParam("time_period", "5"),
                    new AlphaVantageApiWrapper.ApiParam("series_type", AlphaVantageApiWrapper.AvSeriesType.Open.ToDescription()),
                };
            //parameters.FirstOrDefault(x => x.ParamName == "function").ParamValue = AlphaVantageApiWrapper.AlphaVantageApiWrapper.AvFuncationEnum.Stoch.ToDescription();
            var stock = await AlphaVantageApiWrapper.GetGeneralData(parameters, apiKey);

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
