using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De_4
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtSogoidi.Text != "" && txtSogoiden.Text != "" && txtNgaygoi.Text != "" && txtSophut.Text != "")
            {
                CuocGoi s = new CuocGoi();
                s.sogoidi = txtSogoidi.Text;
                s.sogoiden = txtSogoiden.Text;
                s.ngaygoi = txtNgaygoi.Text;
                s.sophut = txtSophut.Text;


                data.them(s);
                data.hienthi(dataGridView1);

            }
            else
            {
                MessageBox.Show("Phải điền đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int hang = e.RowIndex;
                txtSogoidi.Text = dataGridView1.Rows[hang].Cells[1].Value + "";
                txtSogoiden.Text = dataGridView1.Rows[hang].Cells[2].Value + "";
                txtNgaygoi.Text = dataGridView1.Rows[hang].Cells[3].Value + "";
                txtSophut.Text = dataGridView1.Rows[hang].Cells[4].Value + "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi "+ ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtSogoidi.Text != "" && txtSogoiden.Text != "" && txtNgaygoi.Text != "" && txtSophut.Text != "")
            {
                CuocGoi s = new CuocGoi();
                s.sogoidi = txtSogoidi.Text;
                s.sogoiden = txtSogoiden.Text;
                s.ngaygoi = txtNgaygoi.Text;
                s.sophut = txtSophut.Text;


                data.sua(s);
                data.hienthi(dataGridView1);

            }
            else
            {
                MessageBox.Show("Phải điền đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(txtSogoidi.Text != "")
            {
                CuocGoi s = new CuocGoi();
                s.sogoidi = txtSogoidi.Text;

                data.xoa(s);
                data.hienthi(dataGridView1);
            }
            else
            {
                MessageBox.Show("Phải điền mã trước khi xóa !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHoanthanh_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
