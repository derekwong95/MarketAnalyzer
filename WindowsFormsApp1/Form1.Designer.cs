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
            this.tabControlMain = new System.Windows.Forms.TabControl();
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
            // tabControlMain
            // 
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControlMain.Location = new System.Drawing.Point(0, 30);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1350, 654);
            this.tabControlMain.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1350, 684);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxApiName);
            this.Controls.Add(this.labelApiName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Market Analyzer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelApiName;
        private System.Windows.Forms.TextBox textBoxApiName;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.TabControl tabControlMain;
    }
}

