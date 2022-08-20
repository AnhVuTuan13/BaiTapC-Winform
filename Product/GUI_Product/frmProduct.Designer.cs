
namespace GUI_Product
{
    partial class frmProduct
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbChungloai = new System.Windows.Forms.ComboBox();
            this.txtmahang = new System.Windows.Forms.TextBox();
            this.txttenhang = new System.Windows.Forms.TextBox();
            this.txtNSX = new System.Windows.Forms.TextBox();
            this.txtSLcon = new System.Windows.Forms.TextBox();
            this.dtNhap = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Mahang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhasanxuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaynhapkho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluongcon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btThem = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chủng Loại ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(195, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quản Lý Cửa Hàng Máy Tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Hàng ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên Hàng ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nhà Sản Xuất";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày Nhập Kho";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Số Lượng còn";
            // 
            // cbChungloai
            // 
            this.cbChungloai.FormattingEnabled = true;
            this.cbChungloai.Location = new System.Drawing.Point(155, 56);
            this.cbChungloai.Name = "cbChungloai";
            this.cbChungloai.Size = new System.Drawing.Size(146, 23);
            this.cbChungloai.TabIndex = 7;
            // 
            // txtmahang
            // 
            this.txtmahang.Location = new System.Drawing.Point(155, 85);
            this.txtmahang.Name = "txtmahang";
            this.txtmahang.Size = new System.Drawing.Size(125, 22);
            this.txtmahang.TabIndex = 8;
            // 
            // txttenhang
            // 
            this.txttenhang.Location = new System.Drawing.Point(155, 126);
            this.txttenhang.Name = "txttenhang";
            this.txttenhang.Size = new System.Drawing.Size(125, 22);
            this.txttenhang.TabIndex = 9;
            // 
            // txtNSX
            // 
            this.txtNSX.Location = new System.Drawing.Point(155, 157);
            this.txtNSX.Name = "txtNSX";
            this.txtNSX.Size = new System.Drawing.Size(125, 22);
            this.txtNSX.TabIndex = 10;
            // 
            // txtSLcon
            // 
            this.txtSLcon.Location = new System.Drawing.Point(155, 227);
            this.txtSLcon.Name = "txtSLcon";
            this.txtSLcon.Size = new System.Drawing.Size(125, 22);
            this.txtSLcon.TabIndex = 12;
            // 
            // dtNhap
            // 
            this.dtNhap.Location = new System.Drawing.Point(155, 194);
            this.dtNhap.Name = "dtNhap";
            this.dtNhap.Size = new System.Drawing.Size(200, 22);
            this.dtNhap.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mahang,
            this.Tenhang,
            this.nhasanxuat,
            this.ngaynhapkho,
            this.soluongcon});
            this.dataGridView1.Location = new System.Drawing.Point(32, 275);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(582, 170);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Mahang
            // 
            this.Mahang.DataPropertyName = "Mahang";
            this.Mahang.HeaderText = "Mahang";
            this.Mahang.Name = "Mahang";
            // 
            // Tenhang
            // 
            this.Tenhang.DataPropertyName = "Tenhang";
            this.Tenhang.HeaderText = "Tenhang";
            this.Tenhang.Name = "Tenhang";
            // 
            // nhasanxuat
            // 
            this.nhasanxuat.DataPropertyName = "nhasanxuat";
            this.nhasanxuat.HeaderText = "Nhasanxuat";
            this.nhasanxuat.Name = "nhasanxuat";
            // 
            // ngaynhapkho
            // 
            this.ngaynhapkho.DataPropertyName = "ngaynhapkho";
            this.ngaynhapkho.HeaderText = "Ngaynhapkho";
            this.ngaynhapkho.Name = "ngaynhapkho";
            // 
            // soluongcon
            // 
            this.soluongcon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.soluongcon.DataPropertyName = "soluongcon";
            this.soluongcon.HeaderText = "Soluongcon";
            this.soluongcon.Name = "soluongcon";
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(482, 66);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(93, 23);
            this.btThem.TabIndex = 15;
            this.btThem.Text = "Thêm Hàng";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(482, 95);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(93, 23);
            this.btXoa.TabIndex = 16;
            this.btXoa.Text = "Xóa Hàng";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btDong
            // 
            this.btDong.Location = new System.Drawing.Point(482, 227);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(93, 23);
            this.btDong.TabIndex = 17;
            this.btDong.Text = "Đóng";
            this.btDong.UseVisualStyleBackColor = true;
            this.btDong.Click += new System.EventHandler(this.btDong_Click);
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 457);
            this.Controls.Add(this.btDong);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dtNhap);
            this.Controls.Add(this.txtSLcon);
            this.Controls.Add(this.txtNSX);
            this.Controls.Add(this.txttenhang);
            this.Controls.Add(this.txtmahang);
            this.Controls.Add(this.cbChungloai);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmProduct";
            this.Text = "frmProduct";
            this.Load += new System.EventHandler(this.frmProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbChungloai;
        private System.Windows.Forms.TextBox txtmahang;
        private System.Windows.Forms.TextBox txttenhang;
        private System.Windows.Forms.TextBox txtNSX;
        private System.Windows.Forms.TextBox txtSLcon;
        private System.Windows.Forms.DateTimePicker dtNhap;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mahang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhasanxuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaynhapkho;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongcon;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btDong;
    }
}