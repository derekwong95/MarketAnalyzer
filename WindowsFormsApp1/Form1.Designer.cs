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
            this.labelApiName = new System.Windows.Forms.Label();
            this.textBoxApiName = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageGeneral = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listViewRealTime = new System.Windows.Forms.ListView();
            this.buttonSector = new System.Windows.Forms.Button();
            this.listView1Day = new System.Windows.Forms.ListView();
            this.listView1Month = new System.Windows.Forms.ListView();
            this.listView3Month = new System.Windows.Forms.ListView();
            this.listView3Year = new System.Windows.Forms.ListView();
            this.listView5Year = new System.Windows.Forms.ListView();
            this.listView10Year = new System.Windows.Forms.ListView();
            this.columnHeaderRealTimeName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderRealTimeValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1DayName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1DayValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.tabControl1.SuspendLayout();
            this.tabPageGeneral.SuspendLayout();
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
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1350, 654);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPageGeneral
            // 
            this.tabPageGeneral.AutoScroll = true;
            this.tabPageGeneral.Controls.Add(this.listView2);
            this.tabPageGeneral.Controls.Add(this.listView1);
            this.tabPageGeneral.Controls.Add(this.label6);
            this.tabPageGeneral.Controls.Add(this.label5);
            this.tabPageGeneral.Controls.Add(this.label2);
            this.tabPageGeneral.Controls.Add(this.label1);
            this.tabPageGeneral.Controls.Add(this.listView10Year);
            this.tabPageGeneral.Controls.Add(this.listView5Year);
            this.tabPageGeneral.Controls.Add(this.listView3Year);
            this.tabPageGeneral.Controls.Add(this.listView3Month);
            this.tabPageGeneral.Controls.Add(this.listView1Month);
            this.tabPageGeneral.Controls.Add(this.listView1Day);
            this.tabPageGeneral.Controls.Add(this.buttonSector);
            this.tabPageGeneral.Controls.Add(this.listViewRealTime);
            this.tabPageGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabPageGeneral.Name = "tabPageGeneral";
            this.tabPageGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGeneral.Size = new System.Drawing.Size(1342, 628);
            this.tabPageGeneral.TabIndex = 0;
            this.tabPageGeneral.Text = "General";
            this.tabPageGeneral.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1342, 628);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listViewRealTime
            // 
            this.listViewRealTime.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderRealTimeName,
            this.columnHeaderRealTimeValue});
            this.listViewRealTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewRealTime.LabelWrap = false;
            this.listViewRealTime.Location = new System.Drawing.Point(6, 72);
            this.listViewRealTime.Name = "listViewRealTime";
            this.listViewRealTime.Size = new System.Drawing.Size(456, 538);
            this.listViewRealTime.TabIndex = 0;
            this.listViewRealTime.TileSize = new System.Drawing.Size(225, 30);
            this.listViewRealTime.UseCompatibleStateImageBehavior = false;
            this.listViewRealTime.View = System.Windows.Forms.View.Details;
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
            // listView1Day
            // 
            this.listView1Day.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1Day.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1DayName,
            this.columnHeader1DayValue});
            this.listView1Day.FullRowSelect = true;
            this.listView1Day.GridLines = true;
            this.listView1Day.HoverSelection = true;
            this.listView1Day.Location = new System.Drawing.Point(468, 72);
            this.listView1Day.Name = "listView1Day";
            this.listView1Day.Size = new System.Drawing.Size(225, 253);
            this.listView1Day.TabIndex = 2;
            this.listView1Day.UseCompatibleStateImageBehavior = false;
            this.listView1Day.View = System.Windows.Forms.View.Details;
            // 
            // listView1Month
            // 
            this.listView1Month.Location = new System.Drawing.Point(699, 72);
            this.listView1Month.Name = "listView1Month";
            this.listView1Month.Size = new System.Drawing.Size(225, 253);
            this.listView1Month.TabIndex = 4;
            this.listView1Month.UseCompatibleStateImageBehavior = false;
            // 
            // listView3Month
            // 
            this.listView3Month.Location = new System.Drawing.Point(930, 72);
            this.listView3Month.Name = "listView3Month";
            this.listView3Month.Size = new System.Drawing.Size(225, 253);
            this.listView3Month.TabIndex = 5;
            this.listView3Month.UseCompatibleStateImageBehavior = false;
            // 
            // listView3Year
            // 
            this.listView3Year.Location = new System.Drawing.Point(468, 357);
            this.listView3Year.Name = "listView3Year";
            this.listView3Year.Size = new System.Drawing.Size(225, 253);
            this.listView3Year.TabIndex = 8;
            this.listView3Year.UseCompatibleStateImageBehavior = false;
            // 
            // listView5Year
            // 
            this.listView5Year.Location = new System.Drawing.Point(699, 357);
            this.listView5Year.Name = "listView5Year";
            this.listView5Year.Size = new System.Drawing.Size(225, 253);
            this.listView5Year.TabIndex = 9;
            this.listView5Year.UseCompatibleStateImageBehavior = false;
            // 
            // listView10Year
            // 
            this.listView10Year.Location = new System.Drawing.Point(930, 357);
            this.listView10Year.Name = "listView10Year";
            this.listView10Year.Size = new System.Drawing.Size(225, 253);
            this.listView10Year.TabIndex = 10;
            this.listView10Year.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeaderRealTimeName
            // 
            this.columnHeaderRealTimeName.Text = "Name";
            this.columnHeaderRealTimeName.Width = 177;
            // 
            // columnHeaderRealTimeValue
            // 
            this.columnHeaderRealTimeValue.Text = "Value";
            this.columnHeaderRealTimeValue.Width = 179;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(168, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Real-Time Performance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(525, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "1 Day Perfomance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(991, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "3 Month Perfomance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(751, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "1 Month Perfomance";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(1161, 72);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(225, 253);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(1161, 357);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(225, 253);
            this.listView2.TabIndex = 18;
            this.listView2.UseCompatibleStateImageBehavior = false;
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
            this.Name = "Form1";
            this.Text = "Market Analyzer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageGeneral.ResumeLayout(false);
            this.tabPageGeneral.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelApiName;
        private System.Windows.Forms.TextBox textBoxApiName;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageGeneral;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView listViewRealTime;
        private System.Windows.Forms.ListView listView10Year;
        private System.Windows.Forms.ListView listView5Year;
        private System.Windows.Forms.ListView listView3Year;
        private System.Windows.Forms.ListView listView3Month;
        private System.Windows.Forms.ListView listView1Month;
        private System.Windows.Forms.ListView listView1Day;
        private System.Windows.Forms.Button buttonSector;
        private System.Windows.Forms.ColumnHeader columnHeaderRealTimeName;
        private System.Windows.Forms.ColumnHeader columnHeaderRealTimeValue;
        private System.Windows.Forms.ColumnHeader columnHeader1DayName;
        private System.Windows.Forms.ColumnHeader columnHeader1DayValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ListView listView1;
    }
}

