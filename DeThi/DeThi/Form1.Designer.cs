namespace DeThi
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
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ma = new System.Windows.Forms.TextBox();
            this.txt_tensach = new System.Windows.Forms.TextBox();
            this.txt_sotrang = new System.Windows.Forms.TextBox();
            this.txt_tentg = new System.Windows.Forms.TextBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.butThem = new System.Windows.Forms.Button();
            this.butCapNhat = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tentg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.butTim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số trang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tác giả:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Họ tên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(139, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Địa chỉ";
            // 
            // txt_ma
            // 
            this.txt_ma.Location = new System.Drawing.Point(295, 35);
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.Size = new System.Drawing.Size(100, 20);
            this.txt_ma.TabIndex = 6;
            // 
            // txt_tensach
            // 
            this.txt_tensach.Location = new System.Drawing.Point(295, 62);
            this.txt_tensach.Name = "txt_tensach";
            this.txt_tensach.Size = new System.Drawing.Size(100, 20);
            this.txt_tensach.TabIndex = 7;
            // 
            // txt_sotrang
            // 
            this.txt_sotrang.Location = new System.Drawing.Point(295, 89);
            this.txt_sotrang.Name = "txt_sotrang";
            this.txt_sotrang.Size = new System.Drawing.Size(100, 20);
            this.txt_sotrang.TabIndex = 8;
            // 
            // txt_tentg
            // 
            this.txt_tentg.Location = new System.Drawing.Point(295, 151);
            this.txt_tentg.Name = "txt_tentg";
            this.txt_tentg.Size = new System.Drawing.Size(100, 20);
            this.txt_tentg.TabIndex = 9;
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(295, 177);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(100, 20);
            this.txt_diachi.TabIndex = 10;
            // 
            // butThem
            // 
            this.butThem.Location = new System.Drawing.Point(551, 35);
            this.butThem.Name = "butThem";
            this.butThem.Size = new System.Drawing.Size(75, 23);
            this.butThem.TabIndex = 11;
            this.butThem.Text = "Thêm";
            this.butThem.UseVisualStyleBackColor = true;
            this.butThem.Click += new System.EventHandler(this.butThem_Click);
            // 
            // butCapNhat
            // 
            this.butCapNhat.Location = new System.Drawing.Point(551, 62);
            this.butCapNhat.Name = "butCapNhat";
            this.butCapNhat.Size = new System.Drawing.Size(75, 23);
            this.butCapNhat.TabIndex = 12;
            this.butCapNhat.Text = "Cập nhật";
            this.butCapNhat.UseVisualStyleBackColor = true;
            this.butCapNhat.Click += new System.EventHandler(this.butCapNhat_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma,
            this.tensach,
            this.sotrang,
            this.tentg,
            this.diachi});
            this.dataGridView1.Location = new System.Drawing.Point(145, 242);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(542, 150);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ma
            // 
            this.ma.HeaderText = "Mã sách";
            this.ma.Name = "ma";
            // 
            // tensach
            // 
            this.tensach.HeaderText = "Tên sách";
            this.tensach.Name = "tensach";
            // 
            // sotrang
            // 
            this.sotrang.HeaderText = "Số trang";
            this.sotrang.Name = "sotrang";
            // 
            // tentg
            // 
            this.tentg.HeaderText = "Họ tên tác giả";
            this.tentg.Name = "tentg";
            // 
            // diachi
            // 
            this.diachi.HeaderText = "Địa chỉ tác giả";
            this.diachi.Name = "diachi";
            // 
            // butTim
            // 
            this.butTim.Location = new System.Drawing.Point(551, 90);
            this.butTim.Name = "butTim";
            this.butTim.Size = new System.Drawing.Size(75, 23);
            this.butTim.TabIndex = 14;
            this.butTim.Text = "Tìm";
            this.butTim.UseVisualStyleBackColor = true;
            this.butTim.Click += new System.EventHandler(this.butTim_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butTim);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.butCapNhat);
            this.Controls.Add(this.butThem);
            this.Controls.Add(this.txt_diachi);
            this.Controls.Add(this.txt_tentg);
            this.Controls.Add(this.txt_sotrang);
            this.Controls.Add(this.txt_tensach);
            this.Controls.Add(this.txt_ma);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_ma;
        private System.Windows.Forms.TextBox txt_tensach;
        private System.Windows.Forms.TextBox txt_sotrang;
        private System.Windows.Forms.TextBox txt_tentg;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.Button butThem;
        private System.Windows.Forms.Button butCapNhat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensach;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tentg;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.Button butTim;
    }
}

