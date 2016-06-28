namespace POS2
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
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.inventory1 = new System.Windows.Forms.CheckedListBox();
            this.menu1 = new System.Windows.Forms.MenuStrip();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lookupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lsBoxSalesRecord = new System.Windows.Forms.ListBox();
            this.lblExtendedTotal = new System.Windows.Forms.Label();
            this.txtBoxDiscount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefund = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.companyLogo = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblTaxTotal = new System.Windows.Forms.Label();
            this.cBoxShoppingCart = new System.Windows.Forms.CheckedListBox();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.lblOrderTotal = new System.Windows.Forms.Label();
            this.btnClearList = new System.Windows.Forms.Button();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.menu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyLogo)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(582, 829);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inventory List";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 16);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 3, 334, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(576, 810);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.inventory1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(568, 784);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Unordered List";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // inventory1
            // 
            this.inventory1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.inventory1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inventory1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventory1.ForeColor = System.Drawing.Color.White;
            this.inventory1.FormattingEnabled = true;
            this.inventory1.Location = new System.Drawing.Point(3, 3);
            this.inventory1.MaximumSize = new System.Drawing.Size(10000, 10000);
            this.inventory1.Name = "inventory1";
            this.inventory1.Size = new System.Drawing.Size(562, 758);
            this.inventory1.TabIndex = 8;
            // 
            // menu1
            // 
            this.menu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menu1.Location = new System.Drawing.Point(0, 0);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(582, 24);
            this.menu1.TabIndex = 22;
            this.menu1.Text = "menuStrip1";
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lookupToolStripMenuItem,
            this.refundToolStripMenuItem,
            this.viewRecordsToolStripMenuItem});
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.orderToolStripMenuItem.Text = "Order";
            // 
            // lookupToolStripMenuItem
            // 
            this.lookupToolStripMenuItem.Name = "lookupToolStripMenuItem";
            this.lookupToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.lookupToolStripMenuItem.Text = "Lookup";
            this.lookupToolStripMenuItem.Click += new System.EventHandler(this.lookupToolStripMenuItem_Click);
            // 
            // refundToolStripMenuItem
            // 
            this.refundToolStripMenuItem.Name = "refundToolStripMenuItem";
            this.refundToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.refundToolStripMenuItem.Text = "Refund";
            this.refundToolStripMenuItem.Click += new System.EventHandler(this.refundToolStripMenuItem_Click);
            // 
            // viewRecordsToolStripMenuItem
            // 
            this.viewRecordsToolStripMenuItem.Name = "viewRecordsToolStripMenuItem";
            this.viewRecordsToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.viewRecordsToolStripMenuItem.Text = "View Records";
            this.viewRecordsToolStripMenuItem.Click += new System.EventHandler(this.viewRecordsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.lblExtendedTotal);
            this.groupBox1.Controls.Add(this.txtBoxDiscount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnRefund);
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Controls.Add(this.companyLogo);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.lblTaxTotal);
            this.groupBox1.Controls.Add(this.cBoxShoppingCart);
            this.groupBox1.Controls.Add(this.btnCheckout);
            this.groupBox1.Controls.Add(this.lblOrderTotal);
            this.groupBox1.Controls.Add(this.btnClearList);
            this.groupBox1.Controls.Add(this.lblGrandTotal);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(582, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 853);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // lsBoxSalesRecord
            // 
            this.lsBoxSalesRecord.FormattingEnabled = true;
            this.lsBoxSalesRecord.Location = new System.Drawing.Point(11, 19);
            this.lsBoxSalesRecord.Name = "lsBoxSalesRecord";
            this.lsBoxSalesRecord.Size = new System.Drawing.Size(297, 43);
            this.lsBoxSalesRecord.TabIndex = 29;
            // 
            // lblExtendedTotal
            // 
            this.lblExtendedTotal.AutoSize = true;
            this.lblExtendedTotal.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtendedTotal.ForeColor = System.Drawing.Color.Red;
            this.lblExtendedTotal.Location = new System.Drawing.Point(22, 529);
            this.lblExtendedTotal.Name = "lblExtendedTotal";
            this.lblExtendedTotal.Size = new System.Drawing.Size(70, 33);
            this.lblExtendedTotal.TabIndex = 28;
            this.lblExtendedTotal.Text = "label";
            // 
            // txtBoxDiscount
            // 
            this.txtBoxDiscount.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDiscount.Location = new System.Drawing.Point(194, 487);
            this.txtBoxDiscount.Name = "txtBoxDiscount";
            this.txtBoxDiscount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBoxDiscount.Size = new System.Drawing.Size(138, 37);
            this.txtBoxDiscount.TabIndex = 27;
            this.txtBoxDiscount.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(22, 491);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 33);
            this.label1.TabIndex = 26;
            this.label1.Text = "Discount:";
            // 
            // btnRefund
            // 
            this.btnRefund.Location = new System.Drawing.Point(254, 708);
            this.btnRefund.Name = "btnRefund";
            this.btnRefund.Size = new System.Drawing.Size(75, 49);
            this.btnRefund.TabIndex = 18;
            this.btnRefund.Text = "Refund";
            this.btnRefund.UseVisualStyleBackColor = true;
            this.btnRefund.Click += new System.EventHandler(this.btnRefund_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackgroundImage = global::POS2.Properties.Resources.remove1;
            this.btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRemove.ForeColor = System.Drawing.Color.Transparent;
            this.btnRemove.Location = new System.Drawing.Point(159, 155);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(58, 60);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click_1);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(173, 708);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 49);
            this.btnPrint.TabIndex = 17;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // companyLogo
            // 
            this.companyLogo.BackgroundImage = global::POS2.Properties.Resources.Price_Chopper1;
            this.companyLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.companyLogo.Location = new System.Drawing.Point(25, 12);
            this.companyLogo.Name = "companyLogo";
            this.companyLogo.Size = new System.Drawing.Size(286, 137);
            this.companyLogo.TabIndex = 25;
            this.companyLogo.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundImage = global::POS2.Properties.Resources.add;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.ForeColor = System.Drawing.Color.Transparent;
            this.btnAdd.Location = new System.Drawing.Point(95, 155);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(58, 60);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // lblTaxTotal
            // 
            this.lblTaxTotal.AutoSize = true;
            this.lblTaxTotal.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxTotal.ForeColor = System.Drawing.Color.Red;
            this.lblTaxTotal.Location = new System.Drawing.Point(22, 618);
            this.lblTaxTotal.Name = "lblTaxTotal";
            this.lblTaxTotal.Size = new System.Drawing.Size(70, 33);
            this.lblTaxTotal.TabIndex = 16;
            this.lblTaxTotal.Text = "label";
            // 
            // cBoxShoppingCart
            // 
            this.cBoxShoppingCart.BackColor = System.Drawing.Color.Blue;
            this.cBoxShoppingCart.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxShoppingCart.ForeColor = System.Drawing.SystemColors.Window;
            this.cBoxShoppingCart.FormattingEnabled = true;
            this.cBoxShoppingCart.Location = new System.Drawing.Point(14, 221);
            this.cBoxShoppingCart.Name = "cBoxShoppingCart";
            this.cBoxShoppingCart.Size = new System.Drawing.Size(318, 260);
            this.cBoxShoppingCart.TabIndex = 10;
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(92, 708);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(75, 49);
            this.btnCheckout.TabIndex = 13;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.AutoSize = true;
            this.lblOrderTotal.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderTotal.ForeColor = System.Drawing.Color.Red;
            this.lblOrderTotal.Location = new System.Drawing.Point(22, 572);
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Size = new System.Drawing.Size(70, 33);
            this.lblOrderTotal.TabIndex = 15;
            this.lblOrderTotal.Text = "label";
            // 
            // btnClearList
            // 
            this.btnClearList.Location = new System.Drawing.Point(11, 708);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(75, 49);
            this.btnClearList.TabIndex = 14;
            this.btnClearList.Text = "Clear List";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click_1);
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.ForeColor = System.Drawing.Color.Red;
            this.lblGrandTotal.Location = new System.Drawing.Point(22, 662);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(70, 33);
            this.lblGrandTotal.TabIndex = 6;
            this.lblGrandTotal.Text = "label";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lsBoxSalesRecord);
            this.groupBox3.Location = new System.Drawing.Point(14, 764);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(308, 77);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sales Records";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 853);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menu1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Price Chopper POS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.menu1.ResumeLayout(false);
            this.menu1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyLogo)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.MenuStrip menu1;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lookupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewRecordsToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox cBoxShoppingCart;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.PictureBox companyLogo;
        private System.Windows.Forms.Label lblOrderTotal;
        private System.Windows.Forms.Label lblTaxTotal;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckedListBox inventory1;
        private System.Windows.Forms.Button btnRefund;
        private System.Windows.Forms.TextBox txtBoxDiscount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblExtendedTotal;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ListBox lsBoxSalesRecord;
        private System.Windows.Forms.GroupBox groupBox3;

    }
}

