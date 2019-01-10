﻿namespace MarketAnalyzer
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.labelApiName = new System.Windows.Forms.Label();
            this.textBoxApiName = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.loadGraph = new System.Windows.Forms.Button();
            this.tabPageGeneral = new System.Windows.Forms.TabPage();
            this.buttonSector = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewRealTime = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPageGeneral.SuspendLayout();
            this.tabControl1.SuspendLayout();
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.loadGraph);
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1342, 628);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.DockedToChartArea = "ChartArea1";
            legend3.Name = "Apple";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(27, 25);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Apple";
            series3.Name = "Apple";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(737, 524);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title3.BackColor = System.Drawing.Color.Transparent;
            title3.BorderWidth = 10;
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            title3.Name = "Stock Price";
            title3.Text = "Stock Price";
            this.chart1.Titles.Add(title3);
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
            // tabPageGeneral
            // 
            this.tabPageGeneral.AutoScroll = true;
            this.tabPageGeneral.Controls.Add(this.listViewRealTime);
            this.tabPageGeneral.Controls.Add(this.label1);
            this.tabPageGeneral.Controls.Add(this.buttonSector);
            this.tabPageGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabPageGeneral.Name = "tabPageGeneral";
            this.tabPageGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGeneral.Size = new System.Drawing.Size(1342, 628);
            this.tabPageGeneral.TabIndex = 0;
            this.tabPageGeneral.Text = "General";
            this.tabPageGeneral.UseVisualStyleBackColor = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(134, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Real-Time Performance";
            // 
            // listViewRealTime
            // 
            this.listViewRealTime.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderValue});
            this.listViewRealTime.FullRowSelect = true;
            this.listViewRealTime.GridLines = true;
            this.listViewRealTime.Location = new System.Drawing.Point(6, 73);
            this.listViewRealTime.Name = "listViewRealTime";
            this.listViewRealTime.Size = new System.Drawing.Size(390, 547);
            this.listViewRealTime.TabIndex = 12;
            this.listViewRealTime.UseCompatibleStateImageBehavior = false;
            this.listViewRealTime.View = System.Windows.Forms.View.Details;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageGeneral);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1350, 654);
            this.tabControl1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1350, 684);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxApiName);
            this.Controls.Add(this.labelApiName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Market Analyzer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPageGeneral.ResumeLayout(false);
            this.tabPageGeneral.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelApiName;
        private System.Windows.Forms.TextBox textBoxApiName;
        private System.Windows.Forms.Button buttonSubmit;
        public System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.Button loadGraph;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TabPage tabPageGeneral;
        private System.Windows.Forms.ListView listViewRealTime;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSector;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

