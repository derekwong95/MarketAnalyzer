namespace WindowsFormsApp1.UserControls
{
    partial class TestTabControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.loadGraph = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.oneDayButton = new System.Windows.Forms.Button();
            this.oneWeekButton = new System.Windows.Forms.Button();
            this.oneMonthButton = new System.Windows.Forms.Button();
            this.threeMonthButton = new System.Windows.Forms.Button();
            this.oneYearButton = new System.Windows.Forms.Button();
            this.fiveYearButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // loadGraph
            // 
            this.loadGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadGraph.Location = new System.Drawing.Point(272, 3);
            this.loadGraph.Name = "loadGraph";
            this.loadGraph.Size = new System.Drawing.Size(255, 62);
            this.loadGraph.TabIndex = 2;
            this.loadGraph.Text = "Search";
            this.loadGraph.UseVisualStyleBackColor = true;
            this.loadGraph.Click += new System.EventHandler(this.loadGraph_Click);
            // 
            // chart1
            // 
            chartArea4.AxisX.MajorGrid.Enabled = false;
            chartArea4.AxisX.MajorTickMark.Enabled = false;
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            this.chart1.Location = new System.Drawing.Point(3, 68);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.IsXValueIndexed = true;
            series4.Name = "ticker";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series4.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(1335, 524);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            title4.BackColor = System.Drawing.Color.Transparent;
            title4.BorderWidth = 10;
            title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            title4.Name = "Stock Price";
            title4.Text = "Stock Price";
            this.chart1.Titles.Add(title4);
            this.chart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseMove);
            // 
            // SearchBox
            // 
            this.SearchBox.AutoCompleteCustomSource.AddRange(new string[] {
            "AMD",
            "AAPL",
            "AMZN",
            "GOOGL",
            "SNAP",
            "DIS",
            "IQ",
            "NVDA",
            "SPY",
            "FB",
            "V",
            "MSFT",
            "EA",
            "ATVI",
            "SQ",
            "CRON"});
            this.SearchBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SearchBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.SearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.Location = new System.Drawing.Point(3, 3);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(263, 62);
            this.SearchBox.TabIndex = 5;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // oneDayButton
            // 
            this.oneDayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneDayButton.Location = new System.Drawing.Point(43, 598);
            this.oneDayButton.Name = "oneDayButton";
            this.oneDayButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.oneDayButton.Size = new System.Drawing.Size(200, 50);
            this.oneDayButton.TabIndex = 6;
            this.oneDayButton.Text = "1 Day";
            this.oneDayButton.UseVisualStyleBackColor = true;
            this.oneDayButton.Click += new System.EventHandler(this.oneDayButton_Click);
            // 
            // oneWeekButton
            // 
            this.oneWeekButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.oneWeekButton.Location = new System.Drawing.Point(249, 598);
            this.oneWeekButton.Name = "oneWeekButton";
            this.oneWeekButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.oneWeekButton.Size = new System.Drawing.Size(200, 50);
            this.oneWeekButton.TabIndex = 7;
            this.oneWeekButton.Text = "1 Week";
            this.oneWeekButton.UseVisualStyleBackColor = true;
            this.oneWeekButton.Click += new System.EventHandler(this.oneWeekButton_Click);
            // 
            // oneMonthButton
            // 
            this.oneMonthButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.oneMonthButton.Location = new System.Drawing.Point(455, 598);
            this.oneMonthButton.Name = "oneMonthButton";
            this.oneMonthButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.oneMonthButton.Size = new System.Drawing.Size(200, 50);
            this.oneMonthButton.TabIndex = 8;
            this.oneMonthButton.Text = "1 Month";
            this.oneMonthButton.UseVisualStyleBackColor = true;
            this.oneMonthButton.Click += new System.EventHandler(this.oneMonthButton_Click);
            // 
            // threeMonthButton
            // 
            this.threeMonthButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.threeMonthButton.Location = new System.Drawing.Point(661, 598);
            this.threeMonthButton.Name = "threeMonthButton";
            this.threeMonthButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.threeMonthButton.Size = new System.Drawing.Size(200, 50);
            this.threeMonthButton.TabIndex = 9;
            this.threeMonthButton.Text = "3 Month";
            this.threeMonthButton.UseVisualStyleBackColor = true;
            this.threeMonthButton.Click += new System.EventHandler(this.threeMonthButton_Click);
            // 
            // oneYearButton
            // 
            this.oneYearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.oneYearButton.Location = new System.Drawing.Point(867, 598);
            this.oneYearButton.Name = "oneYearButton";
            this.oneYearButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.oneYearButton.Size = new System.Drawing.Size(200, 50);
            this.oneYearButton.TabIndex = 10;
            this.oneYearButton.Text = "1 Year";
            this.oneYearButton.UseVisualStyleBackColor = true;
            this.oneYearButton.Click += new System.EventHandler(this.oneYearButton_Click);
            // 
            // fiveYearButton
            // 
            this.fiveYearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.fiveYearButton.Location = new System.Drawing.Point(1073, 598);
            this.fiveYearButton.Name = "fiveYearButton";
            this.fiveYearButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fiveYearButton.Size = new System.Drawing.Size(200, 50);
            this.fiveYearButton.TabIndex = 11;
            this.fiveYearButton.Text = "5 Year";
            this.fiveYearButton.UseVisualStyleBackColor = true;
            this.fiveYearButton.Click += new System.EventHandler(this.fiveYearButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(533, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(276, 20);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(1051, 9);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(174, 53);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // TestTabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.fiveYearButton);
            this.Controls.Add(this.oneYearButton);
            this.Controls.Add(this.threeMonthButton);
            this.Controls.Add(this.oneMonthButton);
            this.Controls.Add(this.oneWeekButton);
            this.Controls.Add(this.oneDayButton);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.loadGraph);
            this.Name = "TestTabControl";
            this.Size = new System.Drawing.Size(1347, 709);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button loadGraph;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button oneDayButton;
        private System.Windows.Forms.Button oneWeekButton;
        private System.Windows.Forms.Button oneMonthButton;
        private System.Windows.Forms.Button threeMonthButton;
        private System.Windows.Forms.Button oneYearButton;
        private System.Windows.Forms.Button fiveYearButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView listView1;
    }
}
