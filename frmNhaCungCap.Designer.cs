﻿namespace ShopBanGiay
{
	partial class frmNhaCungCap
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
			this.dgvNCC = new System.Windows.Forms.DataGridView();
			this.ctmsChitietNCC = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.xoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.txtMaNCC = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtTinhTrangNhap = new System.Windows.Forms.TextBox();
			this.txtDiaChi = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtSDT = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtTenNCC = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.btnThongKe = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).BeginInit();
			this.ctmsChitietNCC.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Control;
			this.panel1.Controls.Add(this.dgvNCC);
			this.panel1.Controls.Add(this.groupBox2);
			this.panel1.Controls.Add(this.groupBox3);
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Location = new System.Drawing.Point(1, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1081, 631);
			this.panel1.TabIndex = 27;
			// 
			// dgvNCC
			// 
			this.dgvNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvNCC.ContextMenuStrip = this.ctmsChitietNCC;
			this.dgvNCC.Location = new System.Drawing.Point(13, 91);
			this.dgvNCC.Name = "dgvNCC";
			this.dgvNCC.Size = new System.Drawing.Size(505, 533);
			this.dgvNCC.TabIndex = 25;
			this.dgvNCC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNCC_CellClick);
			// 
			// ctmsChitietNCC
			// 
			this.ctmsChitietNCC.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xoaToolStripMenuItem});
			this.ctmsChitietNCC.Name = "ctmsChitietNCC";
			this.ctmsChitietNCC.Size = new System.Drawing.Size(170, 26);
			// 
			// xoaToolStripMenuItem
			// 
			this.xoaToolStripMenuItem.Name = "xoaToolStripMenuItem";
			this.xoaToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
			this.xoaToolStripMenuItem.Text = "Xóa nhà cung cấp";
			this.xoaToolStripMenuItem.Click += new System.EventHandler(this.xoaToolStripMenuItem_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnThongKe);
			this.groupBox2.Location = new System.Drawing.Point(525, 356);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox2.Size = new System.Drawing.Size(216, 91);
			this.groupBox2.TabIndex = 13;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Chức năng";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.btnClear);
			this.groupBox3.Controls.Add(this.btnThem);
			this.groupBox3.Controls.Add(this.txtMaNCC);
			this.groupBox3.Controls.Add(this.label1);
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.Controls.Add(this.txtTinhTrangNhap);
			this.groupBox3.Controls.Add(this.txtDiaChi);
			this.groupBox3.Controls.Add(this.txtEmail);
			this.groupBox3.Controls.Add(this.btnThoat);
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Controls.Add(this.txtSDT);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Controls.Add(this.txtTenNCC);
			this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(525, 10);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox3.Size = new System.Drawing.Size(542, 612);
			this.groupBox3.TabIndex = 24;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Thông tin nhà cung cung cấp";
			// 
			// txtMaNCC
			// 
			this.txtMaNCC.Location = new System.Drawing.Point(155, 52);
			this.txtMaNCC.Margin = new System.Windows.Forms.Padding(4);
			this.txtMaNCC.MaxLength = 25;
			this.txtMaNCC.Name = "txtMaNCC";
			this.txtMaNCC.ReadOnly = true;
			this.txtMaNCC.Size = new System.Drawing.Size(168, 26);
			this.txtMaNCC.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 55);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 19);
			this.label1.TabIndex = 9;
			this.label1.Text = "Id NCC";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(11, 106);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 19);
			this.label2.TabIndex = 10;
			this.label2.Text = "Tên NCC";
			// 
			// txtTinhTrangNhap
			// 
			this.txtTinhTrangNhap.Location = new System.Drawing.Point(155, 301);
			this.txtTinhTrangNhap.Margin = new System.Windows.Forms.Padding(4);
			this.txtTinhTrangNhap.MaxLength = 25;
			this.txtTinhTrangNhap.Name = "txtTinhTrangNhap";
			this.txtTinhTrangNhap.Size = new System.Drawing.Size(168, 26);
			this.txtTinhTrangNhap.TabIndex = 4;
			// 
			// txtDiaChi
			// 
			this.txtDiaChi.Location = new System.Drawing.Point(155, 252);
			this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
			this.txtDiaChi.MaxLength = 25;
			this.txtDiaChi.Name = "txtDiaChi";
			this.txtDiaChi.Size = new System.Drawing.Size(168, 26);
			this.txtDiaChi.TabIndex = 4;
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(155, 203);
			this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
			this.txtEmail.MaxLength = 25;
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(168, 26);
			this.txtEmail.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(11, 157);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 19);
			this.label3.TabIndex = 11;
			this.label3.Text = "Số điện thoại";
			// 
			// txtSDT
			// 
			this.txtSDT.Location = new System.Drawing.Point(155, 152);
			this.txtSDT.Margin = new System.Windows.Forms.Padding(4);
			this.txtSDT.MaxLength = 10;
			this.txtSDT.Name = "txtSDT";
			this.txtSDT.Size = new System.Drawing.Size(168, 26);
			this.txtSDT.TabIndex = 2;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(11, 210);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(42, 19);
			this.label5.TabIndex = 12;
			this.label5.Text = "Email";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(11, 304);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(69, 19);
			this.label6.TabIndex = 12;
			this.label6.Text = "Tình trạng";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(11, 255);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(51, 19);
			this.label4.TabIndex = 12;
			this.label4.Text = "Địa chỉ";
			// 
			// txtTenNCC
			// 
			this.txtTenNCC.Location = new System.Drawing.Point(155, 102);
			this.txtTenNCC.Margin = new System.Windows.Forms.Padding(4);
			this.txtTenNCC.MaxLength = 25;
			this.txtTenNCC.Name = "txtTenNCC";
			this.txtTenNCC.Size = new System.Drawing.Size(168, 26);
			this.txtTenNCC.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(13, 6);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new System.Drawing.Size(505, 78);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Tìm theo tên nhà cung cấp";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(8, 27);
			this.textBox1.Margin = new System.Windows.Forms.Padding(4);
			this.textBox1.MaxLength = 25;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(269, 26);
			this.textBox1.TabIndex = 0;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// btnThongKe
			// 
			this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnThongKe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThongKe.Image = global::ShopBanGiay.Properties.Resources.thongke1;
			this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnThongKe.Location = new System.Drawing.Point(9, 21);
			this.btnThongKe.Margin = new System.Windows.Forms.Padding(4);
			this.btnThongKe.Name = "btnThongKe";
			this.btnThongKe.Size = new System.Drawing.Size(199, 61);
			this.btnThongKe.TabIndex = 6;
			this.btnThongKe.Text = "Xem thống kê";
			this.btnThongKe.UseVisualStyleBackColor = true;
			this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
			// 
			// btnClear
			// 
			this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClear.Image = global::ShopBanGiay.Properties.Resources.reset1;
			this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClear.Location = new System.Drawing.Point(365, 100);
			this.btnClear.Margin = new System.Windows.Forms.Padding(4);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(40, 39);
			this.btnClear.TabIndex = 2;
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnThem
			// 
			this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnThem.Image = global::ShopBanGiay.Properties.Resources.save2;
			this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnThem.Location = new System.Drawing.Point(365, 52);
			this.btnThem.Margin = new System.Windows.Forms.Padding(4);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(40, 40);
			this.btnThem.TabIndex = 4;
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnThoat.Image = global::ShopBanGiay.Properties.Resources.exit1;
			this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnThoat.Location = new System.Drawing.Point(365, 147);
			this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(40, 39);
			this.btnThoat.TabIndex = 5;
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// frmNhaCungCap
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1084, 637);
			this.Controls.Add(this.panel1);
			this.Name = "frmNhaCungCap";
			this.Text = "Nhà cung cấp";
			this.Load += new System.EventHandler(this.frmNhaCungCap_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).EndInit();
			this.ctmsChitietNCC.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView dgvNCC;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnThongKe;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.TextBox txtMaNCC;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtTinhTrangNhap;
		private System.Windows.Forms.TextBox txtDiaChi;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtSDT;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtTenNCC;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.ContextMenuStrip ctmsChitietNCC;
		private System.Windows.Forms.ToolStripMenuItem xoaToolStripMenuItem;
	}
}