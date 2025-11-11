namespace LTTQ_prac
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
            this.dgvHang = new System.Windows.Forms.DataGridView();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbChatLieu = new System.Windows.Forms.ComboBox();
            this.txtDonGiaBan2 = new System.Windows.Forms.TextBox();
            this.txtDonGiaBan1 = new System.Windows.Forms.TextBox();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnInBaoCao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHang)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(439, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1007, 93);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÌM KIẾM HÀNG HOÁ";
            // 
            // dgvHang
            // 
            this.dgvHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHang.Location = new System.Drawing.Point(202, 734);
            this.dgvHang.Name = "dgvHang";
            this.dgvHang.RowHeadersWidth = 92;
            this.dgvHang.RowTemplate.Height = 37;
            this.dgvHang.Size = new System.Drawing.Size(1556, 381);
            this.dgvHang.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(207, 534);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(231, 87);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(514, 534);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(231, 87);
            this.btnIn.TabIndex = 3;
            this.btnIn.Text = "In ra Excel";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbChatLieu);
            this.panel1.Controls.Add(this.txtDonGiaBan2);
            this.panel1.Controls.Add(this.txtDonGiaBan1);
            this.panel1.Controls.Add(this.txtTenHang);
            this.panel1.Controls.Add(this.txtMaHang);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(213, 192);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1545, 240);
            this.panel1.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(893, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 29);
            this.label9.TabIndex = 24;
            this.label9.Text = "(VNĐ)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(492, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 29);
            this.label8.TabIndex = 23;
            this.label8.Text = "(VNĐ)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(621, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 29);
            this.label7.TabIndex = 22;
            this.label7.Text = "đến:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(236, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 29);
            this.label6.TabIndex = 14;
            this.label6.Text = "từ:";
            // 
            // cbChatLieu
            // 
            this.cbChatLieu.FormattingEnabled = true;
            this.cbChatLieu.Location = new System.Drawing.Point(1207, 161);
            this.cbChatLieu.Name = "cbChatLieu";
            this.cbChatLieu.Size = new System.Drawing.Size(309, 37);
            this.cbChatLieu.TabIndex = 21;
            this.cbChatLieu.Click += new System.EventHandler(this.cbChatLieu_Click);
            // 
            // txtDonGiaBan2
            // 
            this.txtDonGiaBan2.Location = new System.Drawing.Point(691, 163);
            this.txtDonGiaBan2.Name = "txtDonGiaBan2";
            this.txtDonGiaBan2.Size = new System.Drawing.Size(191, 35);
            this.txtDonGiaBan2.TabIndex = 20;
            // 
            // txtDonGiaBan1
            // 
            this.txtDonGiaBan1.Location = new System.Drawing.Point(295, 166);
            this.txtDonGiaBan1.Name = "txtDonGiaBan1";
            this.txtDonGiaBan1.Size = new System.Drawing.Size(182, 35);
            this.txtDonGiaBan1.TabIndex = 19;
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(1207, 33);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(309, 35);
            this.txtTenHang.TabIndex = 18;
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(212, 30);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(765, 35);
            this.txtMaHang.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1032, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 29);
            this.label5.TabIndex = 16;
            this.label5.Text = "Chất Liệu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1032, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 29);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tên Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "Đơn Giá Bán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mã Hàng";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(1193, 534);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(231, 87);
            this.btnThoat.TabIndex = 14;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnInBaoCao
            // 
            this.btnInBaoCao.Location = new System.Drawing.Point(840, 534);
            this.btnInBaoCao.Name = "btnInBaoCao";
            this.btnInBaoCao.Size = new System.Drawing.Size(231, 87);
            this.btnInBaoCao.TabIndex = 15;
            this.btnInBaoCao.Text = "In Báo Cáo";
            this.btnInBaoCao.UseVisualStyleBackColor = true;
            this.btnInBaoCao.Click += new System.EventHandler(this.btnInBaoCao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1862, 1145);
            this.Controls.Add(this.btnInBaoCao);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dgvHang);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Tìm kiếm hàng hoá";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvHang;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbChatLieu;
        private System.Windows.Forms.TextBox txtDonGiaBan2;
        private System.Windows.Forms.TextBox txtDonGiaBan1;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnInBaoCao;
    }
}

