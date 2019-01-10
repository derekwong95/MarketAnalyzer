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
    public partial class GeneralTabControl : UserControl
    {
        public GeneralTabControl()
        {
            InitializeComponent();
        }

        private async void buttonGetSector_Click(object sender, EventArgs e)
        {
            var apiKey = Singleton.Instance.Get();
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
    }
}
