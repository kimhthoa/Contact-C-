namespace BaiKiemTra01
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.dg2 = new System.Windows.Forms.DataGridView();
            this.dg1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.bds2 = new System.Windows.Forms.BindingSource(this.components);
            this.tenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bds1 = new System.Windows.Forms.BindingSource(this.components);
            this.TenNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.dg2);
            this.panel1.Controls.Add(this.dg1);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 447);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số điện thoại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Địa chỉ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bds2, "ten", true));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel2,
            this.toolStripLabel3,
            this.toolStripLabel4,
            this.toolStripTextBox1,
            this.toolStripLabel5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(649, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Image = global::BaiKiemTra01.Properties.Resources.delete;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(78, 22);
            this.toolStripLabel2.Text = "Xóa nhóm";
            this.toolStripLabel2.Click += new System.EventHandler(this.toolStripLabel2_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Image = global::BaiKiemTra01.Properties.Resources.themll;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(93, 22);
            this.toolStripLabel3.Text = "Thêm liên lạc";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Image = global::BaiKiemTra01.Properties.Resources.xaoll;
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(86, 22);
            this.toolStripLabel4.Text = "Xóa liên lạc ";
            this.toolStripLabel4.Click += new System.EventHandler(this.toolStripLabel4_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(93, 22);
            this.toolStripLabel5.Text = "Nhập từ cần tìm";
            // 
            // dg2
            // 
            this.dg2.AllowUserToAddRows = false;
            this.dg2.AllowUserToDeleteRows = false;
            this.dg2.AutoGenerateColumns = false;
            this.dg2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.sdtDataGridViewTextBoxColumn});
            this.dg2.DataSource = this.bds2;
            this.dg2.Location = new System.Drawing.Point(249, 26);
            this.dg2.Name = "dg2";
            this.dg2.Size = new System.Drawing.Size(391, 264);
            this.dg2.TabIndex = 1;
            // 
            // dg1
            // 
            this.dg1.AllowUserToAddRows = false;
            this.dg1.AllowUserToDeleteRows = false;
            this.dg1.AutoGenerateColumns = false;
            this.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenNhom});
            this.dg1.DataSource = this.bds1;
            this.dg1.Location = new System.Drawing.Point(3, 26);
            this.dg1.Name = "dg1";
            this.dg1.Size = new System.Drawing.Size(240, 418);
            this.dg1.TabIndex = 0;
            this.dg1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg1_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bds2, "diachi", true));
            this.label5.Location = new System.Drawing.Point(367, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bds2, "email", true));
            this.label6.Location = new System.Drawing.Point(367, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bds2, "sdt", true));
            this.label7.Location = new System.Drawing.Point(367, 410);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 9;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Image = global::BaiKiemTra01.Properties.Resources.add1;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(88, 22);
            this.toolStripLabel1.Text = "Thêm nhóm";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // bds2
            // 
            this.bds2.DataSource = typeof(BaiKiemTra01.DAL.ChiTietdb);
            // 
            // tenDataGridViewTextBoxColumn
            // 
            this.tenDataGridViewTextBoxColumn.DataPropertyName = "ten";
            this.tenDataGridViewTextBoxColumn.HeaderText = "Tên";
            this.tenDataGridViewTextBoxColumn.Name = "tenDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // sdtDataGridViewTextBoxColumn
            // 
            this.sdtDataGridViewTextBoxColumn.DataPropertyName = "sdt";
            this.sdtDataGridViewTextBoxColumn.HeaderText = "Số điện thoại";
            this.sdtDataGridViewTextBoxColumn.Name = "sdtDataGridViewTextBoxColumn";
            // 
            // bds1
            // 
            this.bds1.DataSource = typeof(BaiKiemTra01.DAL.Nhomdb);
            // 
            // TenNhom
            // 
            this.TenNhom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenNhom.DataPropertyName = "TenNhom";
            this.TenNhom.HeaderText = "Tên nhóm";
            this.TenNhom.Name = "TenNhom";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 443);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "ap";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.DataGridView dg2;
        private System.Windows.Forms.DataGridView dg1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.BindingSource bds1;
        private System.Windows.Forms.BindingSource bds2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdtDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhom;
    }
}

