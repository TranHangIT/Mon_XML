
namespace KhachHang
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMakh = new System.Windows.Forms.TextBox();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtSodt = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chinhanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotenkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sodt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comChiNhanh = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi nhánh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Họ tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số điện thoại";
            // 
            // txtMakh
            // 
            this.txtMakh.Location = new System.Drawing.Point(337, 96);
            this.txtMakh.Name = "txtMakh";
            this.txtMakh.Size = new System.Drawing.Size(196, 30);
            this.txtMakh.TabIndex = 2;
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(337, 144);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(196, 30);
            this.txtHoten.TabIndex = 2;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(337, 192);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(196, 30);
            this.txtDiachi.TabIndex = 2;
            // 
            // txtSodt
            // 
            this.txtSodt.Location = new System.Drawing.Point(337, 240);
            this.txtSodt.Name = "txtSodt";
            this.txtSodt.Size = new System.Drawing.Size(196, 30);
            this.txtSodt.TabIndex = 2;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(621, 34);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(122, 56);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(621, 96);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(122, 56);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(621, 155);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(122, 56);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(621, 216);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(122, 56);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chinhanh,
            this.makh,
            this.hotenkh,
            this.diachi,
            this.sodt});
            this.dataGridView1.Location = new System.Drawing.Point(66, 307);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(804, 227);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // chinhanh
            // 
            this.chinhanh.HeaderText = "Chi nhánh";
            this.chinhanh.MinimumWidth = 8;
            this.chinhanh.Name = "chinhanh";
            this.chinhanh.Width = 150;
            // 
            // makh
            // 
            this.makh.HeaderText = "Mã khách hàng";
            this.makh.MinimumWidth = 8;
            this.makh.Name = "makh";
            this.makh.Width = 150;
            // 
            // hotenkh
            // 
            this.hotenkh.HeaderText = "Họ tên ";
            this.hotenkh.MinimumWidth = 8;
            this.hotenkh.Name = "hotenkh";
            this.hotenkh.Width = 150;
            // 
            // diachi
            // 
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.MinimumWidth = 8;
            this.diachi.Name = "diachi";
            this.diachi.Width = 150;
            // 
            // sodt
            // 
            this.sodt.HeaderText = "Số điện thoại";
            this.sodt.MinimumWidth = 8;
            this.sodt.Name = "sodt";
            this.sodt.Width = 150;
            // 
            // comChiNhanh
            // 
            this.comChiNhanh.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comChiNhanh.FormattingEnabled = true;
            this.comChiNhanh.Items.AddRange(new object[] {
            "Hà Nội ",
            "Hải Phòng ",
            "Quảng Nam",
            "Hải Dương"});
            this.comChiNhanh.Location = new System.Drawing.Point(337, 40);
            this.comChiNhanh.Name = "comChiNhanh";
            this.comChiNhanh.Size = new System.Drawing.Size(196, 33);
            this.comChiNhanh.TabIndex = 5;
            this.comChiNhanh.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 562);
            this.Controls.Add(this.comChiNhanh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtSodt);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.txtMakh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.TextBox txtMakh;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtSodt;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn chinhanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn makh;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotenkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sodt;
        private System.Windows.Forms.ComboBox comChiNhanh;
    }
}

