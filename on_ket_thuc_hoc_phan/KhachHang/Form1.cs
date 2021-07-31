using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhachHang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataUtil data = new DataUtil();
        private void Form1_Load(object sender, EventArgs e)
        {
            data.hienthi(dataGridView1);   
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int hang = e.RowIndex;
               comChiNhanh.Text = dataGridView1.Rows[hang].Cells[0].Value + "";
                //comboBoxchinhanh.Text = dataGridView1.Rows[hang].Cells[0].Value + "";

                txtMakh.Text = dataGridView1.Rows[hang].Cells[1].Value + "";
                txtHoten.Text = dataGridView1.Rows[hang].Cells[2].Value + "";
                txtDiachi.Text = dataGridView1.Rows[hang].Cells[3].Value + "";
                txtSodt.Text = dataGridView1.Rows[hang].Cells[4].Value + "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtDiachi.Text !=""&&txtHoten.Text !=""&&txtMakh.Text !=""&&txtSodt.Text !=""&&comChiNhanh.Text != "")
            {
                KhachHang s = new KhachHang();
                s.makh = txtMakh.Text;
                s.diachi = txtDiachi.Text;
                s.hoten = txtHoten.Text;
                s.sodienthoai = txtSodt.Text;
                s.chinhanh = comChiNhanh.Text;

                data.them(s);
                data.hienthi(dataGridView1);

            }
            else
            {
                MessageBox.Show("Phải điền đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtDiachi.Text != "" && txtHoten.Text != "" && txtMakh.Text != "" && txtSodt.Text != "" && comChiNhanh.Text != "")
            {
                KhachHang s = new KhachHang();
                s.makh = txtMakh.Text;
                s.diachi = txtDiachi.Text;
                s.hoten = txtHoten.Text;
                s.sodienthoai = txtSodt.Text;
                s.chinhanh = comChiNhanh.Text;

                data.sua(s);
                data.hienthi(dataGridView1);

            }
            else
            {
                MessageBox.Show("Phải điền đầy đủ thông tin trước khi sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(txtMakh.Text != "")
            {
                KhachHang s = new KhachHang();
                s.makh = txtMakh.Text;

                data.xoa(s);
                data.hienthi(dataGridView1);
            }
            else
            {
                MessageBox.Show("Phải điền mã khách hàng trước khi xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
