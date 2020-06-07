using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Shapes;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Helpers;
using LiveCharts.Wpf;
using Series = System.Windows.Forms.DataVisualization.Charting.Series;

namespace StooqParser
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            dtStop.Value = DateTime.Now;
            dtStart.Value = DateTime.Now.AddMonths(-1);
            chart.Visible = false;
            tbTicker.Focus();
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            //https://stooq.pl/q/d/l/?s=cdr&d1=20200501&d2=20200515&i=d

            string ticker = tbTicker.Text.ToLower();
            string d1 = dtStart.Value.ToString("yyyyMMdd");
            string d2 = dtStop.Value.ToString("yyyyMMdd");
            string url = string.Format("https://stooq.pl/q/d/l/?s={0}&d1={1}&d2={2}&i=d", ticker, d1, d2);

            dgvData.Columns.Clear();
            dgvData.Columns.Add("DATE", "Data");
            dgvData.Columns.Add("CLOSE", "Kurs zamknięcia");
            dgvData.Columns.Add("VOLUME", "Wolumen");

            dgvData.Columns[0].Width = 100;
            dgvData.Columns[1].Width = 200;
            dgvData.Columns[2].Width = 100;

            Series seriesClose = chart.Series["CLOSE"];  //chart.Series[0];
            seriesClose.Points.Clear();

            Series seriesVolume = chart.Series["VOLUME"];  //chart.Series[1];
            seriesVolume.Points.Clear();

            liveChart.Series.Clear();
            liveChart.AxisX.Clear();
            liveChart.AxisY.Clear();


            try
            {
                WebClient webClient = new WebClient();
                string s = webClient.DownloadString(url);
                string[] lines = s.Split('\n');
                
                List<string> date = new List<string>();
                List<double> close= new List<double>();
                List<int> volume = new List<int>();



                for (int i = 1; i < lines.Length; i++)
                {
                    string line = lines[i];
                    string[] items = line.Trim().Split(',');
                    if (items.Length == 6)
                    {
                        string[] row = new string[3]
                        {
                            items[0],
                            items[4],
                            items[5],
                        };
                        dgvData.Rows.Add(row);

                        seriesClose.Points.AddXY(items[0], Double.Parse(items[4], CultureInfo.InvariantCulture));
                        seriesVolume.Points.AddXY(items[0], Int32.Parse(items[5]));

                        date.Add(items[0]);
                        close.Add(double.Parse(items[4].Replace('.',',')) );
                        volume.Add(Int32.Parse(items[5]) );

                    }

                }

                //LiveChart
                liveChart.Series.Add(new LineSeries

                {
                    Title = "Kurs zamnięcia",
                    Values = close.AsChartValues(),
                    ScalesYAt = 0,
                    //DataLabels = true,
                    PointGeometrySize = 10

                });

                liveChart.Series.Add(new LineSeries
                {
                    Title = "Wolumen",
                    Values = volume.AsChartValues(),
                    ScalesYAt = 1,
                    //DataLabels = true,
                    PointGeometrySize = 10


                });

                liveChart.AxisY.Add(new LiveCharts.Wpf.Axis
                {
                    Foreground = System.Windows.Media.Brushes.Blue,

                    Title = "Kurs zamnięcia"
                });

                liveChart.AxisY.Add(new LiveCharts.Wpf.Axis
                {
                    Foreground = System.Windows.Media.Brushes.Red,

                    Title = "Wolumen",
                    Position = AxisPosition.RightTop
                });

                liveChart.AxisX.Add(new LiveCharts.Wpf.Axis
                {
                    Labels = date
                });

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            chart.Visible = true;

        }
    }
}
