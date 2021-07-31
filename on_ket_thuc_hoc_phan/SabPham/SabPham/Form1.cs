using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SabPham
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataUtil data = new DataUtil();
       

        private void btndocfile_Click(object sender, EventArgs e)
        {
            data.HienThi(dataGridView2);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
             if(txtMahang.Text !=""&&txttenhang.Text !=""&&txtQuocgia.Text !=""&& txtMaSP.Text !=""&&txtTensp.Text != "" && txtsoluong.Text != "" && txtNamsx.Text != "")
            {
                hangsxS s = new hangsxS();
                s.masp = txtMaSP.Text;
                s.tensp = txtTensp.Text;
                s.soluong = txtsoluong.Text;
                s.namsanxuat = txtNamsx.Text;
                s.mahang = txtMahang.Text;
                s.tenhang = txttenhang.Text;
                s.quocgia = txtQuocgia.Text;

                data.them(s);
                data.HienThi(dataGridView2);

            }
            else
            {
                MessageBox.Show("Phải điền đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int index = dataGridView2.CurrentCell.RowIndex;
            txtMaSP.Text = dataGridView2.Rows[index].Cells[0].Value.ToString();
            txtTensp.Text = dataGridView2.Rows[index].Cells[1].Value.ToString();
            txtsoluong.Text = dataGridView2.Rows[index].Cells[2].Value.ToString();
     
            txtNamsx.Text = dataGridView2.Rows[index].Cells[3].Value.ToString();
            txtMahang.Text = dataGridView2.Rows[index].Cells[4].Value.ToString();
            txttenhang.Text = dataGridView2.Rows[index].Cells[5].Value.ToString();
            txtQuocgia.Text = dataGridView2.Rows[index].Cells[6].Value.ToString();


        }
    }
}
