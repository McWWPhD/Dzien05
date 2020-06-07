namespace StooqParser
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tbTicker = new System.Windows.Forms.TextBox();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.dtStop = new System.Windows.Forms.DateTimePicker();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnParse = new System.Windows.Forms.Button();
            this.liveChart = new LiveCharts.WinForms.CartesianChart();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // tbTicker
            // 
            this.tbTicker.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbTicker.Location = new System.Drawing.Point(39, 39);
            this.tbTicker.MaxLength = 3;
            this.tbTicker.Name = "tbTicker";
            this.tbTicker.Size = new System.Drawing.Size(100, 20);
            this.tbTicker.TabIndex = 0;
            // 
            // dtStart
            // 
            this.dtStart.Location = new System.Drawing.Point(232, 39);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(200, 20);
            this.dtStart.TabIndex = 1;
            // 
            // dtStop
            // 
            this.dtStop.Location = new System.Drawing.Point(529, 39);
            this.dtStop.Name = "dtStop";
            this.dtStop.Size = new System.Drawing.Size(200, 20);
            this.dtStop.TabIndex = 2;
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(39, 121);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(501, 339);
            this.dgvData.TabIndex = 3;
            this.dgvData.TabStop = false;
            // 
            // chart
            // 
            chartArea4.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart.Legends.Add(legend4);
            this.chart.Location = new System.Drawing.Point(575, 121);
            this.chart.Name = "chart";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.LegendText = "Kurs zamknięcia";
            series7.Name = "CLOSE";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.LegendText = "Wolumen akcji";
            series8.Name = "VOLUME";
            series8.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.chart.Series.Add(series7);
            this.chart.Series.Add(series8);
            this.chart.Size = new System.Drawing.Size(578, 351);
            this.chart.TabIndex = 4;
            this.chart.Text = "chart1";
            // 
            // btnParse
            // 
            this.btnParse.Location = new System.Drawing.Point(847, 26);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(145, 50);
            this.btnParse.TabIndex = 5;
            this.btnParse.Text = "Pobierz";
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // liveChart
            // 
            this.liveChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.liveChart.Location = new System.Drawing.Point(82, 526);
            this.liveChart.Name = "liveChart";
            this.liveChart.Size = new System.Drawing.Size(1028, 286);
            this.liveChart.TabIndex = 6;
            this.liveChart.Text = "cartesianChart1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 893);
            this.Controls.Add(this.liveChart);
            this.Controls.Add(this.btnParse);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.dtStop);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.tbTicker);
            this.Name = "frmMain";
            this.Text = "StooQ";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTicker;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.DateTimePicker dtStop;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button btnParse;
        private LiveCharts.WinForms.CartesianChart liveChart;
    }
}

