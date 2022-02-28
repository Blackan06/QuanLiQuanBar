
namespace MyStoreWinApp
{
    partial class FrmBarManagement
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.cboFoodAndDrink = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.nmCount = new System.Windows.Forms.NumericUpDown();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.nmDiscount = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.cboChuyenBan = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(969, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.toolStripMenuItem1,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông Tin Tài Khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông Tin Cá Nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(221, 6);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flpTable);
            this.panel1.Location = new System.Drawing.Point(0, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 304);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.nmDiscount);
            this.panel4.Controls.Add(this.btnDiscount);
            this.panel4.Controls.Add(this.btnCheckOut);
            this.panel4.Location = new System.Drawing.Point(545, 494);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(424, 63);
            this.panel4.TabIndex = 4;
            // 
            // cboCategory
            // 
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(0, 0);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(259, 28);
            this.cboCategory.TabIndex = 0;
            // 
            // cboFoodAndDrink
            // 
            this.cboFoodAndDrink.FormattingEnabled = true;
            this.cboFoodAndDrink.Location = new System.Drawing.Point(0, 29);
            this.cboFoodAndDrink.Name = "cboFoodAndDrink";
            this.cboFoodAndDrink.Size = new System.Drawing.Size(259, 28);
            this.cboFoodAndDrink.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.nmCount);
            this.panel5.Controls.Add(this.btnAdd);
            this.panel5.Controls.Add(this.cboFoodAndDrink);
            this.panel5.Controls.Add(this.cboCategory);
            this.panel5.Location = new System.Drawing.Point(545, 47);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(424, 60);
            this.panel5.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lsvBill);
            this.panel2.Location = new System.Drawing.Point(545, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(424, 349);
            this.panel2.TabIndex = 2;
            // 
            // lsvBill
            // 
            this.lsvBill.HideSelection = false;
            this.lsvBill.Location = new System.Drawing.Point(3, 0);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(421, 375);
            this.lsvBill.TabIndex = 0;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(266, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 56);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // nmCount
            // 
            this.nmCount.Location = new System.Drawing.Point(360, 29);
            this.nmCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmCount.Name = "nmCount";
            this.nmCount.Size = new System.Drawing.Size(64, 27);
            this.nmCount.TabIndex = 3;
            this.nmCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // flpTable
            // 
            this.flpTable.Location = new System.Drawing.Point(0, 4);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(539, 437);
            this.flpTable.TabIndex = 0;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(311, 0);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(110, 63);
            this.btnCheckOut.TabIndex = 3;
            this.btnCheckOut.Text = "Thanh Toán";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // btnDiscount
            // 
            this.btnDiscount.Location = new System.Drawing.Point(3, 0);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(110, 37);
            this.btnDiscount.TabIndex = 4;
            this.btnDiscount.Text = "Giảm giá";
            this.btnDiscount.UseVisualStyleBackColor = true;
            // 
            // nmDiscount
            // 
            this.nmDiscount.Location = new System.Drawing.Point(3, 33);
            this.nmDiscount.Name = "nmDiscount";
            this.nmDiscount.Size = new System.Drawing.Size(110, 27);
            this.nmDiscount.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cboChuyenBan);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(0, 494);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(539, 63);
            this.panel3.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 60);
            this.button1.TabIndex = 5;
            this.button1.Text = "Chuyển Bàn";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cboChuyenBan
            // 
            this.cboChuyenBan.FormattingEnabled = true;
            this.cboChuyenBan.Location = new System.Drawing.Point(102, 32);
            this.cboChuyenBan.Name = "cboChuyenBan";
            this.cboChuyenBan.Size = new System.Drawing.Size(159, 28);
            this.cboChuyenBan.TabIndex = 4;
            // 
            // FrmBarManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 569);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmBarManagement";
            this.Text = " ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.ComboBox cboFoodAndDrink;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown nmCount;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.NumericUpDown nmDiscount;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cboChuyenBan;
        private System.Windows.Forms.Button button1;
    }
}