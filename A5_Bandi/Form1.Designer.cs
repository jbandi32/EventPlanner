namespace A5_Bandi
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
            this.lbReceptionItems = new System.Windows.Forms.ListBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblCPI = new System.Windows.Forms.Label();
            this.lblNumOrdered = new System.Windows.Forms.Label();
            this.lblItemCost = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCPINum = new System.Windows.Forms.Label();
            this.lblNumOrderedNum = new System.Windows.Forms.Label();
            this.lblItemCostNum = new System.Windows.Forms.Label();
            this.lblTotalNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbReceptionItems
            // 
            this.lbReceptionItems.FormattingEnabled = true;
            this.lbReceptionItems.ItemHeight = 24;
            this.lbReceptionItems.Location = new System.Drawing.Point(25, 26);
            this.lbReceptionItems.Name = "lbReceptionItems";
            this.lbReceptionItems.Size = new System.Drawing.Size(271, 196);
            this.lbReceptionItems.TabIndex = 0;
            this.lbReceptionItems.SelectedIndexChanged += new System.EventHandler(this.lbReceptionItems_SelectedIndexChanged);
            this.lbReceptionItems.DoubleClick += new System.EventHandler(this.lbReceptionItems_DoubleClick);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(480, 42);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(112, 43);
            this.btnOpenFile.TabIndex = 1;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(480, 126);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(112, 43);
            this.btnRemoveItem.TabIndex = 2;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(480, 204);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 43);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblCPI
            // 
            this.lblCPI.AutoSize = true;
            this.lblCPI.Location = new System.Drawing.Point(54, 248);
            this.lblCPI.Name = "lblCPI";
            this.lblCPI.Size = new System.Drawing.Size(130, 25);
            this.lblCPI.TabIndex = 4;
            this.lblCPI.Text = "Cost Per Item";
            // 
            // lblNumOrdered
            // 
            this.lblNumOrdered.AutoSize = true;
            this.lblNumOrdered.Location = new System.Drawing.Point(54, 298);
            this.lblNumOrdered.Name = "lblNumOrdered";
            this.lblNumOrdered.Size = new System.Drawing.Size(180, 25);
            this.lblNumOrdered.TabIndex = 5;
            this.lblNumOrdered.Text = "Numbered Ordered";
            // 
            // lblItemCost
            // 
            this.lblItemCost.AutoSize = true;
            this.lblItemCost.Location = new System.Drawing.Point(54, 344);
            this.lblItemCost.Name = "lblItemCost";
            this.lblItemCost.Size = new System.Drawing.Size(95, 25);
            this.lblItemCost.TabIndex = 6;
            this.lblItemCost.Text = "Item Cost";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(54, 416);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(61, 25);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Total";
            // 
            // lblCPINum
            // 
            this.lblCPINum.AutoSize = true;
            this.lblCPINum.Location = new System.Drawing.Point(250, 248);
            this.lblCPINum.Name = "lblCPINum";
            this.lblCPINum.Size = new System.Drawing.Size(0, 25);
            this.lblCPINum.TabIndex = 8;
            this.lblCPINum.Click += new System.EventHandler(this.lblCPINum_Click);
            // 
            // lblNumOrderedNum
            // 
            this.lblNumOrderedNum.AutoSize = true;
            this.lblNumOrderedNum.Location = new System.Drawing.Point(250, 298);
            this.lblNumOrderedNum.Name = "lblNumOrderedNum";
            this.lblNumOrderedNum.Size = new System.Drawing.Size(0, 25);
            this.lblNumOrderedNum.TabIndex = 9;
            // 
            // lblItemCostNum
            // 
            this.lblItemCostNum.AutoSize = true;
            this.lblItemCostNum.Location = new System.Drawing.Point(250, 344);
            this.lblItemCostNum.Name = "lblItemCostNum";
            this.lblItemCostNum.Size = new System.Drawing.Size(0, 25);
            this.lblItemCostNum.TabIndex = 10;
            // 
            // lblTotalNum
            // 
            this.lblTotalNum.AutoSize = true;
            this.lblTotalNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalNum.Location = new System.Drawing.Point(250, 416);
            this.lblTotalNum.Name = "lblTotalNum";
            this.lblTotalNum.Size = new System.Drawing.Size(0, 25);
            this.lblTotalNum.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotalNum);
            this.Controls.Add(this.lblItemCostNum);
            this.Controls.Add(this.lblNumOrderedNum);
            this.Controls.Add(this.lblCPINum);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblItemCost);
            this.Controls.Add(this.lblNumOrdered);
            this.Controls.Add(this.lblCPI);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.lbReceptionItems);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbReceptionItems;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCPI;
        private System.Windows.Forms.Label lblNumOrdered;
        private System.Windows.Forms.Label lblItemCost;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCPINum;
        private System.Windows.Forms.Label lblNumOrderedNum;
        private System.Windows.Forms.Label lblItemCostNum;
        private System.Windows.Forms.Label lblTotalNum;
    }
}

