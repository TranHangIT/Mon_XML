
namespace De_4
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
            this.txtSogoidi = new System.Windows.Forms.TextBox();
            this.txtSogoiden = new System.Windows.Forms.TextBox();
            this.txtNgaygoi = new System.Windows.Forms.TextBox();
            this.txtSophut = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHoanthanh = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sogoidi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sogoiden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaygoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sophut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "CẬP NHẬT THÔNG TIN CUỘC GỌI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số gọi đi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số gọi đến";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 197);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày gọi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(153, 252);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số phút";
            // 
            // txtSogoidi
            // 
            this.txtSogoidi.Location = new System.Drawing.Point(313, 87);
            this.txtSogoidi.Name = "txtSogoidi";
            this.txtSogoidi.Size = new System.Drawing.Size(241, 30);
            this.txtSogoidi.TabIndex = 1;
            // 
            // txtSogoiden
            // 
            this.txtSogoiden.Location = new System.Drawing.Point(313, 137);
            this.txtSogoiden.Name = "txtSogoiden";
            this.txtSogoiden.Size = new System.Drawing.Size(241, 30);
            this.txtSogoiden.TabIndex = 1;
            // 
            // txtNgaygoi
            // 
            this.txtNgaygoi.Location = new System.Drawing.Point(313, 192);
            this.txtNgaygoi.Name = "txtNgaygoi";
            this.txtNgaygoi.Size = new System.Drawing.Size(241, 30);
            this.txtNgaygoi.TabIndex = 1;
            // 
            // txtSophut
            // 
            this.txtSophut.Location = new System.Drawing.Point(313, 247);
            this.txtSophut.Name = "txtSophut";
            this.txtSophut.Size = new System.Drawing.Size(241, 30);
            this.txtSophut.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(658, 60);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(123, 52);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(658, 119);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(123, 52);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(658, 178);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(123, 52);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnHoanthanh
            // 
            this.btnHoanthanh.Location = new System.Drawing.Point(658, 237);
            this.btnHoanthanh.Name = "btnHoanthanh";
            this.btnHoanthanh.Size = new System.Drawing.Size(123, 52);
            this.btnHoanthanh.TabIndex = 2;
            this.btnHoanthanh.Text = "Hoàn thành";
            this.btnHoanthanh.UseVisualStyleBackColor = true;
            this.btnHoanthanh.Click += new System.EventHandler(this.btnHoanthanh_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.sogoidi,
            this.sogoiden,
            this.ngaygoi,
            this.sophut});
            this.dataGridView1.Location = new System.Drawing.Point(58, 304);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(816, 150);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.MinimumWidth = 8;
            this.stt.Name = "stt";
            this.stt.Width = 150;
            // 
            // sogoidi
            // 
            this.sogoidi.HeaderText = "Số gọi đi";
            this.sogoidi.MinimumWidth = 8;
            this.sogoidi.Name = "sogoidi";
            this.sogoidi.Width = 150;
            // 
            // sogoiden
            // 
            this.sogoiden.HeaderText = "Số gọi đến";
            this.sogoiden.MinimumWidth = 8;
            this.sogoiden.Name = "sogoiden";
            this.sogoiden.Width = 150;
            // 
            // ngaygoi
            // 
            this.ngaygoi.HeaderText = "Ngày gọi";
            this.ngaygoi.MinimumWidth = 8;
            this.ngaygoi.Name = "ngaygoi";
            this.ngaygoi.Width = 150;
            // 
            // sophut
            // 
            this.sophut.HeaderText = "Số phút";
            this.sophut.MinimumWidth = 8;
            this.sophut.Name = "sophut";
            this.sophut.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 492);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnHoanthanh);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtSophut);
            this.Controls.Add(this.txtNgaygoi);
            this.Controls.Add(this.txtSogoiden);
            this.Controls.Add(this.txtSogoidi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.TextBox txtSogoidi;
        private System.Windows.Forms.TextBox txtSogoiden;
        private System.Windows.Forms.TextBox txtNgaygoi;
        private System.Windows.Forms.TextBox txtSophut;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHoanthanh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn sogoidi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sogoiden;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaygoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sophut;
    }
}

