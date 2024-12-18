namespace StanleyCEbaySales
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProfit = new System.Windows.Forms.TextBox();
            this.txtShippingCost = new System.Windows.Forms.TextBox();
            this.lstOut = new System.Windows.Forms.ListBox();
            this.btnCalculateCost = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.txtProductCost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoBooks = new System.Windows.Forms.RadioButton();
            this.rdoClothing = new System.Windows.Forms.RadioButton();
            this.rdoElectronics = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnDisplayLog = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(345, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ebay Sales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(146, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Name";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(275, 109);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(344, 20);
            this.txtCustomerName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Shipping Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Product Cost";
            // 
            // txtProfit
            // 
            this.txtProfit.Location = new System.Drawing.Point(275, 187);
            this.txtProfit.Name = "txtProfit";
            this.txtProfit.Size = new System.Drawing.Size(344, 20);
            this.txtProfit.TabIndex = 6;
            // 
            // txtShippingCost
            // 
            this.txtShippingCost.Location = new System.Drawing.Point(275, 225);
            this.txtShippingCost.Name = "txtShippingCost";
            this.txtShippingCost.Size = new System.Drawing.Size(344, 20);
            this.txtShippingCost.TabIndex = 8;
            // 
            // lstOut
            // 
            this.lstOut.FormattingEnabled = true;
            this.lstOut.Location = new System.Drawing.Point(149, 259);
            this.lstOut.Name = "lstOut";
            this.lstOut.Size = new System.Drawing.Size(470, 108);
            this.lstOut.TabIndex = 9;
            // 
            // btnCalculateCost
            // 
            this.btnCalculateCost.Location = new System.Drawing.Point(62, 382);
            this.btnCalculateCost.Name = "btnCalculateCost";
            this.btnCalculateCost.Size = new System.Drawing.Size(79, 65);
            this.btnCalculateCost.TabIndex = 10;
            this.btnCalculateCost.Text = "&Calculate Customer Cost";
            this.btnCalculateCost.UseVisualStyleBackColor = true;
            this.btnCalculateCost.Click += new System.EventHandler(this.btnCalculateCost_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(275, 382);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 65);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clea&r";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(478, 382);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(76, 65);
            this.btnQuit.TabIndex = 12;
            this.btnQuit.Text = "&Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // txtProductCost
            // 
            this.txtProductCost.Location = new System.Drawing.Point(275, 147);
            this.txtProductCost.Name = "txtProductCost";
            this.txtProductCost.Size = new System.Drawing.Size(344, 20);
            this.txtProductCost.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Profit";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoBooks);
            this.groupBox1.Controls.Add(this.rdoClothing);
            this.groupBox1.Controls.Add(this.rdoElectronics);
            this.groupBox1.Location = new System.Drawing.Point(149, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 49);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Category";
            // 
            // rdoBooks
            // 
            this.rdoBooks.AutoSize = true;
            this.rdoBooks.Location = new System.Drawing.Point(394, 20);
            this.rdoBooks.Name = "rdoBooks";
            this.rdoBooks.Size = new System.Drawing.Size(55, 17);
            this.rdoBooks.TabIndex = 2;
            this.rdoBooks.TabStop = true;
            this.rdoBooks.Text = "Books";
            this.rdoBooks.UseVisualStyleBackColor = true;
            this.rdoBooks.CheckedChanged += new System.EventHandler(this.rdoBooks_CheckedChanged);
            // 
            // rdoClothing
            // 
            this.rdoClothing.AutoSize = true;
            this.rdoClothing.Location = new System.Drawing.Point(201, 20);
            this.rdoClothing.Name = "rdoClothing";
            this.rdoClothing.Size = new System.Drawing.Size(63, 17);
            this.rdoClothing.TabIndex = 1;
            this.rdoClothing.TabStop = true;
            this.rdoClothing.Text = "Clothing";
            this.rdoClothing.UseVisualStyleBackColor = true;
            this.rdoClothing.CheckedChanged += new System.EventHandler(this.rdoClothing_CheckedChanged);
            // 
            // rdoElectronics
            // 
            this.rdoElectronics.AutoSize = true;
            this.rdoElectronics.Location = new System.Drawing.Point(2, 20);
            this.rdoElectronics.Name = "rdoElectronics";
            this.rdoElectronics.Size = new System.Drawing.Size(77, 17);
            this.rdoElectronics.TabIndex = 0;
            this.rdoElectronics.TabStop = true;
            this.rdoElectronics.Text = "Electronics";
            this.rdoElectronics.UseVisualStyleBackColor = true;
            this.rdoElectronics.CheckedChanged += new System.EventHandler(this.rdoElectronics_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "&Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnDisplayLog
            // 
            this.btnDisplayLog.Location = new System.Drawing.Point(654, 382);
            this.btnDisplayLog.Name = "btnDisplayLog";
            this.btnDisplayLog.Size = new System.Drawing.Size(74, 65);
            this.btnDisplayLog.TabIndex = 15;
            this.btnDisplayLog.Text = "&Display Log";
            this.btnDisplayLog.UseVisualStyleBackColor = true;
            this.btnDisplayLog.Click += new System.EventHandler(this.btnDisplayLog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDisplayLog);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProductCost);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculateCost);
            this.Controls.Add(this.lstOut);
            this.Controls.Add(this.txtShippingCost);
            this.Controls.Add(this.txtProfit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Stanley";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProfit;
        private System.Windows.Forms.TextBox txtShippingCost;
        private System.Windows.Forms.ListBox lstOut;
        private System.Windows.Forms.Button btnCalculateCost;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.TextBox txtProductCost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoBooks;
        private System.Windows.Forms.RadioButton rdoClothing;
        private System.Windows.Forms.RadioButton rdoElectronics;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnDisplayLog;
    }
}

