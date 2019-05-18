using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.UserControls;
using System.Windows.Forms;
using System.Drawing;
using WindowsFormsApp1.Libraries;

namespace WindowsFormsApp1.Helper
{
    class WatchlistSingleton
    {
        private static WatchlistSingleton instance;
        private static readonly Lazy<WatchlistSingleton> lazy =
            new Lazy<WatchlistSingleton>(() => new WatchlistSingleton());

        private Form form2;
        private ListView watchlist;
        private Timer timer = new Timer();

        public static WatchlistSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new WatchlistSingleton();
                }
                return instance;
            }
        }

        private WatchlistSingleton()
        {
            timer.Interval = 60000; // 1min refresh 
            timer.Tick += new EventHandler(Timer_Tick);

            form2 = new Form();
            form2.Text = "Watchlist";
            form2.Size = new Size(235, 300);

            form2.FormClosed += Form2_FormClosed;

            CreateWatchlistListView();

            form2.Controls.Add(CreateRefreshButton());
            form2.Controls.Add(CreateRemoveButton());
            form2.Controls.Add(watchlist);
            
            form2.Show();
        }

        public void Set(ListViewItem item)
        {
            watchlist.Items.Add(item);
        }

        public int Get()
        {
            return watchlist.Items.Count;
        }

        private void CreateWatchlistListView()
        {
            var columnHeaderName = new ColumnHeader
            {
                Text = "Name",
                Width = 80
            };
            var columnHeaderPrice = new ColumnHeader
            {
                Text = "Price"
            };
            var columnHeaderChange = new ColumnHeader
            {
                Text = "Change"
            };

            watchlist = new ListView
            {
                Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                Bounds = new Rectangle(new Point(0, 30), new Size(220, 300)),
                Name = "watchlist",
                Size = new Size(220, 300),
                UseCompatibleStateImageBehavior = false,
                View = View.Details,
                CheckBoxes = true,
            };

            watchlist.Columns.AddRange(new ColumnHeader[] {
            columnHeaderName,
            columnHeaderPrice,
            columnHeaderChange});
        }

        private Button CreateRefreshButton()
        {
            Button autoRefresh = new Button
            {
                Text = "Auto [OFF]",
                Bounds = new Rectangle(new Point(0, 0), new Size(110, 30)),
                BackColor = Color.Red,
            };

            autoRefresh.Click += (s, e) =>
            {
                if (autoRefresh.Text == "Auto [OFF]")
                {
                    autoRefresh.Text = "Auto [ON]";
                    autoRefresh.BackColor = Color.Green;
                    timer.Enabled = true;
                }
                else
                {
                    autoRefresh.Text = "Auto [OFF]";
                    autoRefresh.BackColor = Color.Red;
                    timer.Enabled = false;
                }
            };

            return autoRefresh;
        }

        private Button CreateRemoveButton()
        {
            Button remove = new Button
            {
                Text = "Remove",
                Bounds = new Rectangle(new Point(110, 0), new Size(110, 30))
            };

            remove.Click += (s, e) =>
            {
                foreach (ListViewItem item in watchlist.CheckedItems)
                {
                    watchlist.Items.Remove(item);
                }
            };

            return remove;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            instance = null;
        }

        private async void Timer_Tick(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();

            foreach (ListViewItem ticker in watchlist.Items)
            { 
                var parameters = new List<AlphaVantageApiWrapper.ApiParam>
                    {
                        new AlphaVantageApiWrapper.ApiParam("function", AlphaVantageApiWrapper.AvFuncationEnum.GlobalQuote.ToDescription()),
                        new AlphaVantageApiWrapper.ApiParam("symbol", ticker.Text),
                    };

                var stockQuotes = await AlphaVantageApiWrapper.GetQuoteEndPoint(parameters, Singleton.Instance.Get());

                foreach (var quote in stockQuotes.BestMatchesData)
                {
                    ticker.SubItems[1].Text = quote.Data[4].Value;
                    ticker.SubItems[2].Text = quote.Data[9].Value;
                }
            }
        }


    }
}
