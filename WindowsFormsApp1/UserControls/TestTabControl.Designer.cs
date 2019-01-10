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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.loadGraph = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // loadGraph
            // 
            this.loadGraph.Location = new System.Drawing.Point(517, 3);
            this.loadGraph.Name = "loadGraph";
            this.loadGraph.Size = new System.Drawing.Size(255, 40);
            this.loadGraph.TabIndex = 2;
            this.loadGraph.Text = "Load Graph";
            this.loadGraph.UseVisualStyleBackColor = true;
            this.loadGraph.Click += new System.EventHandler(this.loadGraph_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.DockedToChartArea = "ChartArea1";
            legend2.Name = "Apple";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(3, 68);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsXValueIndexed = true;
            series2.Legend = "Apple";
            series2.Name = "Apple";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1335, 524);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            title2.BackColor = System.Drawing.Color.Transparent;
            title2.BorderWidth = 10;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            title2.Name = "Stock Price";
            title2.Text = "Stock Price";
            this.chart1.Titles.Add(title2);
            // 
            // TestTabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.loadGraph);
            this.Name = "TestTabControl";
            this.Size = new System.Drawing.Size(1350, 654);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button loadGraph;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
