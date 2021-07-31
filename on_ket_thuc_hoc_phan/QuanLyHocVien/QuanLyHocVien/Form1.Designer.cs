namespace QuanLyHocVien
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtgioitinh = new System.Windows.Forms.TextBox();
            this.txtngaysinh = new System.Windows.Forms.TextBox();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.txtMasv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.masv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masv,
            this.hoten,
            this.ngaysinh,
            this.gioitinh});
            this.dataGridView1.Location = new System.Drawing.Point(283, 353);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(876, 279);
            this.dataGridView1.TabIndex = 19;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(964, 265);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(163, 69);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(964, 190);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(163, 69);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(964, 117);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(163, 69);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(964, 41);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(163, 69);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // txtgioitinh
            // 
            this.txtgioitinh.Location = new System.Drawing.Point(575, 241);
            this.txtgioitinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtgioitinh.Name = "txtgioitinh";
            this.txtgioitinh.Size = new System.Drawing.Size(273, 22);
            this.txtgioitinh.TabIndex = 11;
            // 
            // txtngaysinh
            // 
            this.txtngaysinh.Location = new System.Drawing.Point(575, 182);
            this.txtngaysinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtngaysinh.Name = "txtngaysinh";
            this.txtngaysinh.Size = new System.Drawing.Size(273, 22);
            this.txtngaysinh.TabIndex = 3;
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(575, 123);
            this.txtHoten.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(273, 22);
            this.txtHoten.TabIndex = 2;
            // 
            // txtMasv
            // 
            this.txtMasv.Location = new System.Drawing.Point(575, 64);
            this.txtMasv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMasv.Name = "txtMasv";
            this.txtMasv.Size = new System.Drawing.Size(273, 22);
            this.txtMasv.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(320, 251);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Gioi tinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 190);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ngay sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Họ tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = " ma sinh vien";
            // 
            // masv
            // 
            this.masv.HeaderText = "Ma SV";
            this.masv.Name = "masv";
            this.masv.Width = 200;
            // 
            // hoten
            // 
            this.hoten.HeaderText = "Ho Ten";
            this.hoten.Name = "hoten";
            this.hoten.Width = 200;
            // 
            // ngaysinh
            // 
            this.ngaysinh.HeaderText = "NgaySinh";
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Width = 200;
            // 
            // gioitinh
            // 
            this.gioitinh.HeaderText = "Gioi Tinh";
            this.gioitinh.Name = "gioitinh";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1520, 698);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtgioitinh);
            this.Controls.Add(this.txtngaysinh);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.txtMasv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form nhap";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn masv;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtgioitinh;
        private System.Windows.Forms.TextBox txtngaysinh;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.TextBox txtMasv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

