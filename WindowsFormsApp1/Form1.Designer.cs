namespace MarketAnalyzer
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.labelApiName = new System.Windows.Forms.Label();
            this.textBoxApiName = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageGeneral = new System.Windows.Forms.TabPage();
            this.listView10Year = new System.Windows.Forms.ListView();
            this.listView5Year = new System.Windows.Forms.ListView();
            this.listView3Year = new System.Windows.Forms.ListView();
            this.listView1Year = new System.Windows.Forms.ListView();
            this.listViewYearToDate = new System.Windows.Forms.ListView();
            this.listView3Month = new System.Windows.Forms.ListView();
            this.listView1Month = new System.Windows.Forms.ListView();
            this.listView5Day = new System.Windows.Forms.ListView();
            this.listView1Day = new System.Windows.Forms.ListView();
            this.columnHeader1DayName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1DayValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonSector = new System.Windows.Forms.Button();
            this.listViewRealTime = new System.Windows.Forms.ListView();
            this.columnHeaderRealTimeName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderRealTimeValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.loadGraph = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1.SuspendLayout();
            this.tabPageGeneral.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelApiName
            // 
            this.labelApiName.AutoSize = true;
            this.labelApiName.Location = new System.Drawing.Point(12, 9);
            this.labelApiName.Name = "labelApiName";
            this.labelApiName.Size = new System.Drawing.Size(43, 13);
            this.labelApiName.TabIndex = 0;
            this.labelApiName.Text = "Api Key";
            this.labelApiName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxApiName
            // 
            this.textBoxApiName.Location = new System.Drawing.Point(61, 6);
            this.textBoxApiName.Name = "textBoxApiName";
            this.textBoxApiName.Size = new System.Drawing.Size(314, 20);
            this.textBoxApiName.TabIndex = 1;
            this.textBoxApiName.TextChanged += new System.EventHandler(this.textBoxApiName_TextChanged);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(381, 4);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(80, 23);
            this.buttonSubmit.TabIndex = 3;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageGeneral);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(15, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1239, 654);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPageGeneral
            // 
            this.tabPageGeneral.Controls.Add(this.listView10Year);
            this.tabPageGeneral.Controls.Add(this.listView5Year);
            this.tabPageGeneral.Controls.Add(this.listView3Year);
            this.tabPageGeneral.Controls.Add(this.listView1Year);
            this.tabPageGeneral.Controls.Add(this.listViewYearToDate);
            this.tabPageGeneral.Controls.Add(this.listView3Month);
            this.tabPageGeneral.Controls.Add(this.listView1Month);
            this.tabPageGeneral.Controls.Add(this.listView5Day);
            this.tabPageGeneral.Controls.Add(this.listView1Day);
            this.tabPageGeneral.Controls.Add(this.buttonSector);
            this.tabPageGeneral.Controls.Add(this.listViewRealTime);
            this.tabPageGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabPageGeneral.Name = "tabPageGeneral";
            this.tabPageGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGeneral.Size = new System.Drawing.Size(1231, 628);
            this.tabPageGeneral.TabIndex = 0;
            this.tabPageGeneral.Text = "General";
            this.tabPageGeneral.UseVisualStyleBackColor = true;
            // 
            // listView10Year
            // 
            this.listView10Year.Location = new System.Drawing.Point(930, 294);
            this.listView10Year.Name = "listView10Year";
            this.listView10Year.Size = new System.Drawing.Size(225, 253);
            this.listView10Year.TabIndex = 10;
            this.listView10Year.UseCompatibleStateImageBehavior = false;
            // 
            // listView5Year
            // 
            this.listView5Year.Location = new System.Drawing.Point(699, 294);
            this.listView5Year.Name = "listView5Year";
            this.listView5Year.Size = new System.Drawing.Size(225, 253);
            this.listView5Year.TabIndex = 9;
            this.listView5Year.UseCompatibleStateImageBehavior = false;
            // 
            // listView3Year
            // 
            this.listView3Year.Location = new System.Drawing.Point(468, 294);
            this.listView3Year.Name = "listView3Year";
            this.listView3Year.Size = new System.Drawing.Size(225, 253);
            this.listView3Year.TabIndex = 8;
            this.listView3Year.UseCompatibleStateImageBehavior = false;
            // 
            // listView1Year
            // 
            this.listView1Year.Location = new System.Drawing.Point(237, 294);
            this.listView1Year.Name = "listView1Year";
            this.listView1Year.Size = new System.Drawing.Size(225, 253);
            this.listView1Year.TabIndex = 7;
            this.listView1Year.UseCompatibleStateImageBehavior = false;
            // 
            // listViewYearToDate
            // 
            this.listViewYearToDate.Location = new System.Drawing.Point(6, 294);
            this.listViewYearToDate.Name = "listViewYearToDate";
            this.listViewYearToDate.Size = new System.Drawing.Size(225, 253);
            this.listViewYearToDate.TabIndex = 6;
            this.listViewYearToDate.UseCompatibleStateImageBehavior = false;
            // 
            // listView3Month
            // 
            this.listView3Month.Location = new System.Drawing.Point(930, 35);
            this.listView3Month.Name = "listView3Month";
            this.listView3Month.Size = new System.Drawing.Size(225, 253);
            this.listView3Month.TabIndex = 5;
            this.listView3Month.UseCompatibleStateImageBehavior = false;
            // 
            // listView1Month
            // 
            this.listView1Month.Location = new System.Drawing.Point(699, 35);
            this.listView1Month.Name = "listView1Month";
            this.listView1Month.Size = new System.Drawing.Size(225, 253);
            this.listView1Month.TabIndex = 4;
            this.listView1Month.UseCompatibleStateImageBehavior = false;
            // 
            // listView5Day
            // 
            this.listView5Day.Location = new System.Drawing.Point(468, 35);
            this.listView5Day.Name = "listView5Day";
            this.listView5Day.Size = new System.Drawing.Size(225, 253);
            this.listView5Day.TabIndex = 3;
            this.listView5Day.UseCompatibleStateImageBehavior = false;
            // 
            // listView1Day
            // 
            this.listView1Day.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1Day.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1DayName,
            this.columnHeader1DayValue});
            this.listView1Day.FullRowSelect = true;
            this.listView1Day.GridLines = true;
            this.listView1Day.HoverSelection = true;
            this.listView1Day.Location = new System.Drawing.Point(237, 35);
            this.listView1Day.Name = "listView1Day";
            this.listView1Day.Size = new System.Drawing.Size(225, 253);
            this.listView1Day.TabIndex = 2;
            this.listView1Day.UseCompatibleStateImageBehavior = false;
            this.listView1Day.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1DayName
            // 
            this.columnHeader1DayName.Text = "Name";
            this.columnHeader1DayName.Width = 100;
            // 
            // columnHeader1DayValue
            // 
            this.columnHeader1DayValue.Text = "Value";
            this.columnHeader1DayValue.Width = 120;
            // 
            // buttonSector
            // 
            this.buttonSector.Location = new System.Drawing.Point(6, 6);
            this.buttonSector.Name = "buttonSector";
            this.buttonSector.Size = new System.Drawing.Size(390, 23);
            this.buttonSector.TabIndex = 1;
            this.buttonSector.Text = "Show Sector Information";
            this.buttonSector.UseVisualStyleBackColor = true;
            this.buttonSector.Click += new System.EventHandler(this.buttonSector_Click);
            // 
            // listViewRealTime
            // 
            this.listViewRealTime.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderRealTimeName,
            this.columnHeaderRealTimeValue});
            this.listViewRealTime.FullRowSelect = true;
            this.listViewRealTime.GridLines = true;
            this.listViewRealTime.LabelWrap = false;
            this.listViewRealTime.Location = new System.Drawing.Point(6, 35);
            this.listViewRealTime.Name = "listViewRealTime";
            this.listViewRealTime.Size = new System.Drawing.Size(225, 253);
            this.listViewRealTime.TabIndex = 0;
            this.listViewRealTime.TileSize = new System.Drawing.Size(225, 30);
            this.listViewRealTime.UseCompatibleStateImageBehavior = false;
            this.listViewRealTime.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderRealTimeName
            // 
            this.columnHeaderRealTimeName.Text = "Name";
            this.columnHeaderRealTimeName.Width = 100;
            // 
            // columnHeaderRealTimeValue
            // 
            this.columnHeaderRealTimeValue.Text = "Value";
            this.columnHeaderRealTimeValue.Width = 120;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.loadGraph);
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1231, 628);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // loadGraph
            // 
            this.loadGraph.Location = new System.Drawing.Point(838, 122);
            this.loadGraph.Name = "loadGraph";
            this.loadGraph.Size = new System.Drawing.Size(255, 40);
            this.loadGraph.TabIndex = 1;
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
            this.chart1.Location = new System.Drawing.Point(42, 25);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Apple";
            series1.Name = "Apple";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(737, 524);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title1.BackColor = System.Drawing.Color.Transparent;
            title1.BorderWidth = 10;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            title1.Name = "Stock Price";
            title1.Text = "Stock Price";
            this.chart1.Titles.Add(title1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 699);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxApiName);
            this.Controls.Add(this.labelApiName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageGeneral.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelApiName;
        private System.Windows.Forms.TextBox textBoxApiName;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageGeneral;
        private System.Windows.Forms.ListView listViewRealTime;
        private System.Windows.Forms.ListView listView10Year;
        private System.Windows.Forms.ListView listView5Year;
        private System.Windows.Forms.ListView listView3Year;
        private System.Windows.Forms.ListView listView1Year;
        private System.Windows.Forms.ListView listViewYearToDate;
        private System.Windows.Forms.ListView listView3Month;
        private System.Windows.Forms.ListView listView1Month;
        private System.Windows.Forms.ListView listView5Day;
        private System.Windows.Forms.ListView listView1Day;
        private System.Windows.Forms.Button buttonSector;
        private System.Windows.Forms.ColumnHeader columnHeaderRealTimeName;
        private System.Windows.Forms.ColumnHeader columnHeaderRealTimeValue;
        private System.Windows.Forms.ColumnHeader columnHeader1DayName;
        private System.Windows.Forms.ColumnHeader columnHeader1DayValue;
        public System.Windows.Forms.Button loadGraph;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        public System.Windows.Forms.TabPage tabPage2;
    }
}

