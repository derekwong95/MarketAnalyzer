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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.loadGraph = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
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
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.DockedToChartArea = "ChartArea1";
            legend1.Name = "Apple";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 68);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsXValueIndexed = true;
            series1.Legend = "Apple";
            series1.Name = "Apple";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1335, 524);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            title1.BackColor = System.Drawing.Color.Transparent;
            title1.BorderWidth = 10;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            title1.Name = "Stock Price";
            title1.Text = "Stock Price";
            this.chart1.Titles.Add(title1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(895, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TestTabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
    }
}
