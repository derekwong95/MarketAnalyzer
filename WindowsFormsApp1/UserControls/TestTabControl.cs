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

            string ticker = SearchBox.Text; // get ticker

            var parameters = new List<AlphaVantageApiWrapper.ApiParam>
                {
                    new AlphaVantageApiWrapper.ApiParam("function", AlphaVantageApiWrapper.AvFuncationEnum.TimeSeriesIntraday.ToDescription()),
                    new AlphaVantageApiWrapper.ApiParam("symbol", ticker),
                    new AlphaVantageApiWrapper.ApiParam("interval", AlphaVantageApiWrapper.AvIntervalEnum.FiveMinutes.ToDescription()),
                    new AlphaVantageApiWrapper.ApiParam("time_period", "5"),
                    new AlphaVantageApiWrapper.ApiParam("series_type", AlphaVantageApiWrapper.AvSeriesType.Open.ToDescription()),
                };
            var stock = await AlphaVantageApiWrapper.GetGeneralData(parameters, apiKey);

            chart1.Series["ticker"].Points.Clear();
  
            chart1.ChartAreas[0].AxisY.Maximum = Double.NaN; // sets the Maximum to NaN
            chart1.ChartAreas[0].AxisY.Minimum = Double.NaN; // sets the Maximum to NaN
            chart1.ChartAreas[0].RecalculateAxesScale();

            double yMaxValue = 0;
            double yMinValue = Int32.MaxValue;

            foreach (var stocks in stock.GeneralByDate)
            {
                foreach (var stockInfo in stocks.Data)
                {
                    if (stockInfo.Key == "1. open")
                    {
                        double price = stockInfo.Value;
    
                        if (yMaxValue < price)
                        {
                            yMaxValue = price;
                        }
                        if(yMinValue > price)
                        {
                            yMinValue = price;
                        }
                     
                        DateTime dateTime = stocks.Date;

                        chart1.Series["ticker"].Points.AddXY(dateTime, price);
                        chart1.ChartAreas[0].AxisX.IsReversed = true;

                        //Double.TryParse(test2, out Double result);
                        chart1.ChartAreas[0].AxisX.LabelStyle.Format = "MM/dd/yyyy HH:mm:ss";
                        //this.chart1.ChartAreas[0].AxisX.Interval = 1;
                        //this.chart1.ChartAreas[0].AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;
                        chart1.ChartAreas[0].AxisX.IntervalOffset = 1;

                    }
                }
            }
            chart1.ChartAreas[0].AxisY.Maximum = yMaxValue * 1.01;
            chart1.ChartAreas[0].AxisY.Minimum = yMinValue * .99;

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var apiKey = Singleton.Instance.Get();
            ListViewItem item = new ListViewItem();

            var parameters = new List<AlphaVantageApiWrapper.ApiParam>
                {
                    new AlphaVantageApiWrapper.ApiParam("function", AlphaVantageApiWrapper.AvFuncationEnum.SymbolSearch.ToDescription()),
                    new AlphaVantageApiWrapper.ApiParam("keywords", "micro"),
                };
            //parameters.FirstOrDefault(x => x.ParamName == "function").ParamValue = AlphaVantageApiWrapper.AlphaVantageApiWrapper.AvFuncationEnum.Stoch.ToDescription();
            var searchItems = await AlphaVantageApiWrapper.GetSearchEndPoint(parameters, apiKey);
            var test = searchItems;

        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void chart1_MouseMove(object sender, MouseEventArgs e)
        {
            textBox1.Text = e.Location.X + ":" + e.Location.Y;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void oneDayButton_Click(object sender, EventArgs e)
        {
            var apiKey = Singleton.Instance.Get();

            string ticker = SearchBox.Text; // get ticker

            var parameters = new List<AlphaVantageApiWrapper.ApiParam>
                {
                    new AlphaVantageApiWrapper.ApiParam("function", AlphaVantageApiWrapper.AvFuncationEnum.TimeSeriesIntraday.ToDescription()),
                    new AlphaVantageApiWrapper.ApiParam("symbol", ticker),
                    new AlphaVantageApiWrapper.ApiParam("interval", AlphaVantageApiWrapper.AvIntervalEnum.FiveMinutes.ToDescription()),
                    new AlphaVantageApiWrapper.ApiParam("time_period", "5"),
                    new AlphaVantageApiWrapper.ApiParam("series_type", AlphaVantageApiWrapper.AvSeriesType.Open.ToDescription()),
                };
            var stock = await AlphaVantageApiWrapper.GetGeneralData(parameters, apiKey);
            int timeframe = 1;
            loadgraph(stock, timeframe);
        }

        private void loadgraph(AlphaVantageApiWrapper.AlphaVantageRootObject stockData, int daysBack)
        {
            DateTime now = DateTime.Today;
            DateTime dateFrom = now.AddDays(-daysBack);

            chart1.Series["ticker"].Points.Clear();

            //chart1.ChartAreas[0].AxisY.Maximum = Double.NaN; // sets the Maximum to NaN
            //chart1.ChartAreas[0].AxisY.Minimum = Double.NaN; // sets the Maximum to NaN
            //chart1.ChartAreas[0].RecalculateAxesScale();

            double yMaxValue = 0;
            double yMinValue = Int32.MaxValue;

            foreach (var stocks in stockData.GeneralByDate)
            {
                foreach (var stockInfo in stocks.Data)
                {
                    if (stockInfo.Key == "1. open" && stocks.Date > dateFrom)
                    {
                        double price = stockInfo.Value;

                        if (yMaxValue < price)
                        {
                            yMaxValue = price;
                        }
                        if (yMinValue > price)
                        {
                            yMinValue = price;
                        }

                        DateTime dateTime = stocks.Date;

                        chart1.Series["ticker"].Points.AddXY(dateTime, price);
                        chart1.ChartAreas[0].AxisX.IsReversed = true;

                        //Double.TryParse(test2, out Double result);
                        chart1.ChartAreas[0].AxisX.LabelStyle.Format = "MM/dd/yyyy HH:mm:ss";
                        //this.chart1.ChartAreas[0].AxisX.Interval = 1;
                        //this.chart1.ChartAreas[0].AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;
                        chart1.ChartAreas[0].AxisX.IntervalOffset = 1;

                    }
                }
            }
            chart1.ChartAreas[0].AxisY.Maximum = yMaxValue * 1.01;
            chart1.ChartAreas[0].AxisY.Minimum = yMinValue * .99;

        }

        private async void oneWeekButton_Click(object sender, EventArgs e)
        {
            var apiKey = Singleton.Instance.Get();

            string ticker = SearchBox.Text; // get ticker

            var parameters = new List<AlphaVantageApiWrapper.ApiParam>
                {
                    new AlphaVantageApiWrapper.ApiParam("function", AlphaVantageApiWrapper.AvFuncationEnum.TimeSeriesDaily.ToDescription()),
                    new AlphaVantageApiWrapper.ApiParam("symbol", ticker),
                    new AlphaVantageApiWrapper.ApiParam("interval", AlphaVantageApiWrapper.AvIntervalEnum.FifteenMinutes.ToDescription()),
                    new AlphaVantageApiWrapper.ApiParam("time_period", "5"),
                    new AlphaVantageApiWrapper.ApiParam("series_type", AlphaVantageApiWrapper.AvSeriesType.Open.ToDescription()),
                };
            var stock = await AlphaVantageApiWrapper.GetGeneralData(parameters, apiKey);
            loadgraph(stock, 7);
        }

        private async void oneMonthButton_Click(object sender, EventArgs e)
        {
            var apiKey = Singleton.Instance.Get();

            string ticker = SearchBox.Text; // get ticker

            var parameters = new List<AlphaVantageApiWrapper.ApiParam>
                {
                    new AlphaVantageApiWrapper.ApiParam("function", AlphaVantageApiWrapper.AvFuncationEnum.TimeSeriesDaily.ToDescription()),
                    new AlphaVantageApiWrapper.ApiParam("symbol", ticker),
                    new AlphaVantageApiWrapper.ApiParam("interval", AlphaVantageApiWrapper.AvIntervalEnum.SixtyMinutes.ToDescription()),
                    new AlphaVantageApiWrapper.ApiParam("time_period", "5"),
                    new AlphaVantageApiWrapper.ApiParam("series_type", AlphaVantageApiWrapper.AvSeriesType.Open.ToDescription()),
                };
            var stock = await AlphaVantageApiWrapper.GetGeneralData(parameters, apiKey);
            loadgraph(stock, 30);
        }

        private async void threeMonthButton_Click(object sender, EventArgs e)
        {
            var apiKey = Singleton.Instance.Get();

            string ticker = SearchBox.Text; // get ticker

            var parameters = new List<AlphaVantageApiWrapper.ApiParam>
                {
                    new AlphaVantageApiWrapper.ApiParam("function", AlphaVantageApiWrapper.AvFuncationEnum.TimeSeriesDaily.ToDescription()),
                    new AlphaVantageApiWrapper.ApiParam("symbol", ticker),
                    new AlphaVantageApiWrapper.ApiParam("interval", AlphaVantageApiWrapper.AvIntervalEnum.Daily.ToDescription()),
                    new AlphaVantageApiWrapper.ApiParam("time_period", "5"),
                    new AlphaVantageApiWrapper.ApiParam("series_type", AlphaVantageApiWrapper.AvSeriesType.Open.ToDescription()),
                };
            var stock = await AlphaVantageApiWrapper.GetGeneralData(parameters, apiKey);
            loadgraph(stock, 90);
        }

        private async void oneYearButton_Click(object sender, EventArgs e)
        {
            var apiKey = Singleton.Instance.Get();

            string ticker = SearchBox.Text; // get ticker

            var parameters = new List<AlphaVantageApiWrapper.ApiParam>
                {
                    new AlphaVantageApiWrapper.ApiParam("function", AlphaVantageApiWrapper.AvFuncationEnum.TimeSeriesDaily.ToDescription()),
                    new AlphaVantageApiWrapper.ApiParam("symbol", ticker),
                    new AlphaVantageApiWrapper.ApiParam("interval", AlphaVantageApiWrapper.AvIntervalEnum.Weekly.ToDescription()),
                    new AlphaVantageApiWrapper.ApiParam("time_period", "100"),
                    new AlphaVantageApiWrapper.ApiParam("series_type", AlphaVantageApiWrapper.AvSeriesType.Open.ToDescription()),
                };
            var stock = await AlphaVantageApiWrapper.GetGeneralData(parameters, apiKey);
            loadgraph(stock, 365);
        }

        private async void fiveYearButton_Click(object sender, EventArgs e)
        {
            var apiKey = Singleton.Instance.Get();

            string ticker = SearchBox.Text; // get ticker

            var parameters = new List<AlphaVantageApiWrapper.ApiParam>
                {
                    new AlphaVantageApiWrapper.ApiParam("function", AlphaVantageApiWrapper.AvFuncationEnum.TimeSeriesDaily.ToDescription()),
                    new AlphaVantageApiWrapper.ApiParam("symbol", ticker),
                    new AlphaVantageApiWrapper.ApiParam("interval", AlphaVantageApiWrapper.AvIntervalEnum.Monthly.ToDescription()),
                    new AlphaVantageApiWrapper.ApiParam("time_period", "100"),
                    new AlphaVantageApiWrapper.ApiParam("series_type", AlphaVantageApiWrapper.AvSeriesType.Open.ToDescription()),
                };
            var stock = await AlphaVantageApiWrapper.GetGeneralData(parameters, apiKey);
            loadgraph(stock, 1825);
        }
    }
}
