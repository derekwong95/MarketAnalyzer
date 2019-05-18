using WindowsFormsApp1.Libraries;
using WindowsFormsApp1.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace WindowsFormsApp1.UserControls
{
    public partial class GeneralTabControl : UserControl
    {
        int watchListCounter = 0;

        public GeneralTabControl()
        {
            InitializeComponent();
        }

        private async void buttonGetSector_Click(object sender, EventArgs e)
        {
            var apiKey = Singleton.Instance.Get();
            ListViewItem item = new ListViewItem();
            ClearAllSectorListView();

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
                            listView5Day.Items.Add(item);
                            break;
                        case "Rank D: 1 Month Performance":
                            listView1Month.Items.Add(item);
                            break;
                        case "Rank E: 3 Month Performance":
                            listView3Month.Items.Add(item);
                            break;
                        case "Rank F: Year-to-Date (YTD) Performance":
                            listViewYearToDate.Items.Add(item);
                            break;
                        case "Rank G: 1 Year Performance":
                            listView1Year.Items.Add(item);
                            break;
                        case "Rank H: 3 Year Performance":
                            listView3Year.Items.Add(item);
                            break;
                        case "Rank I: 5 Year Performance":
                            listView5Year.Items.Add(item);
                            break;
                        case "Rank J: 10 Year Performance":
                            listView10Year.Items.Add(item);
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private void textBoxSymbol_Leave(object sender, EventArgs e)
        {
            if (textBoxSymbol.Text.Length == 0)
            {
                textBoxSymbol.Text = "ENTER SYMBOL";
                textBoxSymbol.ForeColor = SystemColors.GrayText;
            }

        }

        private void textBoxSymbol_Enter(object sender, EventArgs e)
        {
            if (textBoxSymbol.Text == "ENTER SYMBOL")
            {
                textBoxSymbol.Text = "";
                textBoxSymbol.ForeColor = SystemColors.WindowText;
            }
        }

        private async void buttonAddToList_Click(object sender, EventArgs e)
        {
            if (WatchlistSingleton.Instance.Get() < 5)
            {
                var apiKey = Singleton.Instance.Get();
                ListViewItem item = new ListViewItem();
                ListView listView = new ListView();
                TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

                var Form2 = WatchlistSingleton.Instance;

                var parameters = new List<AlphaVantageApiWrapper.ApiParam>
                {
                    new AlphaVantageApiWrapper.ApiParam("function", AlphaVantageApiWrapper.AvFuncationEnum.GlobalQuote.ToDescription()),
                    new AlphaVantageApiWrapper.ApiParam("symbol", textBoxSymbol.Text),
                };

                var stockQuotes = await AlphaVantageApiWrapper.GetQuoteEndPoint(parameters, apiKey);

                foreach (var quote in stockQuotes.BestMatchesData)
                {
                    if (quote.Data.Count > 8)
                    {
                        item = new ListViewItem(new[] { textInfo.ToTitleCase(quote.Data[0].Value), quote.Data[4].Value, quote.Data[9].Value });
                        item.UseItemStyleForSubItems = false;
                        if (item.SubItems[2].Text.Contains("-"))
                        {
                            item.SubItems[2].BackColor = Color.Red;
                        }
                        else
                        {
                            item.SubItems[2].BackColor = Color.LightGreen;
                        }

                        WatchlistSingleton.Instance.Set(item);
                    }
                }
            }
            else
            {
                MessageBox.Show("Watchlist is limited to 5 ticker");
            }

            textBoxSymbol.Text = "";
            textBoxSymbol_Leave(sender, e);          
        }

        /*
        private async void comboBox1_TextChanged(object sender, EventArgs e)
        {
            comboBox1.Text = comboBox1.Text.ToUpper();
            if (comboBox1.Text.Length == 0)
            {
                comboBox1.Items.Clear();
            }

            var apiKey = Singleton.Instance.Get();
            ListViewItem item = new ListViewItem();

            var parameters = new List<AlphaVantageApiWrapper.ApiParam>
                {
                    new AlphaVantageApiWrapper.ApiParam("function", AlphaVantageApiWrapper.AvFuncationEnum.SymbolSearch.ToDescription()),
                    new AlphaVantageApiWrapper.ApiParam("keywords", comboBox1.Text),
                };

            var stockNames = await AlphaVantageApiWrapper.GetSearchEndPoint(parameters, apiKey);

            foreach (var bestMatch in stockNames.BestMatchesData)
            {
                foreach (var data in bestMatch.Data)
                {
                    if (!comboBox1.Items.Contains(data.Value))
                    {
                        comboBox1.Items.Add(data.Value);
                    }

                    break; //adds only the symbol
                }
            }
            //comboBox1.Items.Insert(0, "test");
            comboBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;

            //stockNames.BestMatchesData.Select(x => 


            //comboBox1.DataSource = t;
            //comboBox1.ValueMember = "BankName";
            //comboBox1.DisplayMember = "BankName";

        } 

        private ListView CreateMyListView(string name)
        {
            int x = 0;

            for (int i = 0; i < watchListCounter; i++)
            {
                x += 209;
            }

            // Create a new ListView control.
            ListView listView = new ListView
            {
                // Allow the user to rearrange columns.
                AllowColumnReorder = true,
                // Set bounds
                Bounds = new Rectangle(new Point(x, 0), new Size(204, 222)),
                // Select the item and subitems when selection is made.
                FullRowSelect = true,
                // Allow the user to edit item text.
                LabelEdit = true,
                // Name the listview
                Name = name,
                // Set the view to show details.
                View = View.Details,

                Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)))
            };

                listView.Columns.AddRange(new[] {
                new ColumnHeader { Text = "Name", TextAlign = HorizontalAlignment.Left, Width = 120 },
                new ColumnHeader { Text = "Value", TextAlign = HorizontalAlignment.Left, Width = 80 }
            });

            panel2.Controls.Add(listView);

            watchListCounter++;

            Button button = new Button
            {
                Bounds = new Rectangle(new Point(x, 225), new Size(204, 30)),
                Name = "button" + name,
                Text = "Remove",
                Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                UseVisualStyleBackColor = true
            };

            button.Click += (s, e) => 
            {
                panel2.Controls.Remove(listView);
                panel2.Controls.Remove(button);
                //reorganize listViews
                //watchListCounter--;

                //object
                //{
                //    Position
                //    listViewObject data
                //}
            };

            panel2.Controls.Add(button);

            return listView;
    }*/

        private void ClearAllSectorListView()
        {
            listViewRealTime.Items.Clear();
            listView5Day.Items.Clear();
            listView1Month.Items.Clear();
            listView3Month.Items.Clear();
            listViewYearToDate.Items.Clear();
            listView1Year.Items.Clear();
            listView3Year.Items.Clear();
            listView5Year.Items.Clear();
            listView10Year.Items.Clear();
        }
        

    }
}
