namespace WindowsFormsApp1.UserControls
{
    partial class GeneralTabControl
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
            this.buttonGetSector = new System.Windows.Forms.Button();
            this.listViewRealTime = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10Year = new System.Windows.Forms.Label();
            this.listView10Year = new System.Windows.Forms.ListView();
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5Year = new System.Windows.Forms.Label();
            this.listView5Year = new System.Windows.Forms.ListView();
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3Year = new System.Windows.Forms.Label();
            this.listView3Year = new System.Windows.Forms.ListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1Year = new System.Windows.Forms.Label();
            this.listView1Year = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelYeartoDate = new System.Windows.Forms.Label();
            this.listViewYearToDate = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3Month = new System.Windows.Forms.Label();
            this.listView3Month = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1Month = new System.Windows.Forms.Label();
            this.listView1Month = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5Day = new System.Windows.Forms.Label();
            this.listView5Day = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelRealTime = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonAddToList = new System.Windows.Forms.Button();
            this.textBoxSymbol = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGetSector
            // 
            this.buttonGetSector.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetSector.Location = new System.Drawing.Point(3, 3);
            this.buttonGetSector.Name = "buttonGetSector";
            this.buttonGetSector.Size = new System.Drawing.Size(432, 32);
            this.buttonGetSector.TabIndex = 0;
            this.buttonGetSector.Text = "Show Sector Information";
            this.buttonGetSector.UseVisualStyleBackColor = true;
            this.buttonGetSector.Click += new System.EventHandler(this.buttonGetSector_Click);
            // 
            // listViewRealTime
            // 
            this.listViewRealTime.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderValue});
            this.listViewRealTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewRealTime.Location = new System.Drawing.Point(3, 63);
            this.listViewRealTime.Name = "listViewRealTime";
            this.listViewRealTime.Size = new System.Drawing.Size(204, 222);
            this.listViewRealTime.TabIndex = 1;
            this.listViewRealTime.UseCompatibleStateImageBehavior = false;
            this.listViewRealTime.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 140;
            // 
            // columnHeaderValue
            // 
            this.columnHeaderValue.Text = "Value";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 300);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1350, 370);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sectors";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.label10Year);
            this.panel1.Controls.Add(this.listView10Year);
            this.panel1.Controls.Add(this.label5Year);
            this.panel1.Controls.Add(this.listView5Year);
            this.panel1.Controls.Add(this.label3Year);
            this.panel1.Controls.Add(this.listView3Year);
            this.panel1.Controls.Add(this.label1Year);
            this.panel1.Controls.Add(this.listView1Year);
            this.panel1.Controls.Add(this.labelYeartoDate);
            this.panel1.Controls.Add(this.listViewYearToDate);
            this.panel1.Controls.Add(this.label3Month);
            this.panel1.Controls.Add(this.listView3Month);
            this.panel1.Controls.Add(this.label1Month);
            this.panel1.Controls.Add(this.listView1Month);
            this.panel1.Controls.Add(this.label5Day);
            this.panel1.Controls.Add(this.listView5Day);
            this.panel1.Controls.Add(this.labelRealTime);
            this.panel1.Controls.Add(this.buttonGetSector);
            this.panel1.Controls.Add(this.listViewRealTime);
            this.panel1.Location = new System.Drawing.Point(6, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1338, 312);
            this.panel1.TabIndex = 2;
            // 
            // label10Year
            // 
            this.label10Year.AutoSize = true;
            this.label10Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10Year.Location = new System.Drawing.Point(1753, 38);
            this.label10Year.Name = "label10Year";
            this.label10Year.Size = new System.Drawing.Size(73, 22);
            this.label10Year.TabIndex = 18;
            this.label10Year.Text = "10 Year";
            // 
            // listView10Year
            // 
            this.listView10Year.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader15,
            this.columnHeader16});
            this.listView10Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView10Year.Location = new System.Drawing.Point(1683, 63);
            this.listView10Year.Name = "listView10Year";
            this.listView10Year.Size = new System.Drawing.Size(204, 222);
            this.listView10Year.TabIndex = 17;
            this.listView10Year.UseCompatibleStateImageBehavior = false;
            this.listView10Year.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Name";
            this.columnHeader15.Width = 140;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Value";
            // 
            // label5Year
            // 
            this.label5Year.AutoSize = true;
            this.label5Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5Year.Location = new System.Drawing.Point(1543, 38);
            this.label5Year.Name = "label5Year";
            this.label5Year.Size = new System.Drawing.Size(63, 22);
            this.label5Year.TabIndex = 16;
            this.label5Year.Text = "5 Year";
            // 
            // listView5Year
            // 
            this.listView5Year.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13,
            this.columnHeader14});
            this.listView5Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView5Year.Location = new System.Drawing.Point(1473, 63);
            this.listView5Year.Name = "listView5Year";
            this.listView5Year.Size = new System.Drawing.Size(204, 222);
            this.listView5Year.TabIndex = 15;
            this.listView5Year.UseCompatibleStateImageBehavior = false;
            this.listView5Year.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Name";
            this.columnHeader13.Width = 140;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Value";
            // 
            // label3Year
            // 
            this.label3Year.AutoSize = true;
            this.label3Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3Year.Location = new System.Drawing.Point(1327, 38);
            this.label3Year.Name = "label3Year";
            this.label3Year.Size = new System.Drawing.Size(63, 22);
            this.label3Year.TabIndex = 14;
            this.label3Year.Text = "3 Year";
            // 
            // listView3Year
            // 
            this.listView3Year.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader12});
            this.listView3Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView3Year.Location = new System.Drawing.Point(1263, 63);
            this.listView3Year.Name = "listView3Year";
            this.listView3Year.Size = new System.Drawing.Size(204, 222);
            this.listView3Year.TabIndex = 13;
            this.listView3Year.UseCompatibleStateImageBehavior = false;
            this.listView3Year.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Name";
            this.columnHeader11.Width = 140;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Value";
            // 
            // label1Year
            // 
            this.label1Year.AutoSize = true;
            this.label1Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Year.Location = new System.Drawing.Point(1123, 38);
            this.label1Year.Name = "label1Year";
            this.label1Year.Size = new System.Drawing.Size(63, 22);
            this.label1Year.TabIndex = 12;
            this.label1Year.Text = "1 Year";
            // 
            // listView1Year
            // 
            this.listView1Year.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10});
            this.listView1Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1Year.Location = new System.Drawing.Point(1053, 63);
            this.listView1Year.Name = "listView1Year";
            this.listView1Year.Size = new System.Drawing.Size(204, 222);
            this.listView1Year.TabIndex = 11;
            this.listView1Year.UseCompatibleStateImageBehavior = false;
            this.listView1Year.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Name";
            this.columnHeader9.Width = 140;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Value";
            // 
            // labelYeartoDate
            // 
            this.labelYeartoDate.AutoSize = true;
            this.labelYeartoDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYeartoDate.Location = new System.Drawing.Point(893, 38);
            this.labelYeartoDate.Name = "labelYeartoDate";
            this.labelYeartoDate.Size = new System.Drawing.Size(118, 22);
            this.labelYeartoDate.TabIndex = 10;
            this.labelYeartoDate.Text = "Year-to-Date ";
            // 
            // listViewYearToDate
            // 
            this.listViewYearToDate.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8});
            this.listViewYearToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewYearToDate.Location = new System.Drawing.Point(843, 63);
            this.listViewYearToDate.Name = "listViewYearToDate";
            this.listViewYearToDate.Size = new System.Drawing.Size(204, 222);
            this.listViewYearToDate.TabIndex = 9;
            this.listViewYearToDate.UseCompatibleStateImageBehavior = false;
            this.listViewYearToDate.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Name";
            this.columnHeader7.Width = 140;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Value";
            // 
            // label3Month
            // 
            this.label3Month.AutoSize = true;
            this.label3Month.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3Month.Location = new System.Drawing.Point(694, 38);
            this.label3Month.Name = "label3Month";
            this.label3Month.Size = new System.Drawing.Size(74, 22);
            this.label3Month.TabIndex = 8;
            this.label3Month.Text = "3 Month";
            // 
            // listView3Month
            // 
            this.listView3Month.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.listView3Month.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView3Month.Location = new System.Drawing.Point(633, 63);
            this.listView3Month.Name = "listView3Month";
            this.listView3Month.Size = new System.Drawing.Size(204, 222);
            this.listView3Month.TabIndex = 7;
            this.listView3Month.UseCompatibleStateImageBehavior = false;
            this.listView3Month.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Name";
            this.columnHeader5.Width = 140;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Value";
            // 
            // label1Month
            // 
            this.label1Month.AutoSize = true;
            this.label1Month.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Month.Location = new System.Drawing.Point(484, 38);
            this.label1Month.Name = "label1Month";
            this.label1Month.Size = new System.Drawing.Size(74, 22);
            this.label1Month.TabIndex = 6;
            this.label1Month.Text = "1 Month";
            // 
            // listView1Month
            // 
            this.listView1Month.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.listView1Month.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1Month.Location = new System.Drawing.Point(423, 63);
            this.listView1Month.Name = "listView1Month";
            this.listView1Month.Size = new System.Drawing.Size(204, 222);
            this.listView1Month.TabIndex = 5;
            this.listView1Month.UseCompatibleStateImageBehavior = false;
            this.listView1Month.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name";
            this.columnHeader3.Width = 140;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Value";
            // 
            // label5Day
            // 
            this.label5Day.AutoSize = true;
            this.label5Day.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5Day.Location = new System.Drawing.Point(285, 38);
            this.label5Day.Name = "label5Day";
            this.label5Day.Size = new System.Drawing.Size(57, 22);
            this.label5Day.TabIndex = 4;
            this.label5Day.Text = "5 Day";
            // 
            // listView5Day
            // 
            this.listView5Day.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView5Day.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView5Day.Location = new System.Drawing.Point(213, 63);
            this.listView5Day.Name = "listView5Day";
            this.listView5Day.Size = new System.Drawing.Size(204, 222);
            this.listView5Day.TabIndex = 3;
            this.listView5Day.UseCompatibleStateImageBehavior = false;
            this.listView5Day.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 140;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Value";
            // 
            // labelRealTime
            // 
            this.labelRealTime.AutoSize = true;
            this.labelRealTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRealTime.Location = new System.Drawing.Point(53, 38);
            this.labelRealTime.Name = "labelRealTime";
            this.labelRealTime.Size = new System.Drawing.Size(93, 22);
            this.labelRealTime.TabIndex = 2;
            this.labelRealTime.Text = "Real-Time";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.buttonAddToList);
            this.groupBox2.Controls.Add(this.textBoxSymbol);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1344, 291);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Watchlist";
            // 
            // buttonAddToList
            // 
            this.buttonAddToList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddToList.Location = new System.Drawing.Point(9, 65);
            this.buttonAddToList.Name = "buttonAddToList";
            this.buttonAddToList.Size = new System.Drawing.Size(204, 30);
            this.buttonAddToList.TabIndex = 2;
            this.buttonAddToList.Text = "Add";
            this.buttonAddToList.UseVisualStyleBackColor = true;
            // 
            // textBoxSymbol
            // 
            this.textBoxSymbol.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxSymbol.Location = new System.Drawing.Point(9, 29);
            this.textBoxSymbol.Name = "textBoxSymbol";
            this.textBoxSymbol.Size = new System.Drawing.Size(204, 30);
            this.textBoxSymbol.TabIndex = 1;
            this.textBoxSymbol.Text = "Enter Symbol";
            this.textBoxSymbol.TextChanged += new System.EventHandler(this.textBoxSymbol_TextChanged);
            this.textBoxSymbol.Enter += new System.EventHandler(this.textBoxSymbol_Enter);
            this.textBoxSymbol.Leave += new System.EventHandler(this.textBoxSymbol_Leave);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(219, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1125, 256);
            this.panel2.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(44, 140);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 33);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // GeneralTabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GeneralTabControl";
            this.Size = new System.Drawing.Size(1350, 654);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGetSector;
        private System.Windows.Forms.ListView listViewRealTime;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderValue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelRealTime;
        private System.Windows.Forms.Label label1Year;
        private System.Windows.Forms.ListView listView1Year;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Label labelYeartoDate;
        private System.Windows.Forms.ListView listViewYearToDate;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label label3Month;
        private System.Windows.Forms.ListView listView3Month;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label1Month;
        private System.Windows.Forms.ListView listView1Month;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label5Day;
        private System.Windows.Forms.ListView listView5Day;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label10Year;
        private System.Windows.Forms.ListView listView10Year;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.Label label5Year;
        private System.Windows.Forms.ListView listView5Year;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.Label label3Year;
        private System.Windows.Forms.ListView listView3Year;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonAddToList;
        private System.Windows.Forms.TextBox textBoxSymbol;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
